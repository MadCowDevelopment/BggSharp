using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Plays;

public record PlaysQueryParameters(
    [Required] string Username,
    int? Id = null,
    PlayType? Type = null,
    string? MinDate = null,
    string? MaxDate = null,
    SubTypes? SubType = null,
    int? Page = null);

public enum PlayType
{
    thing,
    family
}

public enum SubTypes
{
    boardgame,
    boardgameexpansion,
    boardgameaccessory,
    boardgameintegration,
    boardgamecompilation,
    boardgameimplementation,
    rpg,
    rpgitem,
    videogame
}