using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;

[XmlRoot(ElementName = "forum")]
public class ForumItems
{
    [XmlElement(ElementName = "threads")]
    public ThreadItems Threads { get; set; }
    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }
    [XmlAttribute(AttributeName = "title")]
    public string Title { get; set; }
    [XmlAttribute(AttributeName = "numthreads")]
    public int NumberOfThreads { get; set; }
    [XmlAttribute(AttributeName = "numposts")]
    public string NumberOfPosts { get; set; }
    [XmlAttribute(AttributeName = "LastPostData")]
    public string LastPostDate { get; set; }
    [XmlAttribute(AttributeName = "noposting")]
    public bool NoPosting { get; set; }
    [XmlAttribute(AttributeName = "termsofuse")]
    public string TermsOfUse { get; set; }
}
