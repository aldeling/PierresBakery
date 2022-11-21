using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryPrice.Models;

namespace BakeryPrice.Tests
{

  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadPrice_DividesQuantityByThree_Remaining()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(1, newBread.BreadPrice(3));
    }
  }
  
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}