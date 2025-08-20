// توی این پترن هم میتوان از interface و هم از abstract استفاده کرد
// interface => وقتی به امضا فقط نیاز داریم بدون پیاده سازی متد
// abstract => وقتی به رفتار دیفالت متدها نیاز داریم

/* وقتی از این پترن استفاده میکنیم که نیاز به تولید یک آبجکت پیچیده داریم و
نمیخواهیم در کانستراکتور ورودی های زیادی بدهیم بنابراین با این پترن مرحله به مرحله 
آبجکت را میسازیم */

/* و همچنین نیاز به ساخت آبجکت immutable داریم 
 یعنی نمیخواهیم تغییر ناگهانی داشته باشد یک بار ایجاد میشود
و دیگر تغییر نمیکند
همچنین در این حالت thread-safe است
و نیاز به نگرانی بابت لاک ترد نداریم در ایجاد آبجکت
 */

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