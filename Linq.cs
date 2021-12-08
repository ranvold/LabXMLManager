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
        private static XDocument _linqDoc = new XDocument();

        public Linq(string path)
        {
            _linqDoc = XDocument.Load(path);
        }

        public List<Student> Algorithm(Student std, string path)
        {
            List<Student> result = new List<Student>();

            List<XElement> look = (from xml in _linqDoc.Descendants("student")
                                    where
                                    ((std.Group == null || std.Group == xml.Attribute("GROUP").Value) &&
                                    (std.AreaOfThesis == null || std.AreaOfThesis == xml.Attribute("AREA_OF_THESIS").Value) &&
                                    (std.Professor == null || std.Professor == xml.Attribute("PROFESSOR").Value) &&
                                    (std.Schedule == null || std.Schedule == xml.Attribute("SCHEDULE").Value) &&
                                    (std.Stage == null || std.Stage == xml.Attribute("STAGE").Value))
                                    select xml).ToList();

            foreach (var item in look)
            {
                Student filteredStudent = new Student();
                filteredStudent.Group = item.Attribute("GROUP").Value;
                filteredStudent.AreaOfThesis = item.Attribute("AREA_OF_THESIS").Value;
                filteredStudent.Professor = item.Attribute("PROFESSOR").Value;
                filteredStudent.Schedule = item.Attribute("SCHEDULE").Value;
                filteredStudent.Stage = item.Attribute("STAGE").Value;

                filteredStudent.FullName = item.Attribute("FULLNAME").Value;
                filteredStudent.ThesisTopic = item.Attribute("THESIS_TOPIC").Value;
                filteredStudent.AuxiliaryMaterials = item.Attribute("AUXILIARY_MATERIALS").Value;
                result.Add(filteredStudent);
            }
            return result;
        }
    }
}
