// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
       PizzaFactory pizzaFactory = new PizzaFactory();
        PizzaStore pizzaStore = new PizzaStore(pizzaFactory);
        pizzaStore.orderPizza("Special");
        pizzaStore.orderPizza("ChickenTika");
 
    }
}
