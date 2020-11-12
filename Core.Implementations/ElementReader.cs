using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Core.Interfaces;

namespace Core.Implementations
{
    public class ElementReader:IElementReader
    {
        public List<IElement> Read(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File at {filePath} does not exist");
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Root));
            var xml = serializer.Deserialize(
                File.OpenRead(filePath)) as Root;
            return xml.Element.Select(e=> e as IElement).ToList();
        }
    }
}