using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPrimer.DesignPatterns.GoF.Decorator
{
    internal static class DecoratorPrimer
    {
        public static void Do()
        {
            Beverage coffee = new Coffee();
            Beverage beer = new Beer();

            BeverageAddition coffeeWithSugar = new SugarAddition(coffee);
            BeverageAddition beerWithFish = new FishAddition(beer);

            Console.WriteLine(coffeeWithSugar.CalculateCost());
            Console.WriteLine(beerWithFish.CalculateCost());
        }
    }
}
