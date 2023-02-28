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
    public void GetBreadTotalBogo3for2_SetCorrectBreadTotalBogo3for2_Int()
    {
      int userBreadInput = 2; 
      Bread newBread = new Bread(userBreadInput);
      Assert.AreEqual(10, newBread.TotalBreadPrice3for2());
    }
  }