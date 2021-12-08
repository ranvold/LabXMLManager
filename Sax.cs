using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LabXMLManager
{
    class Sax : IStrategy
    {
        public List<Student> Algorithm(Student std, string path)
        {
            List<Student> result = new();

            var xmlReader = new XmlTextReader(path);

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        string group = "";
                        string areaOfThesis = "";
                        string professor = "";
                        string schedule = "";
                        string stage = "";
                        string fullName = "";
                        string thesisTopic = "";
                        string auxiliaryMaterials = "";

                        if (xmlReader.Name.Equals("GROUP") && (xmlReader.Value.Equals(std.Group) || (String.IsNullOrEmpty(std.Group))))
                        {
                            group = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();

                            if (xmlReader.Name.Equals("GROUP") && (xmlReader.Value.Equals(std.Group) || (String.IsNullOrEmpty(std.Group))))
                            {
                                group = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();

                                if (xmlReader.Name.Equals("GROUP") && (xmlReader.Value.Equals(std.Group) || (String.IsNullOrEmpty(std.Group))))
                                {
                                    group = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();

                                    if (xmlReader.Name.Equals("GROUP") && (xmlReader.Value.Equals(std.Group) || (String.IsNullOrEmpty(std.Group))))
                                    {
                                        group = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();

                                        if (xmlReader.Name.Equals("GROUP") && (xmlReader.Value.Equals(std.Group) || (String.IsNullOrEmpty(std.Group))))
                                        {
                                            group = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();

                                        }
                                    }
                                }
                            }
                        }
                    }

                }
                
                //if (group != "" && areaOfThesis != "" && professor != "" && schedule != "" && stage != "")
                //{
                //    Student filteredStudent = new Student();
                //    filteredStudent.Group = group;
                //    filteredStudent.AreaOfThesis = areaOfThesis;
                //    filteredStudent.Professor = professor;
                //    filteredStudent.Schedule = schedule;
                //    filteredStudent.Stage = stage;
                //    filteredStudent.FullName = fullName;
                //    filteredStudent.ThesisTopic = thesisTopic;
                //    filteredStudent.AuxiliaryMaterials = auxiliaryMaterials;
                //    result.Add(filteredStudent);
                //}
            }
            return result;
        }
    }
}

foreach (XmlNode currNode in node)
{

    foreach (XmlAttribute attr in currNode.Attributes)
    {
        if (attr.Name.Equals("GROUP") && (attr.Value.Equals(std.Group) || (String.IsNullOrEmpty(std.Group))))
            group = attr.Value;
        if (attr.Name.Equals("AREA_OF_THESIS") && (attr.Value.Equals(std.AreaOfThesis) || (String.IsNullOrEmpty(std.AreaOfThesis))))
            areaOfThesis = attr.Value;
        if (attr.Name.Equals("PROFESSOR") && (attr.Value.Equals(std.Professor) || (String.IsNullOrEmpty(std.Professor))))
            professor = attr.Value;
        if (attr.Name.Equals("SCHEDULE") && (attr.Value.Equals(std.Schedule) || (String.IsNullOrEmpty(std.Schedule))))
            schedule = attr.Value;
        if (attr.Name.Equals("STAGE") && (attr.Value.Equals(std.Stage) || (String.IsNullOrEmpty(std.Stage))))
            stage = attr.Value;

        if (attr.Name.Equals("FULLNAME"))
            fullName = attr.Value;
        if (attr.Name.Equals("THESIS_TOPIC"))
            thesisTopic = attr.Value;
        if (attr.Name.Equals("AUXILIARY_MATERIALS"))
            auxiliaryMaterials = attr.Value;
    }
}