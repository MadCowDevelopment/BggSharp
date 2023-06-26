using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Thread;

public record ThreadQueryParameters(
    [Required] int Id,
    int? MinArticleId = null,
    string? MinArticleDate = null,
    int? Count = null);
