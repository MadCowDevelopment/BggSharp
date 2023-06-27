using BggSharp.Queries.Collection;
using BggSharp.Queries.Families;
using BggSharp.Queries.Forum;
using BggSharp.Queries.Forums;
using BggSharp.Queries.Guild;
using BggSharp.Queries.Hotness;
using BggSharp.Queries.Plays;
using BggSharp.Queries.Search;
using BggSharp.Queries.Things;
using BggSharp.Queries.Thread;
using BggSharp.Queries.User;

namespace BggSharp.Test;

[TestClass]
public class QueryTest
{
    [TestMethod]
    public async Task ThingItems()
    {
        var client = new ThingsQuery(new DefaultBggClient(new HttpClient()));

        var result = await client.Query(new ThingsQueryParameters(new[] { 183685 }));

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task FamilyItems()
    {
        var client = new FamiliesQuery(new DefaultBggClient(new HttpClient()));

        var result = await client.Query(new FamiliesQueryParameters(new[] { 2 }));

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task ForumListItems()
    {
        var client = new ForumsQuery(new DefaultBggClient(new HttpClient()));

        var result = await client.Query(new ForumsQueryParameters(352606, ForumListType.thing));

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task ForumItems()
    {
        var client = new ForumQuery(new DefaultBggClient(new HttpClient()));

        var result = await client.Query(new ForumQueryParameters(791, 3));

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task ThreadItems()
    {
        var client = new ThreadQuery(new DefaultBggClient(new HttpClient()));

        var result = await client.Query(new ThreadQueryParameters(618360));

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task User()
    {
        var client = new UserQuery(new DefaultBggClient(new HttpClient()));

        var result = await client.Query(new UserQueryParameters("MadMihi", true, true, true, true));

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task Guild()
    {
        var client = new GuildQuery(new DefaultBggClient(new HttpClient()));

        var result = await client.Query(new GuildQueryParameters(1303, true));

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task Plays()
    {
        var client = new PlaysQuery(new DefaultBggClient(new HttpClient()));

        var result = await client.Query(new PlaysQueryParameters("betsychuck"));

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task Collection()
    {
        var client = new CollectionQuery(new DefaultBggClient(new HttpClient()));

        var result = await client.Query(new CollectionQueryParameters("MadMihi") {  Stats = true });

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task Hotness()
    {
        var client = new HotnessQuery(new DefaultBggClient(new HttpClient()));

        var result = await client.Query(new HotnessQueryParameters());

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task Search()
    {
        var client = new SearchQuery(new DefaultBggClient(new HttpClient()));

        var result = await client.Query(new SearchQueryParameters("president"));

        Assert.IsNotNull(result);
    }
}