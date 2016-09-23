using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace SoccerRadarAPI.Models.XML
{
    public class MatchBoxscore
    {
        [XmlRoot(ElementName = "include", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public class Include
        {
            [XmlAttribute(AttributeName = "schemaLocation")]
            public string SchemaLocation { get; set; }
        }

        [XmlRoot(ElementName = "element", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public class Element
        {
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "maxOccurs")]
            public string MaxOccurs { get; set; }
            [XmlAttribute(AttributeName = "minOccurs")]
            public string MinOccurs { get; set; }
        }

        [XmlRoot(ElementName = "sequence", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public class Sequence
        {
            [XmlElement(ElementName = "element", Namespace = "http://www.w3.org/2001/XMLSchema")]
            public List<Element> Element { get; set; }
        }

        [XmlRoot(ElementName = "attribute", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public class Attribute
        {
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlAttribute(AttributeName = "use")]
            public string Use { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
        }

        [XmlRoot(ElementName = "complexType", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public class ComplexType
        {
            [XmlElement(ElementName = "sequence", Namespace = "http://www.w3.org/2001/XMLSchema")]
            public Sequence Sequence { get; set; }
            [XmlElement(ElementName = "attribute", Namespace = "http://www.w3.org/2001/XMLSchema")]
            public Attribute Attribute { get; set; }
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlElement(ElementName = "complexContent", Namespace = "http://www.w3.org/2001/XMLSchema")]
            public ComplexContent ComplexContent { get; set; }
        }

        [XmlRoot(ElementName = "extension", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public class Extension
        {
            [XmlElement(ElementName = "sequence", Namespace = "http://www.w3.org/2001/XMLSchema")]
            public Sequence Sequence { get; set; }
            [XmlAttribute(AttributeName = "base")]
            public string Base { get; set; }
        }

        [XmlRoot(ElementName = "complexContent", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public class ComplexContent
        {
            [XmlElement(ElementName = "extension", Namespace = "http://www.w3.org/2001/XMLSchema")]
            public Extension Extension { get; set; }
        }

        [XmlRoot(ElementName = "schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public class Schema
        {
            [XmlElement(ElementName = "include", Namespace = "http://www.w3.org/2001/XMLSchema")]
            public Include Include { get; set; }
            [XmlElement(ElementName = "element", Namespace = "http://www.w3.org/2001/XMLSchema")]
            public Element Element { get; set; }
            [XmlElement(ElementName = "complexType", Namespace = "http://www.w3.org/2001/XMLSchema")]
            public List<ComplexType> ComplexType { get; set; }
            [XmlAttribute(AttributeName = "xs", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xs { get; set; }
            [XmlAttribute(AttributeName = "soccer", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Soccer { get; set; }
            [XmlAttribute(AttributeName = "targetNamespace")]
            public string TargetNamespace { get; set; }
            [XmlAttribute(AttributeName = "elementFormDefault")]
            public string ElementFormDefault { get; set; }
        }

    }

}
}
