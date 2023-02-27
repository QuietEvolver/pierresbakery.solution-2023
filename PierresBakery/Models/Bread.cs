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

    public int TotalBreadPrice3for2() 
    {
      return (BreadNumber * 5) - Bogo3for2(); // (BreadNumber * price) - (price * (n/#disc))
    }

    public int Bogo3for2()
    {
      (5 * BreadNumber/3); 
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