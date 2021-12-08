using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace LabXMLManager
{
    static class Manager
    { 
        private const string PathXML = @"database.xml";
        private const string PathGenXML = @"gen.xml";
        private const string PathXSLT = @"template.xslt";
        private const string PathHTML = @"table.html";
        private static List<Student> gottenStudents = new();

        /* Get all filters from file */
        public static void GetAllFilters(ComboBox Group, ComboBox AreaOfThesis,
            ComboBox Professor, ComboBox Schedule, ComboBox Stage)
        {
            var doc = new XmlDocument();
            doc.Load(PathXML);
            XmlNodeList element = doc.SelectNodes("//student");
            foreach (XmlNode item in element)
            {
                string group = item.Attributes.GetNamedItem("GROUP").Value;
                if (!Group.Items.Contains(group))
                    Group.Items.Add(group);
                string areaOfThesis = item.Attributes.GetNamedItem("AREA_OF_THESIS").Value;
                if (!AreaOfThesis.Items.Contains(areaOfThesis))
                    AreaOfThesis.Items.Add(areaOfThesis);
                string professor = item.Attributes.GetNamedItem("PROFESSOR").Value;
                if (!Professor.Items.Contains(professor))
                    Professor.Items.Add(professor);
                string schedule = item.Attributes.GetNamedItem("SCHEDULE").Value;
                if (!Schedule.Items.Contains(schedule))
                    Schedule.Items.Add(schedule);
                string stage = item.Attributes.GetNamedItem("STAGE").Value;
                if (!Stage.Items.Contains(stage))
                    Stage.Items.Add(stage);
            }
        }


        /* The choice of the search algorithm depending on the user's choice. */
        public static void Search(bool linq, bool dom, bool sax, Student student)
        {
            if (linq)
            {
                IStrategy CurrentStrategy = new Linq();
                gottenStudents = CurrentStrategy.Algorithm(student, PathXML);
            }
            else if (dom)
            {
                IStrategy CurrentStrategy = new Dom();
                gottenStudents = CurrentStrategy.Algorithm(student, PathXML);
            }
            else if (sax)
            {
                IStrategy CurrentStrategy = new Sax();
                gottenStudents = CurrentStrategy.Algorithm(student, PathXML);
            }
        }

        /* We display the already filtered list. */
        public static void Result(RichTextBox Display)
        {
            foreach (var item in gottenStudents)
            {
                Display.AppendText("Full name: " + item.FullName + '\n');
                Display.AppendText("Group: " + item.Group + '\n');
                Display.AppendText("Thesis topic: " + item.ThesisTopic + '\n');
                Display.AppendText("Area of thesis: " + item.AreaOfThesis + '\n');
                Display.AppendText("Professor: " + item.Professor + '\n');
                Display.AppendText("Schedule: " + item.Schedule + '\n');
                Display.AppendText("Auxiliary materials: " + item.AuxiliaryMaterials + '\n');
                Display.AppendText("Stage: " + item.Stage + '\n');
                Display.AppendText("--------------------------------------------\n");
            }
        }

        /* Transforming to html based on the filtered list */
        public static void TransformToHTML()
        {
            var genDoc = new XDocument();
            var StudentsDataBase = new XElement("StudentsDataBase");
            genDoc.Add(StudentsDataBase);
            foreach (var item in gottenStudents)
            {
                var student = new XElement("student");
                student.Add
                (
                    new XAttribute("FULLNAME", item.FullName),
                    new XAttribute("GROUP", item.Group),
                    new XAttribute("AREA_OF_THESIS", item.AreaOfThesis),
                    new XAttribute("PROFESSOR", item.Professor),
                    new XAttribute("THESIS_TOPIC", item.ThesisTopic),
                    new XAttribute("SCHEDULE", item.Schedule),
                    new XAttribute("AUXILIARY_MATERIALS", item.AuxiliaryMaterials),
                    new XAttribute("STAGE", item.Stage)
               );
                StudentsDataBase.Add(student);
            }
            genDoc.Save(PathGenXML);

            var xslt = new XslCompiledTransform();
            xslt.Load(PathXSLT);
            string input = PathGenXML;
            string output = PathHTML;
            xslt.Transform(input, output);
        }
    }
}
