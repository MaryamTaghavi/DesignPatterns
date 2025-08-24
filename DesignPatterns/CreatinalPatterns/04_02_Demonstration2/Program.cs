/* این پترن به subclass ها اجازه میدهد که شی را انتخاب و ایجاد کنند
 فرض کنید کارخانه تولید animal داریم
یک شی به نام CatFactory و دیگری به نام TiggerFactory است.
 */

using _04_02_Demonstration2;
using _04_FactoryMethodPattern;


Console.WriteLine("***Factory Pattern Demo.***\n");

AnimalFactory factory = new ConcreteAnimalFactory();
// Creating a tiger using the Factory Method
IAnimal tiger = factory.CreateAnimal("tiger");
tiger.AboutMe();
// Creating a dog using the Factory Method
IAnimal dog = factory.CreateAnimal("dog");
dog.AboutMe();
Console.WriteLine();


/*
مراحل ساخت Factory Pattern :
1) همه محصولات باید از یک اینترفیس واحد ارث بری کنند که این اینترفیس باید متدهایی که هر محصول نیاز دارد را پیاده کند.
2) یک کلاس کلی factory ایجاد میکنیم که فقط امضای متدها را دارد (abstract) و پیاده سازی ندارد که خروجی اینترفیس مورد نظر است.
3) همه نیوها به داخل فکتوری ها منتقل میشوند به جای صدا زدن در creator اصلی
(به طور خلاصه برای هر محصول یک فکتوری مجزا میسازیم مثلا SamanFactory یا MellatFactory)
 */