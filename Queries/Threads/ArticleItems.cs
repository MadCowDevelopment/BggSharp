using System.Xml.Serialization;

namespace BggSharp.Queries.Threads;

[XmlRoot(ElementName = "articles")]
public class ArticleItems
{
    [XmlElement(ElementName = "article")]
    public List<Article> Articles { get; set; }
}
