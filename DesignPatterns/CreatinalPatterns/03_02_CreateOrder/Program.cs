/*
فرض کن می‌خوای یه سیستم Order بسازی که شامل چند آیتم، تخفیف، آدرس ارسال و اطلاعات پرداخته.
چطور با Builder Pattern می‌تونی این Order رو مرحله به مرحله بسازی بدون اینکه Constructor بزرگ و پیچیده بسازی؟
*/

/*
پترن بیلدر هم میتواند با دایرکتور که مراحل ساخت را مشخص کند ساخته میشود
هم بدون آن و مستقیم توسط کلاینت.
 */

using _03_02_CreateOrder;

var director = new OrderDirector(new FirstOrder());
Order order = director.Build();

Console.ReadLine();