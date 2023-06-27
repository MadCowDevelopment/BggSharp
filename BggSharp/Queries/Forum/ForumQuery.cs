namespace BggSharp.Queries.Forum;

public class ForumQuery : BggQuery<ForumItems, ForumQueryParameters>
{
    public ForumQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "forum";
}