using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.IMemory
{
    public class IMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public IMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=9,ColorId=6,ModelYear=2021,DailyPrice=100,Description="karavan tarzı"},
                new Car{Id=2,BrandId=8,ColorId=3,ModelYear=2020,DailyPrice=90,Description="siyah üstü açık araba"},
                new Car{Id=3,BrandId=7,ColorId=2,ModelYear=2019,DailyPrice=80,Description="eski tarz araba"},
                new Car{Id=4,BrandId=6,ColorId=1,ModelYear=2018,DailyPrice=70,Description="mavi araba"},
                new Car{Id=5,BrandId=5,ColorId=8,ModelYear=2017,DailyPrice=60,Description="kırmızı araba"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList(); 
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
