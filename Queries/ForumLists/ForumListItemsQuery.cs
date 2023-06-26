namespace BggSharp.Queries.ForumLists;

public class ForumListItemsQuery : BggQuery<ForumListItems, ForumListItemsQueryParameters>
{
    public ForumListItemsQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "forumlist";
}