namespace BggSharp.Queries.Families;

public class FamiliesQuery : BggQuery<FamilyItems, FamiliesQueryParameters>
{
    public FamiliesQuery(IBggClient bggClient) : base(bggClient)
    {
    }

    protected override string BggCommandIdentifier => "family";
}