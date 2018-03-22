using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_training
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument srcTree = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("This is a comment"),
                new XElement("Root",
                    new XElement("Child1", "data1"),
                    new XElement("Child2", "data2"),
                    new XElement("Child3", "data3"),
                    new XElement("Child2", "data4"),
                    new XElement("Infos5", "infos5"),
                    new XElement("Child6", "infos6"),
                    new XElement("Child7", "infos7"),
                    new XElement("Child8", "infos8")));

            srcTree.Save("Tree.xml");
        }
    }
}