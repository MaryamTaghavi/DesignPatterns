/*
یک سیستم قدیمی داریم که دما را بر حسب فارنهایت محاسبه میکند
الان نیاز به محاسبه سانتی گراد داریم به نحوی که توی سیستم در جاهایی
که فارنهایت استفاده شده است بهم نریزد
یک پل رابط میزنیم بین درجه حرارت قدیمی و جدید
 */

using _03_00_AdapterPattern;

OldWeatherService oldService = new OldWeatherService();
INewWeatherService newService = new WeatherServiceAdapter(oldService);

Console.WriteLine($"Temp in Celsius: {newService.GetTemperatureCelsius()}°C");