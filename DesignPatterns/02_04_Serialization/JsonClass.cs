using System.Text.Json;

namespace _02_04_Serialization;

public static class JsonClass
{
    public static (T,T) DeepCopy<T>(this T t)
    {
        var json = JsonSerializer.Serialize(t);
        return (t , JsonSerializer.Deserialize<T>(json));
    }
}
