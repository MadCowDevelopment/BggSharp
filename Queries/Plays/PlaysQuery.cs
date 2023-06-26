namespace BggSharp.Queries.Plays;

public class PlaysQuery : BggQuery<PlayItems, PlaysQueryParameters>
{
    public PlaysQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "plays";
}