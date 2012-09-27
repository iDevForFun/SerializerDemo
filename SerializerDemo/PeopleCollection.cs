using System.Collections.Generic;
using System.Xml.Serialization;

namespace SerializerDemo
{
    [XmlRoot("people")]
    public class PeopleCollection : List<Person>
    {
        
    }
}
