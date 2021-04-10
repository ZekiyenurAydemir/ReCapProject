using System;
using DataAccess.Concrete.InMemory;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        { 
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void CarDetail()
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //Console.WriteLine("\nAraç\t\tMarka\t Renk\tÜcret\tAçıklama");
            //Console.WriteLine("------------------------------------------------");

            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName + "\t" + car.BrandName + "\t" + car.ColorName + "\t " + car.DailyPrice + "\t" + car.Description);
            //}
        }
    }
}
