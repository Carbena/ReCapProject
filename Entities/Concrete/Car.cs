using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entities.Concrete
{
	public class Car:IEntity
	{
		[Key]
		public int CarId { get; set; }
		public int BrandId { get; set; }
		public int ColorId { get; set; }
		public int ModelYear { get; set; }
		public int DailyPrice { get; set; }
		public string? Description { get; set; }

		public Car()
		{

		}
	}
}

