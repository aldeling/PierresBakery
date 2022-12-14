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
    public void DiscountedBread_DividesQuantityByThree_Remaining()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(1, newBread.DiscountedBread(3));
    }

    [TestMethod]
    public void TotalBreadPrice_PricedBreadTimesFive_Total()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(10, newBread.TotalBreadPrice(2));
    }

    [TestMethod]
    public void PricedBread_DiscountedBreadMinusAmount_QuantityCharged()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(2, newBread.PricedBread(3));
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

    [TestMethod]
    public void DiscountedPastry_QuantityDividedByThree_Extra()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(1, newPastry.DiscountedPastry(3));
    }

    [TestMethod]
    public void TotalPastry_DiscountedMinusTotal_FullPrice()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(3, newPastry.TotalPastry(4));
    }

    [TestMethod]
    public void FullPriced_TwoTimesTotalPastry_FullPrice()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(4, newPastry.FullPriced(2));
    }

    [TestMethod]
    public void DiscountedPrice_ExtraPastriesTimesOne_SalePrice()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(2, newPastry.DiscountedPrice(6));
    }

    [TestMethod]
    public void TotalPrice_FullPlusDiscountedPrice_FinalPrice()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(5, newPastry.TotalPrice(3));
    }
  }
}