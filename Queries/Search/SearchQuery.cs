namespace BggSharp.Queries.Search;

public class SearchQuery : BggQuery<SearchItems, SearchQueryParameters>
{
    public SearchQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "search";
}