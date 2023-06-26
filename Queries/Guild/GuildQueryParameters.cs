using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Guild;

public record GuildQueryParameters(
    [Required] int Id,
    bool? Members = null,
    SortType? Sort = null,
    int? Page = null);

public enum SortType
{
    username,
    date
}