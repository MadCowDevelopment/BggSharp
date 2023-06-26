using System.Xml.Serialization;

namespace BggSharp.Queries.ForumLists;

[XmlRoot(ElementName = "forum")]
public class Forum
{
    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }
    [XmlAttribute(AttributeName = "groupid")]
    public string GroupId { get; set; }
    [XmlAttribute(AttributeName = "title")]
    public string Title { get; set; }
    [XmlAttribute(AttributeName = "noposting")]
    public bool NoPosting { get; set; }
    [XmlAttribute(AttributeName = "description")]
    public string Description { get; set; }
    [XmlAttribute(AttributeName = "numthreads")]
    public int NumberOfThreads { get; set; }
    [XmlAttribute(AttributeName = "numposts")]
    public int NumberOfPosts{ get; set; }
    [XmlAttribute(AttributeName = "lastpostdate")]
    public string LastPostDate { get; set; }
}