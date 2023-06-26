using System.ComponentModel.DataAnnotations;

namespace BggSharp.Queries.Users;

public record UserQueryParameters(
    [Required] string Name,
    bool? Buddies = null,
    bool? Guilds = null,
    bool? Hot = null,
    bool? Top = null,
    UserDomain? Domain = null,
    int? Page = null);

public enum UserDomain
{
    boardgame,
    rpg,
    videogame
}
