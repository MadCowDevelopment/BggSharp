using System.Xml.Serialization;

namespace BggSharp;

public class DefaultBggClient : IBggClient
{
    private readonly HttpClient _httpClient;

    public DefaultBggClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T?> ReadFromBggAsync<T>(string uri) where T : class
    {
        var response = await _httpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        var serialObject = new XmlSerializer(typeof(T));
        using var reader = await response.Content.ReadAsStreamAsync();
        var result = serialObject.Deserialize(reader) as T;
        return result;
    }
}