namespace _03_03_PizzaBuilder;

public interface IPizza
{
    IPizza CreateSauce();
    IPizza CreateTopping();
    IPizza CreateSize();
    Pizza CreatePizza();
}
