﻿using System;
using System.Reflection;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
	public class AspectInterceptorSelector : IInterceptorSelector
	{
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttiribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttiribute>(true);
            classAttributes.AddRange(methodAttributes);
            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}

