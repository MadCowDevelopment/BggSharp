namespace BggSharp.Queries.Guild;

public class GuildQuery : BggQuery<Guild, GuildQueryParameters>
{
    public GuildQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "guild";
}