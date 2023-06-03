using System;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            
            if (CarIsRented(rental.CarId))
            {
                return new ErrorResult(Messages.RentalCarAlreadyRented);
            }
            /*else if(rental.ReturnDate == null)
            {
                rental.ReturnDate = null;
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }*/
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        public IDataResult<List<Rental>> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r=> r.CustomerId == customerId), Messages.RentalsListed);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=> r.Id == rentalId), Messages.RentalsListed);
        }

        bool CarIsRented(int carId)
        {
            var rentedcar = _rentalDal.Get(r => r.CarId == carId && r.ReturnDate == null);

            if (rentedcar != null)
            {
                if (rentedcar.CarId == carId)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

