using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Console
{
    class Program
    {

        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());

            System.Console.WriteLine(carManager.GetAll().Message);
            foreach (var cr in carManager.GetAll().Data)
            {
                
                System.Console.WriteLine(cr.CarId);
            }

            System.Console.WriteLine("------------------------------");

            System.Console.WriteLine(carManager.GetById(1).Message);
            
            System.Console.WriteLine(carManager.GetById(1).Data.CarId);
            

            System.Console.WriteLine("-------------------------------");

            System.Console.WriteLine(carManager.GetCarsByBrandId(1).Message);
            foreach (var cr in carManager.GetCarsByBrandId(1).Data)
            {
                System.Console.WriteLine(cr.CarId);
            }

            System.Console.WriteLine("-------------------------------");

            System.Console.WriteLine(carManager.GetCarsByColorId(2).Message);
            foreach (var cr in carManager.GetCarsByColorId(2).Data)
            {
                System.Console.WriteLine(cr.CarId);
            }

            System.Console.WriteLine("-------------------------------");

            System.Console.WriteLine(carManager.GetCarDetail().Message);
            foreach (var cr in carManager.GetCarDetail().Data)
            {
                System.Console.WriteLine($"{cr.BrandName} / {cr.ColorName} / {cr.DailyPrice} / {cr.Description}");
            }

            System.Console.ReadLine();


        }

    }
}
