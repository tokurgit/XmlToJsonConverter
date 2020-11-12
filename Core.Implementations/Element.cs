using System.Collections.Generic;
using System.Xml.Serialization;
using Core.Interfaces;
using Newtonsoft.Json;

namespace Core.Implementations
{
    [XmlRoot(ElementName = "element")]
    public class Element : IElement
    {
        [JsonIgnore]
        [XmlElement(ElementName = "variable1")]
        public double Variable1 { get; set; }

        [JsonIgnore]
        [XmlElement(ElementName = "variable2")]

        public double Variable2 { get; set; }
        [JsonProperty("multiplied")]
        public double Multiplied => Variable1 * Variable2;

        [JsonProperty("divided")]
        public double Divided => Variable1 / Variable2;
    }

    [XmlRoot(ElementName = "root")]
    public class Root
    {
        [XmlElement(ElementName = "element")]
        public List<Element> Element { get; set; }
    }
}
