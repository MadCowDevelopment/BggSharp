using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Threads;

public record ThreadItemsQueryParameters(
    [Required] int Id,
    int? MinArticleId = null,
    string? MinArticleDate = null,
    int? Count = null);
