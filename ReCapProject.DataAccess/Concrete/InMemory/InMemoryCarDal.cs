﻿using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReCapProject.DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>{
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 250000, Description = "Seat Leon",ModelYear="2019" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 270000, Description = "Volkswagen Golf", ModelYear = "2019" },
                new Car { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 175000, Description = "Volkswagen Polo", ModelYear = "2017" },
                new Car { Id = 4, BrandId = 4, ColorId = 3, DailyPrice = 180000, Description = "Renault Megane", ModelYear = "2018" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int Id)
        {
            return _cars = _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
