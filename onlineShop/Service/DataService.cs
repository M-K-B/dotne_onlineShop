using Supabase;

namespace onlineShop.Service;

public class DataService : IDataService
{
    private readonly Client _supabaseClient;

    public DataService(Supabase.Client supabaseClient)
    {
        _supabaseClient = supabaseClient;
    }

    

    public Task newOrder()
    {
        throw new NotImplementedException();
    }
}

