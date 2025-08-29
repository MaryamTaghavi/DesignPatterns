namespace _03_03_PizzaBuilder;

public class ItalianPizza : IPizza
{
    Pizza pizza;
    ItalianPizza()
    {
        pizza = new Pizza();
    }
    public Pizza CreatePizza()
    {
        return pizza;
    }

    public IPizza CreateSauce()
    {
        pizza.Sauce = "سس فرانسوی";
        return this;
    }

    public IPizza CreateSize()
    {
        pizza.Size = "متوسط";
        return this;
    }

    public IPizza CreateTopping()
    {
        pizza.Topping = "روکش پر از سس";
        return this;
    }
}
