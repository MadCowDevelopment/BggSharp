namespace BggSharp;

public interface IBggClient
{
    Task<T?> ReadFromBggAsync<T>(string uri) where T : class;
}