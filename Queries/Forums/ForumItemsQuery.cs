namespace BggSharp.Queries.Forums;

public class ForumItemsQuery : BggQuery<ForumItems, ForumItemsQueryParameters>
{
    public ForumItemsQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "forum";
}