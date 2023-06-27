using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Search;

public record SearchQueryParameters(
    [Required] string Query,
    List<SearchType>? Type = null,
    bool? Exact = null);

public enum SearchType
{
    rpgitem,
    videogame,
    boardgame,
    boardgameaccessory,
    boardgameexpansion
}
