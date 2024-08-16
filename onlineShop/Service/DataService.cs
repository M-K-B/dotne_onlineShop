using Supabase;

namespace onlineShop.Service;

public class DataService : IDataService
{
    private readonly Client _supabaseClient;

    public DataService(Supabase.Client supabaseClient)
    {
        _supabaseClient = supabaseClient;
    }

    public async Task Logout()
    {
        try
        {
            await _supabaseClient.Auth.SignOut();
        }
        catch (Exception e)
        {
            
        }
    }
}

