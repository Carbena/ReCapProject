﻿using System;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfBrandDal : EfEntityRepositoryBase<Brand,ReCapProjectContext>,IBrandDal
	{
    

    }
}

