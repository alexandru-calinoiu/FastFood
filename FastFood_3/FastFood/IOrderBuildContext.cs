using FastFood.Burger;
using FastFood.Drink;
using FastFood.Fries;
using FastFood.Toy;

namespace FastFood
{
    public interface IOrderBuildContext
    {
        IOrderBuildContext WithBurger(BurgerBase burger);

        IOrderBuildContext WithDrink(DrinkBase drink);

        IOrderBuildContext WithFries(FriesBase fries);

        IOrderBuildContext WithToy(ToyBase toy);

        Order Serve();
    }
}