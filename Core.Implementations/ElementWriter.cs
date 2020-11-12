using System.Collections.Generic;
using System.IO;
using Core.Interfaces;
using Newtonsoft.Json;

namespace Core.Implementations
{
    public class ElementWriter : IElementWriter
    {
        public void Write(List<IElement> elements, string filePath)
        {
            if (!Directory.GetParent(filePath).Exists)
            {
                throw new DirectoryNotFoundException($"Directory for path: {filePath} does not exist");
            };

            var jsonResultString = JsonConvert.SerializeObject(elements, Formatting.Indented);
            File.WriteAllText(filePath, jsonResultString);
        }
    }
}