// See https://aka.ms/new-console-template for more information
using Cars.Business;
using Cars.Entities;

CarManager carManager = new CarManager();
Car[] cars= carManager.GetCars();

for (int i = 0; i < cars.Length; i++)
{
    Console.Write($"Car Name:{cars[i].Name} // Car FuelType:{cars[i].FuelType}\n");
}