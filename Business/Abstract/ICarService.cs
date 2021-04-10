using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();//Tüm araçları getirir
        IDataResult<Car> GetById(int carId);//tek bir aracı getir
        IDataResult<List<Car>> GetAllByColorId(int id); //renk Id sine göre getirir
        IDataResult<List<Car>> GetAllByBrandId(int id); //marka Id sine göre getirir

        IDataResult<List<CarDetailDto>> GetCarDetails(); //Car detay tablomuzdaki kayıtları getirir

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

    }
}
