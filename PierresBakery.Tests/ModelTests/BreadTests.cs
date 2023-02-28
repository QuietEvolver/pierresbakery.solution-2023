using System; // for IDisposable
using System.Collections.Generic; 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{  
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void GetEmptyNumberOfLoaves_SetNumberOfEmptyLoaves_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  
    [TestMethod]
    public void GetNumberOfLoaves_SetNumberOfLoaves_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBread_SetBreadQtyFromUserBreadInput_Int()
    {
      int userBreadInput = 2; 
      Bread newBread = new Bread(userBreadInput);
      Assert.AreEqual(2, newBread.BreadNumber);
    }

    [TestMethod]
    public void GetBreadPrice_SetCorrectBreadPrice_Int()
    {
      int userBreadInput = 2; 
      Bread newBread = new Bread(userBreadInput);
      Assert.AreEqual(10, newBread.TotalBreadPrice());
    }

    [TestMethod]
    public void GetBreadBogo_SetCorrectBreadBogo_Int()
    {
      int userBreadInput = 2; 
      Bread newBread = new Bread(userBreadInput);
      Assert.AreEqual(3, newBread.Bogo3for2());
    }

    [TestMethod]
    public void GetBreadTotalBogo_SetCorrectBreadTotalBogo_Int()
    {
      int userBreadInput = 2; 
      Bread newBread = new Bread(userBreadInput);
      Assert.AreEqual(10, newBread.TotalBreadPrice3for2());
    }
  }

  // public class BreadTests : IDisposable
  // { 
  //   // special method that will run between tests to perform cleanup: _instances through ClearAll(). Dispose()
  // public void Dispose()
  // {
  //   Bread.ClearAll(); // defined at end
  // }
  //   [TestMethod]
  //   public void BreadConstructor_CreatesInstanceOfBread_Bread()
  //   {
  //     Bread newBread = new Bread(2, 3, 5, "isosceles"); // passes a length param property value
  //     Assert.AreEqual(typeof(Bread), newBread.GetType());
  //   }

  //   [TestMethod]
  //   public void GetSide1_ReturnsSide1_Int()
  //   {
  //     // Arrange
  //     int length1 = 3;
  //     Bread newBread = new Bread(length1, 2, 8, "isosceles");
  //     // Act (by calling a method or retreiving a property) ie. Side1
  //     int result = newBread.Side1;
  //     // Assert
  //     Assert.AreEqual(length1, result);
  //   }

  //   [TestMethod]
  //   public void SetSide1_SetsValueOfSide1_Void()
  //   {
  //     // Arrange
  //     Bread newBread = new Bread(3, 3, 8, "isosceles");
  //     int newLength1 = 44;
  //     // Act
  //     newBread.Side1 = newLength1;
  //     // Assert
  //     Assert.AreEqual(newLength1, newBread.Side1);
  //   }

  //   // Side 2: testing for auto-implemented properties
  //   [TestMethod]
  //   public void GetSide2_ReturnsSide2_Int()
  //   {
  //     // Arrange
  //     int length2 = 3;
  //     Bread newBread = new Bread(2, length2, 8, "isosceles");
  //     // Act
  //     int result = newBread.Side2;
  //     // Assert
  //     Assert.AreEqual(length2, result);
  //   }

  //   [TestMethod]
  //   public void SetSide2_SetsValueOfSide2_Void()
  //   {
  //     // Arrange
  //     Bread newBread = new Bread(3, 4, 8, "isosceles");
  //     int newLength2 = 6;
  //     // Act
  //     newBread.Side2 = newLength2;
  //     // Assert
  //     Assert.AreEqual(newLength2, newBread.Side2);
  //   }

  //   // Side 3: Accessing & Testing A Private Field through its Getter and Setter Methods

  //   [TestMethod]
  //   public void GetSide3_ReturnsSide3_Int()
  //   {
  //     // Arrange
  //     int length3 = 55;
  //     Bread newBread = new Bread(2, 3, length3, "isosceles");
  //     // Act
  //     int result = newBread.GetSide3();
  //     // Assert
  //     Assert.AreEqual(length3, result);
  //   }

  //   [TestMethod]
  //   public void SetSide3_SetsValueOfSide3_Void()
  //   {
  //     // Arrange
  //     Bread newBread = new Bread(3, 4, 8, "isosceles");
  //     int newLength3 = 6;
  //     // Act
  //     newBread.SetSide3(newLength3);
  //     // Assert
  //     Assert.AreEqual(newLength3, newBread.GetSide3());
  //   }

  //   // Testing CheckType() method
  //   [TestMethod]
  //   public void CheckType_DeterminesWhenNotABread_String()
  //   {
  //     // Arrange
  //     Bread notABread = new Bread(3, 4, 88, "isosceles");
  //     // Act
  //     string triType = notABread.CheckType();
  //     // Assert
  //     Assert.AreEqual("not a Bread", triType);
  //   }
  //   // scalene
  //   [TestMethod]
  //   public void CheckType_DeterminesWhenScalene_String()
  //   {
  //     // Arrange
  //     Bread scaleneTri = new Bread(3, 4, 5, "isosceles");
  //     // Act
  //     string triType = scaleneTri.CheckType();
  //     // Assert
  //     Assert.AreEqual("scalene Bread", triType);
  //   }    
  //   // isosceles
  //   [TestMethod]
  //   public void CheckType_DeterminesWhenIsosceles_String()
  //   {
  //     // Arrange
  //     Bread isoscelesTri = new Bread(5, 4, 4, "isosceles");
  //     // Act
  //     string triType = isoscelesTri.CheckType();
  //     // Assert
  //     Assert.AreEqual("isosceles Bread", triType);
  //   }

  //   [TestMethod]
  //   public void CheckType_DeterminesWhenEquilateral_String()
  //   {
  //     // Arrange
  //     Bread equiTri = new Bread(4, 4, 4, "isosceles");
  //     // Act
  //     string triType = equiTri.CheckType();
  //     // Assert
  //     Assert.AreEqual("equilateral Bread", triType);
  //   }

  //   // GetAll() method testing
  //   [TestMethod]
  //   public void GetAll_ReturnsAllBreadInstances_List()
  //   {
  //     // Arrange
  //     Bread tri1 = new Bread(2, 2, 9, "isosceles");
  //     Bread tri2 = new Bread(21, 3, 9, "isosceles");
  //     Bread tri3 = new Bread(1, 3, 9, "isosceles");
  //     List<Bread> expected = new List<Bread> { tri1, tri2, tri3 };
  //     // Act
  //     List<Bread> actualResult = Bread.GetAll();
  //     // Assert
  //     CollectionAssert.AreEqual(expected, actualResult);
  //   }

  //     [TestMethod]
  //   public void ClearAll_DeletesAllBreadInList_Void()
  //   {
  //     // Arrange
  //     Bread tri1 = new Bread(2, 2, 9, "isosceles");
  //     Bread tri2 = new Bread(21, 3, 9, "isosceles");
  //     Bread tri3 = new Bread(1, 3, 9, "isosceles");
  //     List<Bread> expected = new List<Bread> { };
  //     // Act
  //     Bread.ClearAll();
  //     // Assert
  //     CollectionAssert.AreEqual(expected, Bread.GetAll());
  //   }
  // }
}