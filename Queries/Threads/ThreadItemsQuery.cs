namespace BggSharp.Queries.Threads;

public class ThreadItemsQuery : BggQuery<ThreadItems, ThreadItemsQueryParameters>
{
    public ThreadItemsQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "thread";
}