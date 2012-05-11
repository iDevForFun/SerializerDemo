using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SerializerDemo
{
    public class Serializer<T> where T : class 
    {
        public string Serialize(T obj)
        {
            var serializer = new XmlSerializer(typeof (T));
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            
            var sb = new StringBuilder();
            using (var writer = XmlWriter.Create(sb))
            {
                serializer.Serialize(writer, obj, namespaces);
            }
            
            return sb.ToString();
        }

        public T Deserialise(string xml)
        {
            var serialiser = new XmlSerializer(typeof (T));
            
            
            using (var stream = new MemoryStream(Encoding.Unicode.GetBytes(xml)))
            {
                return serialiser.Deserialize(stream) as T;
            }
        }
    }
}
