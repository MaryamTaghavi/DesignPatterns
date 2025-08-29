using _03_03_PizzaBuilder;

var director = new PizzaDirector(new ItalianPizza());
Pizza pizza = director.Build();

Console.ReadLine();