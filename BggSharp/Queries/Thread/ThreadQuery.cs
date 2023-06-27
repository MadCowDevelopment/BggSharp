namespace BggSharp.Queries.Thread;

public class ThreadQuery : BggQuery<Thread, ThreadQueryParameters>
{
    public ThreadQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "thread";
}