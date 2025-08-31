/*

این سناریو برای تراکنش های بانکی بسیار مناسب است
مثلا سرویس بانکی دارای عملیات محاسبه موجودی، کسر از حساب، اضافه به حساب و ... است
وقتی ما یک پروکسی که مثلا چک حق دسترسی در آن است را اضافه میکنیم
در نتیجه اگر کاربری مجاز نباشد از همان جا ریکوئست برگشت میخورد
در نتیجه بار اضافی از روی سرویس اصلی کم شده و بخشی از آن به پروکسی منتقل میشود.

 */

using _01_00_ProxyPattern;

IPaymentProcessor authorizedUser = new PaymentProcessorProxy(true);
authorizedUser.ProcessPayment(100);

Console.WriteLine();

// کاربر غیرمجاز
IPaymentProcessor unauthorizedUser = new PaymentProcessorProxy(false);
unauthorizedUser.ProcessPayment(50);