using CarCollectionsModel;
using System;
using System.Collections.Generic;

namespace CarCollectionsDL;


public class Collection
{
    public List<Car> carsList = new List<Car>();

    public Collection()
    {
        Car carOne = new Car();
        carOne.Brand = "Toyota";
        carOne.Model = "Corolla Hatchback";
        carOne.yearModel = 2019;
        carOne.transmission = "Automatic";
        carOne.topSpeed = "111 mph";
        carOne.engine = "1987cc, 4 cylinders";
        carsList.Add(carOne);

        Car carTwo = new Car();
        carTwo.Brand = "Honda";
        carTwo.Model = "Civc Hatchback";
        carTwo.yearModel = 2019;
        carTwo.transmission = "Automatic";
        carTwo.topSpeed = "111 mph";
        carTwo.engine = "1993cc, 4 cylinders";
        carsList.Add(carTwo);

        Car carThree = new Car();
        carThree.Brand = "Hyundai";
        carThree.Model = "Ioniq Hatchback";
        carThree.yearModel = 2019;
        carThree.transmission = "Automatic";
        carThree.topSpeed = "115 mph";
        carThree.engine = "1580cc, 4 cylinders";
        carsList.Add(carThree);
    }
    public void CarList()
    {
        Console.WriteLine("\nView Car Information");
        Console.WriteLine("1. Toyota");
        Console.WriteLine("2. Honda");
        Console.WriteLine("3. Hyundai");
        Console.Write("\nPlease Select a Car to view information: ");
        string information = Console.ReadLine();

        switch (information)
        {
            case "1":
                carInfo.DisplayCarInfo(carsList[0]);
                return;

            case "2":
                carInfo.DisplayCarInfo(carsList[1]);
                return;

            case "3":
                carInfo.DisplayCarInfo(carsList[2]);
                return;

            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
}