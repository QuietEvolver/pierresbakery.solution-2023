using System.Collections.Generic;

namespace PierresBakery.Models
{
  
  public class Bread
  {
    public int BreadNumber { get; set; }

    public Bread()
    {
      BreadNumber = 0;
    }

    public Bread( int userBreadInput)
    {
      BreadNumber = userBreadInput;
    }

    // public int TotalBreadPrice3for2() 
    // {
    //   return (BreadNumber * 5) - Bogo3for2(); // (BreadNumber * price) - (price * (n/#disc))
    // }

    // public int Bogo3for2()
    // {
    //   return (5 * BreadNumber/3); 
    // }
  }  
}