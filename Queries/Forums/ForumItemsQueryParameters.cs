using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Forums;

public record ForumItemsQueryParameters(
    [Required] int Id,
    int? Page = null);
