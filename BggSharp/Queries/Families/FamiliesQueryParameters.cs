using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Families;

public record FamiliesQueryParameters(
    [Required] IEnumerable<int> Id,
    IEnumerable<FamilyType>? Type = null);
