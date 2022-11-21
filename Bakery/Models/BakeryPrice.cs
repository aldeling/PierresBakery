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

    public int InitialBreadPrice(int amount)
    {
      return amount * 5;
    }
  }

  public class Pastry
  {

  }
}