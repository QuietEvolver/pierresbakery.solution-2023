using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Pierre's Bakery app!");
      Console.WriteLine("Pierre offers the following deal for Bread: Buy 2, get 1 free. A single loaf costs $5, then:");
      Console.WriteLine("two/three loaves costs $10");
      Console.WriteLine("four loaves costs $15");
      Console.WriteLine("five/six loaves cost $20");
      Console.WriteLine("seven loaves cost $25");
      Console.WriteLine("Can you see a pattern? Every 3rd loaf of bread is free.");

      Console.WriteLine("Pierre offers the following deal for Pastry: Buy 3, get 1 free. A single pastry costs $2, then:");
      Console.WriteLine("two pastries costs $4");
      Console.WriteLine("three pastries costs $6");
      Console.WriteLine("four pastries costs $6");
      Console.WriteLine("five pastries costs $8");
      Console.WriteLine("six pastries costs $10");
      Console.WriteLine("seven pastries costs $12");
      Console.WriteLine("eight pastries costs $12");
      Console.WriteLine("Can you see a pattern? Every 4th pastry is free.");

      Console.WriteLine("Please enter the number of loaves:");
      string userBreadInput = Console.ReadLine();  

      Console.WriteLine("Please enter the number of pastries:");
      string userPastryInput = Console.ReadLine();  
 
      Console.WriteLine("Requested: Breads = " + userBreadInput);
      Console.WriteLine("Requested: Pastries = " + userPastryInput);
 
      int breadNumber = Convert.ToInt32(userBreadInput);  
      int pastryNumber = Convert.ToInt32(userPastryInput);  

      Bread newBread = new Bread(breadNumber);
      Pastry newPastry = new Pastry(pastryNumber);
      
      int total = newBread.TotalBreadPrice3for2() + newPastry.TotalPastryPrice4for3();  
      Console.WriteLine("Total Bread: " +  newBread.TotalBreadPrice3for2()); 
      Console.WriteLine("Total Pastry: " +  newPastry.TotalPastryPrice4for3()); 
      Console.WriteLine("Total Cost: " + total); 
    }
  }
}