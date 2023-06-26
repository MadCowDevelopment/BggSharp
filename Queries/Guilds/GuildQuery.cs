namespace BggSharp.Queries.Guilds;

public class GuildQuery : BggQuery<Guild, GuildQueryParameters>
{
    public GuildQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "guild";
}