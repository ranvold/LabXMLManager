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
                        string fullName = "";
                        string group = "";
                        string areaOfThesis = "";
                        string professor = "";
                        string thesisTopic = "";
                        string schedule = "";
                        string auxiliaryMaterials = "";
                        string stage = "";                            

                        if (xmlReader.Name.Equals("FULLNAME"))
                        {
                            fullName = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();

                            if (xmlReader.Name.Equals("GROUP") && (xmlReader.Value.Equals(std.Group) || (String.IsNullOrEmpty(std.Group))))
                            {
                                group = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();

                                if (xmlReader.Name.Equals("AREA_OF_THESIS") && (xmlReader.Value.Equals(std.AreaOfThesis) || (String.IsNullOrEmpty(std.AreaOfThesis))))
                                {
                                    areaOfThesis = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();

                                    if (xmlReader.Name.Equals("PROFESSOR") && (xmlReader.Value.Equals(std.Professor) || (String.IsNullOrEmpty(std.Professor))))
                                    {
                                        professor = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();

                                        if (xmlReader.Name.Equals("THESIS_TOPIC"))
                                        {
                                            thesisTopic = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();

                                            if (xmlReader.Name.Equals("SCHEDULE") && (xmlReader.Value.Equals(std.Schedule) || (String.IsNullOrEmpty(std.Schedule))))
                                            {
                                                schedule = xmlReader.Value;
                                                xmlReader.MoveToNextAttribute();

                                                if (xmlReader.Name.Equals("AUXILIARY_MATERIALS"))
                                                {
                                                    auxiliaryMaterials = xmlReader.Value;
                                                    xmlReader.MoveToNextAttribute();

                                                    if (xmlReader.Name.Equals("STAGE") && (xmlReader.Value.Equals(std.Stage) || (String.IsNullOrEmpty(std.Stage))))
                                                    {
                                                        stage = xmlReader.Value;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (group != "" && areaOfThesis != "" && professor != "" && schedule != "" && stage != "")
                            {
                                Student filteredStudent = new()
                                {
                                    Group = group,
                                    AreaOfThesis = areaOfThesis,
                                    Professor = professor,
                                    Schedule = schedule,
                                    Stage = stage,
                                    FullName = fullName,
                                    ThesisTopic = thesisTopic,
                                    AuxiliaryMaterials = auxiliaryMaterials
                                };

                                result.Add(filteredStudent);
                            }
                        }
                    }
                }
            }
            xmlReader.Close();
            return result;
        }
    }
}