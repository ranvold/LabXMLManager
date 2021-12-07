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
        private XDocument doc = new XDocument();
        public Linq(string path)
        {
            doc = XDocument.Load(path);
        }

        public List<Student> Algorithm(Student std, string path)
        {
            List<XElement> look = (from xml in doc.Descendants("student")
                                    where
                                    ((std.Group == null || std.Group == xml.Attribute("GROUP").Value) &&
                                    (std.AreaOfThesis == null || std.AreaOfThesis == xml.Attribute("AREA_OF_THESIS").Value) &&
                                    (std.Professor == null || std.Professor == xml.Attribute("PROFESSOR").Value) &&
                                    (std.Schedule == null || std.Schedule == xml.Attribute("SCHEDULE").Value) &&
                                    (std.Stage == null || std.Stage == xml.Attribute("STAGE").Value))
                                    select xml).ToList();

            foreach (var item in look)
            {
                Student student = new Student();
                student.Group = item.Attribute("GROUP").Value;
                student.AreaOfThesis = item.Attribute("AREA_OF_THESIS").Value;
                student.Professor = item.Attribute("PROFESSOR").Value;
                student.Schedule = item.Attribute("SCHEDULE").Value;
                student.Stage = item.Attribute("STAGE").Value;
                info.Add(student);
            }
            return info;
        }
    }
}
