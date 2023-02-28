using System; // for IDisposable
using System.Collections.Generic; // Linq List
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{  
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void GetEmptyNumberOfLoaves_SetNumberOfEmptyLoaves_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    
    [TestMethod]
    public void GetNumberOfPastries_SetNumberOfPastries_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    
    [TestMethod]
    public void GetPastryPrice_SetCorrectPastryPrice_Int()
    {
      int userPastryInput = 3; 
      Pastry newPastry = new Pastry(userPastryInput);
      Assert.AreEqual(6, newPastry.TotalPastryPrice4for3());
    } 

    [TestMethod]
    public void GetPastryBogo_SetCorrectPastryBogo_Int()
    {
      int userPastryInput = 3; 
      Pastry newPastry = new Pastry(userPastryInput);
      Assert.AreEqual(1, newPastry.Bogo4for3());
    }
  }
  // [TestClass]
  // public class PastryTests : IDisposable
  // { 
  //   // special method that will run between tests to perform cleanup: _instances through ClearAll(). Dispose()
  // public void Dispose()
  // {
  //   Pastry.ClearAll(); // defined at end
  // }
  //   [TestMethod]
  //   public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
  //   {
  //     Pastry newPastry = new Pastry(2, 3, 5, "isosceles"); // passes a length param property value
  //     Assert.AreEqual(typeof(Pastry), newPastry.GetType());
  //   }

  //   [TestMethod]
  //   public void GetSide1_ReturnsSide1_Int()
  //   {
  //     // Arrange
  //     int length1 = 3;
  //     Pastry newPastry = new Pastry(length1, 2, 8, "isosceles");
  //     // Act (by calling a method or retreiving a property) ie. Side1
  //     int result = newPastry.Side1;
  //     // Assert
  //     Assert.AreEqual(length1, result);
  //   }

  //   [TestMethod]
  //   public void SetSide1_SetsValueOfSide1_Void()
  //   {
  //     // Arrange
  //     Pastry newPastry = new Pastry(3, 3, 8, "isosceles");
  //     int newLength1 = 44;
  //     // Act
  //     newPastry.Side1 = newLength1;
  //     // Assert
  //     Assert.AreEqual(newLength1, newPastry.Side1);
  //   }

  //   // Side 2: testing for auto-implemented properties
  //   [TestMethod]
  //   public void GetSide2_ReturnsSide2_Int()
  //   {
  //     // Arrange
  //     int length2 = 3;
  //     Pastry newPastry = new Pastry(2, length2, 8, "isosceles");
  //     // Act
  //     int result = newPastry.Side2;
  //     // Assert
  //     Assert.AreEqual(length2, result);
  //   }

  //   [TestMethod]
  //   public void SetSide2_SetsValueOfSide2_Void()
  //   {
  //     // Arrange
  //     Pastry newPastry = new Pastry(3, 4, 8, "isosceles");
  //     int newLength2 = 6;
  //     // Act
  //     newPastry.Side2 = newLength2;
  //     // Assert
  //     Assert.AreEqual(newLength2, newPastry.Side2);
  //   }

  //   // Side 3: Accessing & Testing A Private Field through its Getter and Setter Methods

  //   [TestMethod]
  //   public void GetSide3_ReturnsSide3_Int()
  //   {
  //     // Arrange
  //     int length3 = 55;
  //     Pastry newPastry = new Pastry(2, 3, length3, "isosceles");
  //     // Act
  //     int result = newPastry.GetSide3();
  //     // Assert
  //     Assert.AreEqual(length3, result);
  //   }

  //   [TestMethod]
  //   public void SetSide3_SetsValueOfSide3_Void()
  //   {
  //     // Arrange
  //     Pastry newPastry = new Pastry(3, 4, 8, "isosceles");
  //     int newLength3 = 6;
  //     // Act
  //     newPastry.SetSide3(newLength3);
  //     // Assert
  //     Assert.AreEqual(newLength3, newPastry.GetSide3());
  //   }

  //   // Testing CheckType() method
  //   [TestMethod]
  //   public void CheckType_DeterminesWhenNotAPastry_String()
  //   {
  //     // Arrange
  //     Pastry notAPastry = new Pastry(3, 4, 88, "isosceles");
  //     // Act
  //     string triType = notAPastry.CheckType();
  //     // Assert
  //     Assert.AreEqual("not a Pastry", triType);
  //   }
  //   // scalene
  //   [TestMethod]
  //   public void CheckType_DeterminesWhenScalene_String()
  //   {
  //     // Arrange
  //     Pastry scaleneTri = new Pastry(3, 4, 5, "isosceles");
  //     // Act
  //     string triType = scaleneTri.CheckType();
  //     // Assert
  //     Assert.AreEqual("scalene Pastry", triType);
  //   }    
  //   // isosceles
  //   [TestMethod]
  //   public void CheckType_DeterminesWhenIsosceles_String()
  //   {
  //     // Arrange
  //     Pastry isoscelesTri = new Pastry(5, 4, 4, "isosceles");
  //     // Act
  //     string triType = isoscelesTri.CheckType();
  //     // Assert
  //     Assert.AreEqual("isosceles Pastry", triType);
  //   }

  //   [TestMethod]
  //   public void CheckType_DeterminesWhenEquilateral_String()
  //   {
  //     // Arrange
  //     Pastry equiTri = new Pastry(4, 4, 4, "isosceles");
  //     // Act
  //     string triType = equiTri.CheckType();
  //     // Assert
  //     Assert.AreEqual("equilateral Pastry", triType);
  //   }

  //   // GetAll() method testing
  //   [TestMethod]
  //   public void GetAll_ReturnsAllPastryInstances_List()
  //   {
  //     // Arrange
  //     Pastry tri1 = new Pastry(2, 2, 9, "isosceles");
  //     Pastry tri2 = new Pastry(21, 3, 9, "isosceles");
  //     Pastry tri3 = new Pastry(1, 3, 9, "isosceles");
  //     List<Pastry> expected = new List<Pastry> { tri1, tri2, tri3 };
  //     // Act
  //     List<Pastry> actualResult = Pastry.GetAll();
  //     // Assert
  //     CollectionAssert.AreEqual(expected, actualResult);
  //   }

  //     [TestMethod]
  //   public void ClearAll_DeletesAllPastryInList_Void()
  //   {
  //     // Arrange
  //     Pastry tri1 = new Pastry(2, 2, 9, "isosceles");
  //     Pastry tri2 = new Pastry(21, 3, 9, "isosceles");
  //     Pastry tri3 = new Pastry(1, 3, 9, "isosceles");
  //     List<Pastry> expected = new List<Pastry> { };
  //     // Act
  //     Pastry.ClearAll();
  //     // Assert
  //     CollectionAssert.AreEqual(expected, Pastry.GetAll());
  //   }
  // }
}