using System.Collections;
using System.Text;

namespace BggSharp.Queries;

public abstract class BggQuery<TItem, TParameters> where TItem : class
{
    private readonly IBggClient _bggClient;

    protected BggQuery(IBggClient bggClient)
    {
        _bggClient = bggClient;
    }

    public Task<TItem?> Query(TParameters parameters)
    {
        var builder = new StringBuilder();
        builder.Append($"{BaseUrl}");

        bool firstNotNullProperty = true;
        foreach(var property in typeof(TParameters).GetProperties())
        {
            var value = property.GetValue(parameters);
            if(value == null) continue;

            builder.Append(firstNotNullProperty ? "?" : "&");
            firstNotNullProperty = false;

            builder.Append($"{property.Name.ToLower()}=");
            if (value is IEnumerable enumerable and not string) builder.Append(string.Join(",", enumerable.Cast<object>()));
            else if (value is bool boolValue) builder.Append(boolValue ? "1" : "0");
            else builder.Append(value.ToString());
        }

        return _bggClient.ReadFromBggAsync<TItem>(builder.ToString());
    }

    protected string BaseUrl => $"https://boardgamegeek.com/xmlapi2/{BggCommandIdentifier}";
    protected abstract string BggCommandIdentifier { get; }
}