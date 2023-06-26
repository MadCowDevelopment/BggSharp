namespace BggSharp.Queries.Things;
public class ThingItemsQuery : BggQuery<ThingItems, ThingItemsQueryParameters>
{
    public ThingItemsQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "thing";
}