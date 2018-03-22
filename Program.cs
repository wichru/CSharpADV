using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace XML_to_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string delimiter = ",";

            XDocument.Load(@"C:\Users\Maciek\source\repos\Linq_to_xml\data.xml").Descendants("Student").ToList().ForEach(
                element => sb.Append(element.Attribute("Id").Value + delimiter +
                                     element.Element("Name").Value + delimiter +
                                     element.Element("Gender").Value + delimiter +
                                     element.Element("TotalMarks").Value + "\r\n"));

            StreamWriter sw = new StreamWriter(@"C:\Users\Maciek\source\repos\Linq_to_xml\result.csv");
            sw.WriteLine(sb.ToString());
            sw.Close();
        }
    }
}
