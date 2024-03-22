class PizzaFactory{
    private Pizza pizza = null;
    public Pizza createPizza(string type) {
        if (type == "Special") {
            pizza = new SpecialPizza();
        } else if (type == "ChickenTika") {
            pizza = new ChickenTika();
        }
        return pizza;
    }

}