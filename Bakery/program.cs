using System;
using System.Collections.Generic;
using BakeryPrice.Models;

namespace BakeryPage
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("----------------------");
      Console.WriteLine("Bread Cost: $5 a loaf");
      Console.WriteLine("Pastries Cost: $2 a pastry");
      Console.WriteLine("----------------------");
      Console.WriteLine("Bread Deal: Buy 2, get 1 Free");
      Console.WriteLine("Pastry Deal: Buy 1 for $2 or 3 for $5");
      Console.WriteLine("----------------------");
      Console.WriteLine("Amount of Bread: ");
      string breadAmount = Console.ReadLine();
      Console.WriteLine("Amount of Pastries: ");
      string pastryAmount = Console.ReadLine();

      int breadNumber = int.Parse(breadAmount);
    }
  }
}