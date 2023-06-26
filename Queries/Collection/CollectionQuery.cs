namespace BggSharp.Queries.Forum;

public class CollectionQuery : BggQuery<Collection, CollectionQueryParameters>
{
    public CollectionQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "collection";
}