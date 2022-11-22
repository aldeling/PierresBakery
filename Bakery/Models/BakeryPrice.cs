using BakeryPage;

namespace BakeryPrice.Models
{
  public class Bread
  {
    public int DiscountedBread(int amount)
    {
      return amount / 3;
    }

    public int PricedBread(int amount)
    {
      int extraLoafs = DiscountedBread(amount);
      return amount - extraLoafs;
    }

    public int TotalBreadPrice(int amount)
    {
      int payableLoafs = PricedBread(amount);
      return payableLoafs * 5;
    }
  }

  public class Pastry
  {
    public int DiscountedPastry(int amount)
    {
      return amount / 3;
    }

    public int TotalPastry(int amount)
    {
      int extraPastries = DiscountedPastry(amount);
      return amount - extraPastries;
    }

    public int FullPriced(int amount)
    {
      int totalPastry = TotalPastry(amount);
      return totalPastry * 2;
    }

    public int DiscountedPrice(int amount)
    {
      int extraPastries = DiscountedPastry(amount);
      return extraPastries * 1;
    }

    public int TotalPrice(int amount)
    {
      int fullPrice = FullPriced(amount);
      int discountedPrice = DiscountedPrice(amount);
      return fullPrice + discountedPrice;
    }
  }
}