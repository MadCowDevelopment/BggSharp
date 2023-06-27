using BggSharp.Queries.Families;
using System.Xml.Serialization;

namespace BggSharp.Queries.Forum;

[XmlRoot(ElementName = "threads")]
public class ThreadItems
{
    [XmlElement(ElementName = "thread")]
    public List<Thread> Threads { get; set; }
}