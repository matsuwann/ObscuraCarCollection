using CarCollectionsModel;
using System;
using System.Collections.Generic;

namespace CarCollectionsDL;


public class Collection
{
    public List<Car> carsList = new List<Car>();

    public Collection() 
    {
        Collections();
    }

    public void Collections()
    {
        Car carOne = new Car();
        carOne.Brand = "Toyota";
        carOne.Model = "Corolla ";
        carOne.yearModel = 2019;
        carOne.type = "Hatchback";
        carOne.RentPrice = 450;
        carOne.availability = true;
        carsList.Add(carOne);

        Car carTwo = new Car();
        carTwo.Brand = "Honda";
        carTwo.Model = "Civc";
        carTwo.yearModel = 2019;
        carTwo.type = "Hatchbackt";
        carTwo.RentPrice = 500;
        carTwo.availability = false;
        carsList.Add(carTwo);

        Car carThree = new Car();
        carThree.Brand = "Hyundai";
        carThree.Model = "Ioniq";
        carThree.yearModel = 2019;
        carThree.type = "Hatchback";
        carThree.RentPrice = 400;
        carThree.availability = true;
        carsList.Add(carThree);
    }
    public List<Car> GetCars()
    {
        return carsList;
    }
}