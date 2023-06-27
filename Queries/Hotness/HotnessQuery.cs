namespace BggSharp.Queries.Hotness;

public class HotnessQuery : BggQuery<HotItems, HotnessQueryParameters>
{
    public HotnessQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "hot";
}