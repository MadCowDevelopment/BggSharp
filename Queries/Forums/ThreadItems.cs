using BggSharp.Queries.Families;
using System.Xml.Serialization;

namespace BggSharp.Queries.Forums;

[XmlRoot(ElementName = "threads")]
public class ThreadItems
{
    [XmlElement(ElementName = "thread")]
    public List<Thread> Threads { get; set; }
}