using System.Xml.Serialization;

namespace BggSharp.Queries.User;

[XmlRoot(ElementName = "user")]
public class User
{
    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }
    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }
    [XmlAttribute(AttributeName = "termsofuse")]
    public string TermsOfUse { get; set; }
    [XmlElement(ElementName = "firstname")]
    public Firstname Firstname { get; set; }
    [XmlElement(ElementName = "lastname")]
    public Lastname Lastname { get; set; }
    [XmlElement(ElementName = "avatarlink")]
    public AvatarLink AvatarLink { get; set; }
    [XmlElement(ElementName = "yearregistered")]
    public YearRegistered YearRegistered { get; set; }
    [XmlElement(ElementName = "lastlogin")]
    public LastLogin LastLogin { get; set; }
    [XmlElement(ElementName = "stateorprovince")]
    public StateOrProvince StateOrProvince { get; set; }
    [XmlElement(ElementName = "country")]
    public Country Country { get; set; }
    [XmlElement(ElementName = "webaddress")]
    public WebAddress WebAddress { get; set; }
    [XmlElement(ElementName = "xboxaccount")]
    public XBoxAccount XBoxAccount { get; set; }
    [XmlElement(ElementName = "wiiaccount")]
    public Wiiaccount Wiiaccount { get; set; }
    [XmlElement(ElementName = "psnaccount")]
    public PSNAccount PSNAccount { get; set; }
    [XmlElement(ElementName = "battlenetaccount")]
    public BattleNetAccount BattleNetAccount { get; set; }
    [XmlElement(ElementName = "steamaccount")]
    public SteamAccount SteamAccount { get; set; }
    [XmlElement(ElementName = "traderating")]
    public TradeRating TradeRating { get; set; }
    [XmlElement(ElementName = "buddies")]
    public BuddyItems Buddies { get; set; }
    [XmlElement(ElementName = "guilds")]
    public GuildItems Guilds { get; set; }
    [XmlElement(ElementName = "top")]
    public TopItems Top { get; set; }
    [XmlElement(ElementName = "hot")]
    public HotItems Hot { get; set; }
}

[XmlRoot(ElementName = "firstname")] public class Firstname { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }
[XmlRoot(ElementName = "lastname")] public class Lastname { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }
[XmlRoot(ElementName = "avatarlink")] public class AvatarLink { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }
[XmlRoot(ElementName = "yearregistered")] public class YearRegistered { [XmlAttribute(AttributeName = "value")] public int Value { get; set; } }
[XmlRoot(ElementName = "lastlogin")] public class LastLogin { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }
[XmlRoot(ElementName = "stateorprovince")] public class StateOrProvince { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }
[XmlRoot(ElementName = "country")] public class Country { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }
[XmlRoot(ElementName = "webaddress")] public class WebAddress { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }
[XmlRoot(ElementName = "xboxaccount")] public class XBoxAccount { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }
[XmlRoot(ElementName = "wiiaccount")] public class Wiiaccount { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }
[XmlRoot(ElementName = "psnaccount")] public class PSNAccount { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }
[XmlRoot(ElementName = "battlenetaccount")] public class BattleNetAccount { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }
[XmlRoot(ElementName = "steamaccount")] public class SteamAccount { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }
[XmlRoot(ElementName = "traderating")] public class TradeRating { [XmlAttribute(AttributeName = "value")] public string Value { get; set; } }