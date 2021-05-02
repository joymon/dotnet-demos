using EasyConsole;
using System;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.IO;

namespace UncommentSection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string absoluteSourcePath = Path.GetFullPath("testFiles/web.config");
            if (TryUncommentingAuthenticationNode(absoluteSourcePath))
            {
                Output.WriteLine(ConsoleColor.Green, "Saved after uncommenting <authentication> node");
            }
            else
            {
                Output.WriteLine(ConsoleColor.Red, $"Didnt find <authentication> node in the file {absoluteSourcePath}");
            }

            Input.ReadString("Press any key to exit...");
        }

        private static bool TryUncommentingAuthenticationNode(string absoluteSourcePath)
        {
            XDocument xDoc = ReadXMLFileWithoutLocking(absoluteSourcePath);
            var result = xDoc.DescendantNodes()
                .Where (node => node.NodeType == XmlNodeType.Comment)
                .Select(node=> node as XComment)
                // Kind of bad way to check string. Better parse the value and make sure its <authentication> node. Or atleast use RegEx
                .Where(node => node.Value.StartsWith("<authentication"))
                .FirstOrDefault();
            if (result == null)
            {
                return false;
            }
            else
            {
                Output.WriteLine(ConsoleColor.Cyan, $"Going to replace as its <authentication> node :  {result.Value}");
                result.ReplaceWith(XElement.Parse(result.Value));
                xDoc.Save(absoluteSourcePath);
                return true;
            }
        }

        private static XDocument ReadXMLFileWithoutLocking(string absoluteSourcePath)
        {
            XmlReaderSettings readerSettings = new XmlReaderSettings() { IgnoreComments = false };
            using (XmlReader reader = XmlReader.Create(absoluteSourcePath, readerSettings))
            {
                XDocument xDoc = XDocument.Load(reader);
                return xDoc;
            }
        }
    }
}
