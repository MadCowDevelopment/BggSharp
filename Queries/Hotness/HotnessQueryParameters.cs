namespace BggSharp.Queries.Hotness;

public record HotnessQueryParameters(Subtype? Type = null);

public enum Subtype
{
    boardgame,
    rpg,
    videogame,
    boardgameperson,
    rpgperson,
    boardgamecompany,
    rpgcompany,
    videogamecompany
}
