using System;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=100,Description="hastasina"},
                new Car{CarId=2,BrandId=2,ColorId=2,ModelYear=2021,DailyPrice=150,Description="delisine"},
                new Car{CarId=3,BrandId=3,ColorId=3,ModelYear=2022,DailyPrice=200,Description="sevdalisina"},
                new Car{CarId=4,BrandId=4,ColorId=4,ModelYear=2023,DailyPrice=250,Description="manyagina"},
                new Car{CarId=5,BrandId=5,ColorId=5,ModelYear=2019,DailyPrice=300,Description="sapigina"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(cr => cr.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(cr => cr.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.Single(cr => cr.CarId == id);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }
    }
}

