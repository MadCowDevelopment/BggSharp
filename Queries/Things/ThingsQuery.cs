namespace BggSharp.Queries.Things;
public class ThingsQuery : BggQuery<ThingItems, ThingsQueryParameters>
{
    public ThingsQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "thing";
}