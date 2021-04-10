using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear="2015",DailyPrice=200,Description="Mercedes"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear="2010",DailyPrice=200,Description="Audi"},
                new Car{Id=3,BrandId=1,ColorId=1,ModelYear="2013",DailyPrice=200,Description="Renault"},
                new Car{Id=4,BrandId=1,ColorId=2,ModelYear="2015",DailyPrice=200,Description="BMW"},
                new Car{Id=5,BrandId=1,ColorId=1,ModelYear="2000",DailyPrice=200,Description="Opel"},
            };

        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToDelete);
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
            return _cars.Where(p=>p.Id==car.Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToUpdate);

        }
    }
}
