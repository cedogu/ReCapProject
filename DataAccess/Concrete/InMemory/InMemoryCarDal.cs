﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()  {

                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 500, ModelYear = "1960", Description = "Classic Chevrolet" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 600, ModelYear = "1970", Description = "Classic Buick" },
                new Car { Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 400, ModelYear = "1967", Description = "Classic Chevrolet" },
            };
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(Car car)
        {
            return _cars.Where(c => c.Id == car.Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = 6;
        }
    }
}
