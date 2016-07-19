using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercise_3c
{
    
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("What is the name of the Product?");
                string productName = Console.ReadLine();
                Console.WriteLine("What is the price per unit?");
                double pricePerUnit = double.Parse(Console.ReadLine());
                Console.WriteLine("How many have you bought?");
                double quantityBought = double.Parse(Console.ReadLine());
                Console.WriteLine("Is it a food Item <y/n>?");
                string foodItem = Console.ReadLine();
                double sumWithVAT = pricePerUnit * quantityBought;
                double taxItem = sumWithVAT * 0.2;
                double taxFood = sumWithVAT * 0.1;
                double sumNoVATitem = pricePerUnit * quantityBought - taxItem;
                double sumNoVAT = pricePerUnit * quantityBought - taxFood;
                Console.WriteLine("---RECEIPT---");
                Console.WriteLine("Product: " + productName);
                Console.WriteLine("Total Amount to pay, including tax; " + sumWithVAT);
                if(foodItem == "n")
                {
                    Console.WriteLine("Total Amount to pay, excluding tax: " + (sumWithVAT - taxItem) + "\nOf which is tax: " + taxItem);
                }
                else
                {
                    Console.WriteLine("Total Amount to pay, excluding tax: " + (sumWithVAT - taxFood) + "\nOf which is tax: " + taxFood);
                }
                Console.ReadLine();
            }
        }
    }
}