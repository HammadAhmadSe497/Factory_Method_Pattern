public class Pizza {
    protected string name ;
    protected string dough ;
    protected string sauce ;
    protected List<string> toppings = new List<string>();
    public void prepare() {
        Console.WriteLine("Preparing " + name);
        Console.WriteLine("Tossing dough : " + dough);
        Console.WriteLine("Adding sauce : " + sauce);
        Console.WriteLine("Adding toppings ");
        Console.WriteLine("###################");
        foreach (string topping in toppings) {
            Console.WriteLine("@{0}" , topping);
        }
    }
    public void bake() {
        Console.WriteLine("Bake for 25 minutes at 350 : \n " + name);
    }
    public void cut() {
        Console.WriteLine("Cutting the pizza into diagonal slices : \n"+ name);
    }
    public void box() {
        Console.WriteLine("Dear Customer your pizza is ready:  \n  "+ name);
    }
}