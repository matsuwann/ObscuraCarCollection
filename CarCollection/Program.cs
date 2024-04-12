using CarCollectionsBL;
using CarCollectionsDL;
using System;
using System.Collections.Generic;


public class Program
{
    static Collection carCollection = new Collection();

    static void Main(string[] args)
    {

        Console.WriteLine("Enter Admin ID: ");
        string adminNumber = Console.ReadLine();

        AdminService admin = new AdminService();
        bool result = admin.VerifyAdmin(adminNumber);

        if (result)
        {
            Console.WriteLine("Welcome!");
        }

        else
        {
            Console.WriteLine("Wrong admin number!!!!");
            return;
        }


        while (true)
       {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. View Collection Information");
            Console.WriteLine("2. View Cars");
            Console.WriteLine("3. Exit");
            Console.Write("Please select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":              
                    Console.WriteLine("\nObscura Collection");
                    Console.WriteLine("\nWelcome to our ongoing little car collection, " +
                                      "where automotive excellence is displayed");
                    break;

                case "2":
                    carCollection.CarList();
                    break;

                case "3":
                    Console.WriteLine("Thank you for checking our collection. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}