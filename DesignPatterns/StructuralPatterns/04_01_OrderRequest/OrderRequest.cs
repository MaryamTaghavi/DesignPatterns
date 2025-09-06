namespace _04_01_OrderRequest;

public class OrderRequest
{
    public string Name { get; } = "danny";
    public string CardNumber { get; } = "1234";
    public float Amount { get; } = 20.99f;
    public string Address { get; } = "123 springfield way, Texas";
    public string[] ItemIds { get; } = { "123" , "456" , "789"};
}
