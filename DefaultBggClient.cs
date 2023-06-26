using System.Xml;
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

        var settings = new XmlReaderSettings
        {
            DtdProcessing = DtdProcessing.Parse
        };

        var serialObject = new XmlSerializer(typeof(T));
        using var stream = await response.Content.ReadAsStreamAsync();
        var result = serialObject.Deserialize(stream) as T;
        return result;
    }
}