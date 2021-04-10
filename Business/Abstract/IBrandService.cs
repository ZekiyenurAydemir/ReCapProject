using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();//tüm markaları getir

        IDataResult<Brand> GetById(int brandId);//tek bir markayı getir
        IResult Add(Brand brand);//marka ekle
        IResult Update(Brand brand);//marka güncelle
        IResult Delete(Brand brand);//marka sil
    }
}
