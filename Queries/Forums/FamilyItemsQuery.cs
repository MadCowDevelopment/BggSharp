namespace BggSharp.Queries.Families;

public class FamilyItemsQuery : BggQuery<FamiliyItems, FamilyItemsQueryParameters>
{
    public FamilyItemsQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "family";
}