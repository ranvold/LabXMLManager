using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private const string PathXSL = @"template.xslt";
        private const string PathHTML = @"table.html";
        private static List<Student> gottenStudents = new();

        public static void GetAllFilters(ComboBox Group, ComboBox AreaOfThesis,
            ComboBox Professor, ComboBox Schedule, ComboBox Stage)
        {
            var doc = new XmlDocument();
            doc.Load("database.xml");
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

        public static void Search(bool linq, bool dom, bool sax, Student student)
        {
            if (linq)
            {
                IStrategy CurrentStrategy = new Linq(PathXML);
                gottenStudents = CurrentStrategy.Algorithm(student, PathXML);
            }
            else if (dom)
            {
                IStrategy CurrentStrategy = new Dom(PathXML);
                gottenStudents = CurrentStrategy.Algorithm(student, PathXML);
            }
            else if (sax)
            {
                //IStrategy CurrentStrategy = new Sax(PathXML);
                //gottenStudents = CurrentStrategy.Algorithm(student, PathXML);
            }
        }
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
        public static void TransformToHTML()
        {
            XDocument xdoc = new XDocument();
            XElement StudentsDataBase = new XElement("StudentsDataBase");
            xdoc.Add(StudentsDataBase);
            foreach (var item in gottenStudents)
            {
                XElement student = new XElement("student");
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
            xdoc.Save(PathGenXML);

            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(PathXSL);
            string input = PathGenXML;
            string output = PathHTML;
            xslt.Transform(input, output);
        }
    }
}
