using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Forum;

public record ForumQueryParameters(
    [Required] int Id,
    int? Page = null);
