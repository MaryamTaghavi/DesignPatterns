// توی این پترن هم میتوان از interface و هم از abstract استفاده کرد
// interface => وقتی به امضا فقط نیاز داریم بدون پیاده سازی متد
// abstract => وقتی به رفتار دیفالت متدها نیاز داریم

using _03_BuilderPattern;

Console.WriteLine("***Builder Pattern Demo.***");
Director director = new Director();
IBuilder b1 = new Car("Ford");
IBuilder b2 = new Motorcycle("Honda");
// Making Car
director.Construct(b1);
Product p1 = b1.GetVehicle();

p1.Show();
// Making Motorcycle
director.Construct(b2);
Product p2 = b2.GetVehicle();
p2.Show();
Console.ReadLine();