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

    public int TotalPastryPrice4for3() 
    {
      return (PastryNumber * 2) - Bogo4for3(); // (PastryNumber * price) - (price * (n/#disc))
    }

    public int Bogo4for3()
    {
      (2 * PastryNumber/4); 
    }
    // public string CheckType()
    // {
    //   if ((Side1 > (Side2 + _side3)) || (Side2 > (Side1 + _side3)) || (_side3 > (Side1 + Side2))) 
    //   {
    //     return "not a triangle";
    //   } 
    //   else if ((Side1 != Side2) && ((Side1 != _side3)) && ((Side2 != _side3))) 
    //   {
    //     return "scalene triangle";
    //   }
    //   else if ((Side1 == Side2) && (Side1 == _side3)) 
    //   {
    //     return "equilateral triangle";
    //   } 
    //   else
    //   {
    //     return "isosceles triangle";
    //   }
    // }
  }
}