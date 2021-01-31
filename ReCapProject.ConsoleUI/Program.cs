using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.DataAccess.Concrete.InMemory;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ReCapProject.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("*******************GETALL**************");
            GetAll(carManager.GetAll());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*******************ADD**************");
            carManager.Add(new Car { Id = 5, BrandId = 1, ColorId = 1, DailyPrice = 150000, Description = "Seat Ibıza", ModelYear = "2017" } );
            GetAll(carManager.GetAll());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*******************UPDATE**************");
            Console.WriteLine("*******************SEAT IBIZA FİYATI GÜNCELLEDİ**************");
            carManager.Update(new Car { Id = 5, BrandId = 1, ColorId = 1, DailyPrice = 160000, Description = "Seat Ibıza", ModelYear = "2017" });
            GetAll(carManager.GetAll());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*******************DELETE**************");
            Console.WriteLine("*******************IBIZA YOK ARTIK**************");
            carManager.Delete(new Car { Id = 5});
            GetAll(carManager.GetAll());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*******************GET ALL BY ID**************");
            Console.WriteLine("*******************LEON**************");
            GetAll(carManager.GetAllById(1));

        }
        public static void GetAll(List<Car> cars) 
        {
            foreach (var car in cars)
            {
                Console.WriteLine("Arabalar :" + car.Description + "  Fiyat:  " + car.DailyPrice);
            }
        }
    }
}
