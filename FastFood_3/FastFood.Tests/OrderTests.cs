using FastFood.Burger;
using FastFood.Drink;
using FluentAssertions;
using Xunit;

namespace FastFood.Tests
{
    public class OrderTests
    {
        [Fact] 
        public void ShouldBeAbleToServerAOrder()
        {
            var order = Order.BeginOrder().WithBurger(new Chicken()).WithDrink(new Cola()).Serve();

            order.Burger.Should().BeOfType<Chicken>();
            order.Drink.Should().BeOfType<Cola>();
        }
    }
}