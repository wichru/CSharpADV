using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_to_HTML_table
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument result = new XDocument(
                new XElement("table", new XAttribute("border", 1),
                    new XElement("thead",
                        new XElement("tr",
                            new XElement("th", "Id"),
                            new XElement("th", "Name"),
                            new XElement("th", "Gender"),
                            new XElement("th", "TotalMarks"))),
                new XElement("tbody",
                    from student in XDocument.Load(@"C:\Users\Maciek\source\repos\Linq_to_xml\data.xml").Descendants("Student")
                    select new XElement("tr",
                        new XElement("td", student.Attribute("Id").Value),
                        new XElement("td", student.Element("Name").Value),
                        new XElement("td", student.Attribute("Gender").Value),
                        new XElement("td", student.Attribute("TotalMarks").Value)))));

            result.Save(@"C:\Users\Maciek\source\repos\Linq_to_xml\result.htm");
        }
    }
}
