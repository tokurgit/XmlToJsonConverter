using Core.Implementations;
using Core.Interfaces;

namespace XMLtoJSON
{
    class Program
    {
        private static string filePathFromXML = @"C:\Users\tokur\TASKS\XmlToJsonConverter\XMLtoJSON\XMLFileToConvert.xml";
        private static string filePathToJSON = @"C:\Users\tokur\TASKS\XmlToJsonConverter\XMLtoJSON\JSONFileResult.json";

        static void Main(string[] args)
        {
            IElementReader reader = new ElementReader();
            var items = reader.Read(filePathFromXML);

            IElementWriter writer = new ElementWriter();
            writer.Write(items, filePathToJSON);
        }
    }
}
