using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Guilds;

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