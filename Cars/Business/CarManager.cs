using Cars.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Business;

public class CarManager
{
    Car[] cars = new Car[3];
    public CarManager()
    {
        //dummy start
        Car car1 = new Car();
        car1.Id = 1;
        car1.Name = "Mercedes";
        car1.ModelYear = "2043";
        car1.FuelType = "Diesel";

        Car car2 = new Car();
        car2.Id = 2;
        car2.Name = "Nissan Skyline";
        car2.ModelYear = "2000";
        car2.FuelType = "Gasoline";

        Car car3 = new Car();
        car3.Id = 3;
        car3.Name = "Porsche";
        car3.ModelYear = "2023";
        car3.FuelType = "Gasoline";

        cars = [car1, car2, car3];
        //cars[0]=car1;
        //cars[1]=car2;
        //cars[2]=car3;
    }

    public Car[] GetCars()
    {
        return cars;
    }
}