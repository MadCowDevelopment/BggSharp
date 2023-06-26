using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.ForumLists;

public record ForumListItemsQueryParameters(
    [Required] int Id,
    [Required] ForumListType Type);
