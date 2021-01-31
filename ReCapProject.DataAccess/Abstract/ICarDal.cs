using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetAllById(int Id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
