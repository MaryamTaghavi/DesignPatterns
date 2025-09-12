namespace SMSExample;

public class SMSDispatcher
{
    public Dictionary<Provider, int> providerDic = new Dictionary<Provider, int>();

    public SMSDispatcher(Provider provider) 
    { }
    List<int> numbers = new List<int>();

    Provider1 p1 = new Provider1("Provider1");
    Provider1 p2 = new Provider1("Provider2");

  //  AddProvider(providerDic , null);
    //providerDic[p1] = 10 ;
    //providerDic[p2] = 20;
}

