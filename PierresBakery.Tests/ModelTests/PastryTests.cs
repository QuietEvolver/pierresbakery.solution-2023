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
    public void GetPastry_SetPastryQtyFromUserPastryInput_Int()
    {
      int userPastryInput = 3; 
      Pastry newPastry = new Pastry(userPastryInput);
      Assert.AreEqual(3, newPastry.PastryNumber);
    }

    
    [TestMethod]
    public void GetPastryPrice_SetCorrectPastryPrice_Int()
    {
      int userPastryInput = 3; 
      Pastry newPastry = new Pastry(userPastryInput);
      Assert.AreEqual(6, newPastry.TotalPastryPrice());
    } 

    [TestMethod]
    public void GetPastryBogo_SetCorrectPastryBogo_Int()
    {
      int userPastryInput = 3; 
      Pastry newPastry = new Pastry(userPastryInput);
      Assert.AreEqual(1, newPastry.Bogo4for3());
    }

    [TestMethod]
    public void GetPastryTotalBogo4for3_SetCorrectPastryTotalBogo4for3_Int()
    {
      int userPastryInput = 3; 
      Pastry newPastry = new Pastry(userPastryInput);
      Assert.AreEqual(6, newPastry.TotalPastryPrice4for3());
    }
  }
}