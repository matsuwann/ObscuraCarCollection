using CarCollectionsModel;
using System;
using System.Collections.Generic;

public class carInfo
{
    public List<Car> carList = new List<Car>();
    public static void DisplayCarInfo(Car car)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Car Brand: " + car.Brand);
        Console.WriteLine("Car Model: " + car.Model);
        Console.WriteLine("Year Model: " + car.yearModel);
        Console.WriteLine("Car Type: " + car.type);
        Console.WriteLine("Rent Price: " + car.RentPrice);
        Console.WriteLine("Availability: " + car.availability);
    }
}