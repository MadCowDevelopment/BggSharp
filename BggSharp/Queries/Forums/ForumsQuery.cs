namespace BggSharp.Queries.Forums;

public class ForumsQuery : BggQuery<ForumListItems, ForumsQueryParameters>
{
    public ForumsQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "forumlist";
}