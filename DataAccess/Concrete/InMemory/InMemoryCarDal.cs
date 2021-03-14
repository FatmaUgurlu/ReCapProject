using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=120, Description="Seat Ibiza-Benzinli ve otomatik vites", ModelYear="2019"},
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=150, Description="Ford Focus-Dizel ve otomatik vites", ModelYear="2018"},
                new Car{Id=3, BrandId=3, ColorId=3, DailyPrice=130, Description="Fiat Egea-Benzinli ve manuel vites", ModelYear="2020"},
                new Car{Id=4, BrandId=4, ColorId=2, DailyPrice=180, Description="Merdeces C180-Benzinli ve manuel vites", ModelYear="2017"},
                new Car{Id=5, BrandId=5, ColorId=3, DailyPrice=110, Description="Nissan Micra-Dizel ve otomatik vites", ModelYear="2019"},
                new Car{Id=6, BrandId=6, ColorId=1, DailyPrice=140, Description="Audi A3-Benzinli ve otomatik vites", ModelYear="2020"}
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

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
