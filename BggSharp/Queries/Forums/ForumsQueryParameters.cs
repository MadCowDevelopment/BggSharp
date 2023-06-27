using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Forums;

public record ForumsQueryParameters(
    [Required] int Id,
    [Required] ForumListType Type);
