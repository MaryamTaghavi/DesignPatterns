namespace _03_00_AdapterPattern;

public class WeatherServiceAdapter : INewWeatherService
{
    private readonly OldWeatherService _oldService;

    public WeatherServiceAdapter(OldWeatherService oldService)
    {
        _oldService = oldService;
    }

    public double GetTemperatureCelsius()
    {
        double f = _oldService.GetTemperatureFahrenheit();
        return (f - 32) * 5.0 / 9.0; // تبدیل فارنهایت به سانتی‌گراد
    }
}
