namespace _03_03_PizzaBuilder;

public class PizzaDirector
{
    private readonly IPizza _builder;

    public PizzaDirector(IPizza builder) => _builder = builder;

    public Pizza Build()
    {
        return _builder
            .CreateSauce()
            .CreateSize()
            .CreateTopping()
            .CreatePizza();
    }
}
