using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    
    public int PastryNumber { get; set; }

    public Pastry()
    {
      PastryNumber = 0;
    }

    public Pastry( int userPastryInput)
    {
      PastryNumber = userPastryInput;
    }

    public int TotalPastryPrice() 
    {
     return (PastryNumber * 2); 
    }

    public int Bogo4for3()
    {
     return (2 * PastryNumber/4); 
    }

    public int TotalPastryPrice4for3() 
    {
     // return (PastryNumber * 2); // - Bogo4for3(); // (PastryNumber * price) - (price * (n/#disc))
    }
  }
}