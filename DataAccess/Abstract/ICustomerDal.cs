﻿using System;
using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
	public interface ICustomerDal:IEntityRepository<Customer>
	{
		List<CustomerDetailDto> GetCustomerDetail();
	}
}

