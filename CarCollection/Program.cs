using CarCollectionsBL;
using CarCollectionsDL;
using CarCollectionsModel;
using System;
using System.Collections.Generic;

public class Program
{
    static Collection carCollection = new Collection();

    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.Write("Enter Admin ID: ");
        string adminNumber = Console.ReadLine();

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.Write("Enter Admin Password: ");
        string adminPassword = Console.ReadLine();

        AdminService admin = new AdminService();
        bool result = admin.VerifyAdmin(adminNumber, adminPassword);

        if (result)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome!");
        }
        else
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Wrong admin info!!!!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            return;
        }

        while (true)
        {
            Program CarsList = new Program();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Options:");
            Console.WriteLine("1. View Collection Information");
            Console.WriteLine("2. View Cars");
            Console.WriteLine("3. Add Cars");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");
            string choice = Console.ReadLine();
            
            
            switch (choice)
            {
                case "1":
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Obscura Car Rental");
                    Console.WriteLine("\nWelcome to our ongoing little car rental collection, " +
                                      "where automotive excellence is displayed ");
                    break;

                case "2":
                    CarsList.CarList(carCollection.carsList);
                    break;

                case "3":
                    Car Rac = new Car();

                    Console.Write("\nEnter Car Brand: ");
                    Rac.Brand = Console.ReadLine();
                    Console.Write("Enter Car Model: ");
                    Rac.Model = Console.ReadLine();
                    Console.Write("Enter Year Model: ");
                    Rac.yearModel = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Car Type: ");
                    Rac.type = Console.ReadLine();
                    Console.Write("Enter Rent Price: ");
                    Rac.RentPrice = Convert.ToInt32(Console.ReadLine());
                    Rac.availability = true;
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Added Car: ");
                    carInfo.DisplayCarInfo(Rac); 

                    break;

                case "4":
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Thank you for checking our collection. Goodbye!");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    return;

                default:
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
    public void CarList(List<Car> carsList)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("View Car Information");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("1. Toyota");
        Console.WriteLine("2. Honda");
        Console.WriteLine("3. Hyundai");
        Console.Write("Please Select a Car to view information: ");
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