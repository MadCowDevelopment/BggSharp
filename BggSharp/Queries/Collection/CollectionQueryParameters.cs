namespace BggSharp.Queries.Collection;

public class CollectionQueryParameters
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CollectionQueryParameters"/> class.
    /// </summary>
    /// <param name="Username">Name of the user to request the collection for.</param>
    public CollectionQueryParameters(string Username)
    {
        this.Username = Username;
    }

    /// <summary>
    /// Name of the user to request the collection for.
    /// </summary>
    public string? Username { get; init; }

    /// <summary>
    /// Returns version info for each item in your collection.
    /// </summary>
    public bool? Version { get; init; }

    /// <summary>
    /// TYPE Specifies which collection you want to retrieve. 
    /// TYPE may be boardgame, boardgameexpansion, boardgameaccessory, rpgitem, rpgissue, or videogame; the default is boardgame
    /// </summary>
    public SubType? SubType { get; init; }

    /// <summary>
    /// TYPE Specifies which subtype you want to exclude from the results.
    /// </summary>
    public SubType? ExcludeSubType { get; init; }

    /// <summary>
    /// Filter collection to specifically listed item(s). NNN may be a comma-delimited list of item ids.
    /// </summary>
    public List<int>? Id { get; init; }

    /// <summary>
    /// Returns more abbreviated results.
    /// </summary>
    public bool? Brief { get; init; }

    /// <summary>
    /// Returns expanded rating/ranking info for the collection.
    /// </summary>
    public bool? Stats { get; init; }

    /// <summary>
    /// Filter for owned games. Set to 0 to exclude these items so marked. Set to 1 for returning owned games and 0 for non-owned games.
    /// </summary>
    public bool? Own { get; init; }

    /// <summary>
    /// Filter for whether an item has been rated. Set to 0 to exclude these items so marked. Set to 1 to include only these items so marked.
    /// </summary>
    public bool? Rated { get; init; }

    /// <summary>
    /// Filter for whether an item has been played. Set to 0 to exclude these items so marked. Set to 1 to include only these items so marked.
    /// </summary>
    public bool? Played { get; init; }

    /// <summary>
    /// Filter for items that have been commented.Set to 0 to exclude these items so marked. Set to 1 to include only these items so marked.
    /// </summary>
    public bool? Comment { get; init; }

    /// <summary>
    /// Filter for items marked for trade.Set to 0 to exclude these items so marked. Set to 1 to include only these items so marked.
    /// </summary>
    public bool? Trade { get; init; }

    /// <summary>
    /// Filter for items wanted in trade.Set to 0 to exclude these items so marked. Set to 1 to include only these items so marked.
    /// </summary>
    public bool? Want { get; init; }

    /// <summary>
    /// Filter for items on the wishlist. Set to 0 to exclude these items so marked. Set to 1 to include only these items so marked.
    /// </summary>
    public bool? Wishlist { get; init; }

    /// <summary>
    /// Filter for wishlist priority. Returns only items of the specified priority.
    /// </summary>
    public int? WishlishPriority { get; init; }

    /// <summary>
    /// Filter for pre-ordered games Returns only items of the specified priority.Set to 0 to exclude these items so marked. Set to 1 to include only these items so marked.
    /// </summary>
    public bool? Preordered { get; init; }

    /// <summary>
    /// Filter for items marked as wanting to play.Set to 0 to exclude these items so marked. Set to 1 to include only these items so marked.
    /// </summary>
    public bool? WantToPlay { get; init; }

    /// <summary>
    /// Filter for ownership flag. Set to 0 to exclude these items so marked. Set to 1 to include only these items so marked.
    /// </summary>
    public bool? WantToBuy { get; init; }

    /// <summary>
    /// Filter for games marked previously owned. Set to 0 to exclude these items so marked. Set to 1 to include only these items so marked.
    /// </summary>
    public bool? PrevOwned { get; init; }

    /// <summary>
    /// Filter on whether there is a comment in the Has Parts field of the item.Set to 0 to exclude these items so marked. Set to 1 to include only these items so marked.
    /// </summary>
    public bool? HasParts { get; init; }

    /// <summary>
    /// Filter on whether there is a comment in the Wants Parts field of the item.Set to 0 to exclude these items so marked. Set to 1 to include only these items so marked.
    /// </summary>
    public bool? WantParts { get; init; }

    /// <summary>
    /// Filter on minimum personal rating assigned for that item in the collection.
    /// </summary>
    public int? MinRating { get; init; }

    /// <summary>
    /// Filter on maximum personal rating assigned for that item in the collection. [Note: Although you'd expect it to be maxrating, it's rating.]
    /// </summary>
    public int? Rating { get; init; }

    /// <summary>
    /// Filter on minimum BGG rating for that item in the collection. Note: 0 is ignored...you can use -1 though, for example min -1 and max 1 to get items w/no bgg rating.
    /// </summary>
    public int? MinBggRating { get; init; }

    /// <summary>
    /// Filter on maximum BGG rating for that item in the collection. [Note: Although you'd expect it to be maxbggrating, it's bggrating.]
    /// </summary>
    public int? BggRating { get; init; }

    /// <summary>
    /// Filter by minimum number of recorded plays.
    /// </summary>
    public int? MinPlays { get; init; }

    /// <summary>
    /// Filter by maximum number of recorded plays. [Note: Although the two maxima parameters above lack the max part, this one really is maxplays.]
    /// </summary>
    public int? MaxPlays { get; init; }

    /// <summary>
    /// Filter to show private collection info.Only works when viewing your own collection and you are logged in.
    /// </summary>
    public bool? ShowPrivate { get; init; }

    /// <summary>
    /// Restrict the collection results to the single specified collection id. Collid is returned in the results of normal queries as well.
    /// </summary>
    public int? CollId { get; init; }

    /// <summary>
    /// YY - MM - DD  Restricts the collection results to only those whose status (own, want, fortrade, etc.) has changed or been added 
    /// since the date specified (does not return results for deletions). Time may be added as well: modifiedsince=YY-MM-DD%20HH:MM:SS
    /// </summary>
    public string? ModifiedSince { get; init; }
}