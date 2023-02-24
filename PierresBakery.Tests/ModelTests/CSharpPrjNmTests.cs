using System; // for IDisposable
using System.Collections.Generic; // Linq List
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpPrjNm.Models;

namespace CSharpPrjNm.Tests
{
  // [TestClass]
  // public class TriangleTests : IDisposable
  // { 
  //   // special method that will run between tests to perform cleanup: _instances through ClearAll(). Dispose()
  // public void Dispose()
  // {
  //   Triangle.ClearAll(); // defined at end
  // }
  //   [TestMethod]
  //   public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
  //   {
  //     Triangle newTriangle = new Triangle(2, 3, 5, "isosceles"); // passes a length param property value
  //     Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
  //   }

  //   [TestMethod]
  //   public void GetSide1_ReturnsSide1_Int()
  //   {
  //     // Arrange
  //     int length1 = 3;
  //     Triangle newTriangle = new Triangle(length1, 2, 8, "isosceles");
  //     // Act (by calling a method or retreiving a property) ie. Side1
  //     int result = newTriangle.Side1;
  //     // Assert
  //     Assert.AreEqual(length1, result);
  //   }

  //   [TestMethod]
  //   public void SetSide1_SetsValueOfSide1_Void()
  //   {
  //     // Arrange
  //     Triangle newTriangle = new Triangle(3, 3, 8, "isosceles");
  //     int newLength1 = 44;
  //     // Act
  //     newTriangle.Side1 = newLength1;
  //     // Assert
  //     Assert.AreEqual(newLength1, newTriangle.Side1);
  //   }

  //   // Side 2: testing for auto-implemented properties
  //   [TestMethod]
  //   public void GetSide2_ReturnsSide2_Int()
  //   {
  //     // Arrange
  //     int length2 = 3;
  //     Triangle newTriangle = new Triangle(2, length2, 8, "isosceles");
  //     // Act
  //     int result = newTriangle.Side2;
  //     // Assert
  //     Assert.AreEqual(length2, result);
  //   }

  //   [TestMethod]
  //   public void SetSide2_SetsValueOfSide2_Void()
  //   {
  //     // Arrange
  //     Triangle newTriangle = new Triangle(3, 4, 8, "isosceles");
  //     int newLength2 = 6;
  //     // Act
  //     newTriangle.Side2 = newLength2;
  //     // Assert
  //     Assert.AreEqual(newLength2, newTriangle.Side2);
  //   }

  //   // Side 3: Accessing & Testing A Private Field through its Getter and Setter Methods

  //   [TestMethod]
  //   public void GetSide3_ReturnsSide3_Int()
  //   {
  //     // Arrange
  //     int length3 = 55;
  //     Triangle newTriangle = new Triangle(2, 3, length3, "isosceles");
  //     // Act
  //     int result = newTriangle.GetSide3();
  //     // Assert
  //     Assert.AreEqual(length3, result);
  //   }

  //   [TestMethod]
  //   public void SetSide3_SetsValueOfSide3_Void()
  //   {
  //     // Arrange
  //     Triangle newTriangle = new Triangle(3, 4, 8, "isosceles");
  //     int newLength3 = 6;
  //     // Act
  //     newTriangle.SetSide3(newLength3);
  //     // Assert
  //     Assert.AreEqual(newLength3, newTriangle.GetSide3());
  //   }

  //   // Testing CheckType() method
  //   [TestMethod]
  //   public void CheckType_DeterminesWhenNotATriangle_String()
  //   {
  //     // Arrange
  //     Triangle notATriangle = new Triangle(3, 4, 88, "isosceles");
  //     // Act
  //     string triType = notATriangle.CheckType();
  //     // Assert
  //     Assert.AreEqual("not a triangle", triType);
  //   }
  //   // scalene
  //   [TestMethod]
  //   public void CheckType_DeterminesWhenScalene_String()
  //   {
  //     // Arrange
  //     Triangle scaleneTri = new Triangle(3, 4, 5, "isosceles");
  //     // Act
  //     string triType = scaleneTri.CheckType();
  //     // Assert
  //     Assert.AreEqual("scalene triangle", triType);
  //   }    
  //   // isosceles
  //   [TestMethod]
  //   public void CheckType_DeterminesWhenIsosceles_String()
  //   {
  //     // Arrange
  //     Triangle isoscelesTri = new Triangle(5, 4, 4, "isosceles");
  //     // Act
  //     string triType = isoscelesTri.CheckType();
  //     // Assert
  //     Assert.AreEqual("isosceles triangle", triType);
  //   }

  //   [TestMethod]
  //   public void CheckType_DeterminesWhenEquilateral_String()
  //   {
  //     // Arrange
  //     Triangle equiTri = new Triangle(4, 4, 4, "isosceles");
  //     // Act
  //     string triType = equiTri.CheckType();
  //     // Assert
  //     Assert.AreEqual("equilateral triangle", triType);
  //   }

  //   // GetAll() method testing
  //   [TestMethod]
  //   public void GetAll_ReturnsAllTriangleInstances_List()
  //   {
  //     // Arrange
  //     Triangle tri1 = new Triangle(2, 2, 9, "isosceles");
  //     Triangle tri2 = new Triangle(21, 3, 9, "isosceles");
  //     Triangle tri3 = new Triangle(1, 3, 9, "isosceles");
  //     List<Triangle> expected = new List<Triangle> { tri1, tri2, tri3 };
  //     // Act
  //     List<Triangle> actualResult = Triangle.GetAll();
  //     // Assert
  //     CollectionAssert.AreEqual(expected, actualResult);
  //   }

  //     [TestMethod]
  //   public void ClearAll_DeletesAllTriangleInList_Void()
  //   {
  //     // Arrange
  //     Triangle tri1 = new Triangle(2, 2, 9, "isosceles");
  //     Triangle tri2 = new Triangle(21, 3, 9, "isosceles");
  //     Triangle tri3 = new Triangle(1, 3, 9, "isosceles");
  //     List<Triangle> expected = new List<Triangle> { };
  //     // Act
  //     Triangle.ClearAll();
  //     // Assert
  //     CollectionAssert.AreEqual(expected, Triangle.GetAll());
  //   }
  // }
}