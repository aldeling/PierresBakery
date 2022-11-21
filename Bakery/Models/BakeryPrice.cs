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
    
    }
  }
}