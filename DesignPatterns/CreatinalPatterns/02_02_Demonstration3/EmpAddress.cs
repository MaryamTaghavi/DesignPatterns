namespace _02_02_Demonstration3;

public class EmpAddress
{
    public string Address { get; set; }
    public EmpAddress(string address)
    {
        this.Address = address;
    }
    public override string ToString()
    {
        return this.Address;
    }
    public object CloneAddress()
    {
        // Shallow Copy
        return this.MemberwiseClone();
    }
}