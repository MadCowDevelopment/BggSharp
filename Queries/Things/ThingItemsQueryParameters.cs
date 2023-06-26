using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Things;

public record ThingItemsQueryParameters(
    [Required] IEnumerable<int> Id,
    IEnumerable<ThingType>? Type = null,
    bool? Versions = null,
    bool? Videos = null,
    bool? Stats = null,
    bool? Marketplace = null,
    bool? Comments = null,
    bool? RatingComments = null,
    int? Page = null,
    int? PageSize = null);
