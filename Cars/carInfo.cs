using CarCollectionsModel;
using System;
using System.Collections.Generic;


public class carInfo
{
    public List<Car> carList = new List<Car>();
    public static void DisplayCarInfo(Car car)
    {
        Console.WriteLine();
        Console.WriteLine("Car Brand: " + car.Brand);
        Console.WriteLine("Car Model: " + car.Model);
        Console.WriteLine("Year Model: " + car.yearModel);
        Console.WriteLine("Transmission: " + car.transmission);
        Console.WriteLine("Top Speed: " + car.topSpeed);
        Console.WriteLine("Engine: " + car.engine);
    }

    public static void DisplayCarInfo(object value)
    {
        throw new NotImplementedException();
    }
}