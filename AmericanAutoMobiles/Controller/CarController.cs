using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AmericanAutoMobiles.Model;

namespace AmericanAutoMobiles.Controller
{
    public class CarController : ApiController
    {
        public List<Car> GetCarsByDealer(int id)
        {
            DbContext db = new DbContext();

            if (id == 1)
                return ProcessCars(db.GetDealer1Cars());
            else
                return ProcessCars(db.GetDealer2Cars());


        }
        public List<Car> ProcessCars<T>(List<T> Cars) where T : Car
        {
            List<Car> mycars = new List<Car>();

            foreach (var item in Cars)
            {
                mycars.Add(
                    new Car {
                        Price = item.Price,
                        Model = item.Model,
                        Mileage = item.Mileage,
                        Color = item.Color,
                        Status = item.GetStatus()
                    }
                    );
           
            }
            return mycars;
        }

    }
}
