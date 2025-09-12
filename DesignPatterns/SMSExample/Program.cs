/*
  
 این تمرین به این صورت است که ما قرار است یک تعداد sms ارسال کنیم
 و میخواهیم درصد بندی کنیم مثلا از 10 تا 5 تا از آنها با پرووایدر 1
 و 5 تای بعدی با پرووایدر 2
 به نحوی که قابل بسط باشد

 */

var colorNames = new[] { "Red", "Blue", "Green" };

var hexCodes = new[] { "0123", "125" };

var colors = colorNames.Zip(hexCodes, (name, hex) => new
{
    ColorName = name,
    Hex = hex
}) ;

Console.WriteLine(colors);
Console.ReadLine();