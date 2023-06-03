using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICarImageService
	{
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int brandId);
        IResult Add(CarImage carImage);
        IResult Update(CarImage carImage);
        IResult Delete(CarImage carImage);
    }
}

