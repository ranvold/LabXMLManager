using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabXMLManager
{
    class Linq : IStrategy
    {
        private List<Student> info = new List<Student>();
        XDocument doc = new XDocument();
        public Linq(string path)
        {
            doc = XDocument.Load(path);
        }

        public List<Student> Algorithm(Student std, string path)
        {
            List<XElement> match = (from xml in doc.Descendants("student")
                                    where
                                    ((std.Group == null || std.Group == xml.Attribute("GROUP").Value) &&
                                    (std.AreaOfThesis == null || std.AreaOfThesis == xml.Attribute("AREA_OF_THESIS").Value) &&
                                    ))

        }
    }
}
