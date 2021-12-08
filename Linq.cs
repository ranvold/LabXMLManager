using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LabXMLManager
{
    class Linq : IStrategy
    {
        private static XDocument _linqDoc = new();

        /* Using Linq to filter search */
        public List<Student> Algorithm(Student std, string path)
        {
            _linqDoc = XDocument.Load(path);
            var result = new List<Student>();

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
                var filteredStudent = new Student
                {
                    Group = item.Attribute("GROUP").Value,
                    AreaOfThesis = item.Attribute("AREA_OF_THESIS").Value,
                    Professor = item.Attribute("PROFESSOR").Value,
                    Schedule = item.Attribute("SCHEDULE").Value,
                    Stage = item.Attribute("STAGE").Value,
                    FullName = item.Attribute("FULLNAME").Value,
                    ThesisTopic = item.Attribute("THESIS_TOPIC").Value,
                    AuxiliaryMaterials = item.Attribute("AUXILIARY_MATERIALS").Value
                };

                result.Add(filteredStudent);
            }
            return result;
        }
    }
}
