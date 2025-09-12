namespace SMSExample;

public class ProviderCollection
{
    List<Provider> providerList = new List<Provider>();

    public ProviderCollection()
    {
        providerList.Add(new Provider1("Irancell"));   
        providerList.Add(new Provider2("MyMCI"));
    }
}
