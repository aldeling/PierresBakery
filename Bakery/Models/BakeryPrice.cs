namespace BakeryPrice.Models
{
  public class Bread
  {
    public int BreadPrice(int amount)
    {
      return amount / 3;
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