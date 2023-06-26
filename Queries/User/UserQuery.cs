namespace BggSharp.Queries.User;

public class UserQuery : BggQuery<User, UserQueryParameters>
{
    public UserQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "user";
}