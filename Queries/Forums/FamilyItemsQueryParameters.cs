using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Families;

public record FamilyItemsQueryParameters(
    [Required] IEnumerable<int> Id,
    IEnumerable<FamilyType>? Type = null);
