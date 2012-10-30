using FastFood.Burger;
using FastFood.Drink;
using FastFood.Fries;
using FastFood.Toy;

namespace FastFood
{
    public class Order : IOrderBuildContext
    {
        public BurgerBase Burger { get; private set; }

        public DrinkBase Drink { get; private set; }

        public FriesBase Fries { get; private set; }

        public ToyBase Toy { get; private set; }

        IOrderBuildContext IOrderBuildContext.WithBurger(BurgerBase burger)
        {
            Burger = burger;
            return this;
        }

        IOrderBuildContext IOrderBuildContext.WithDrink(DrinkBase drink)
        {
            Drink = drink;
            return this;
        }

        IOrderBuildContext IOrderBuildContext.WithFries(FriesBase fries)
        {
            Fries = fries;
            return this;
        }

        IOrderBuildContext IOrderBuildContext.WithToy(ToyBase toy)
        {
            Toy = toy;
            return this;
        }

        Order IOrderBuildContext.Serve()
        {
            return this;
        }

        private Order()
        {
        }

        public static IOrderBuildContext BeginOrder()
        {
            return new Order();
        }
    }
}