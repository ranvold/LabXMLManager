using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace LabXMLManager
{
    public partial class MainForm : Form
    {
        private List<Student> gottenStudent = new();
        private string path = "XMLDB.xml";

        public MainForm()
        {
            InitializeComponent();
            GetAllStudents();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            RichTextBoxDisplay.Clear();
            Student student = CurrentStudent();
            if (RadioButtonLinq.Checked)
            {
                IStrategy CurrentStrategy = new Linq(path);
                gottenStudent = CurrentStrategy.Algorithm(student, path);
                Result(gottenStudent);
            }
            //if (RadioButtonDom.Checked)
            //{
            //    IStrategy CurrentStrategy = new Dom(path);
            //}
            //if (RadioButtonSax.Checked)
            //{
            //    IStrategy CurrentStrategy = new Sax(path);
            //}

        }
        private Student CurrentStudent()
        {
            string[] info = new string[5];
            if (CheckBoxGroup.Checked)
            {
                info[0] = ComboBoxGroup.Text;
            }
            if (CheckBoxAreaOfThesis.Checked)
            {
                info[1] = ComboBoxAreaOfThesis.Text;
            }
            if (CheckBoxProfessor.Checked)
            {
                info[2] = ComboBoxProfessor.Text;
            }
            if (CheckBoxSchedule.Checked)
            {
                info[3] = ComboBoxSchedule.Text;
            }
            if (CheckBoxStage.Checked)
            {
                info[4] = ComboBoxStage.Text;
            }
            Student currStudent = new(info);
            return currStudent;
        }

        private void Result(List<Student> gottenStudent)
        {
            foreach (var item in gottenStudent)
            {
                RichTextBoxDisplay.AppendText("Group: " + item.Group + '\n');
                RichTextBoxDisplay.AppendText("Area of thesis: " + item.AreaOfThesis + '\n');
                RichTextBoxDisplay.AppendText("Professor: " + item.Professor + '\n');
                RichTextBoxDisplay.AppendText("Schedule: " + item.Schedule + '\n');
                RichTextBoxDisplay.AppendText("Stage: " + item.Stage + '\n');
                RichTextBoxDisplay.AppendText("-------------------------------------------\n");
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            RichTextBoxDisplay.Clear();
            CheckBoxGroup.Checked = false;
            CheckBoxAreaOfThesis.Checked = false;
            CheckBoxProfessor.Checked = false;
            CheckBoxSchedule.Checked = false;
            CheckBoxStage.Checked = false;
            ComboBoxGroup.Text = null;
            ComboBoxAreaOfThesis.Text = null;
            ComboBoxProfessor.Text = null;
            ComboBoxSchedule.Text = null;
            ComboBoxStage.Text = null;
            RadioButtonSax.Checked = false;
            RadioButtonLinq.Checked = false;
            RadioButtonDom.Checked = false;
        }

        private void GetAllStudents()
        {
            var doc = new XmlDocument();
            doc.Load("XMLDB.xml");
            XmlNodeList element = doc.SelectNodes("//student");
            foreach (XmlNode item in element)
            {
                string group = item.Attributes.GetNamedItem("GROUP").Value;
                if (!ComboBoxGroup.Items.Contains(group))
                    ComboBoxGroup.Items.Add(group);
                string areaOfThesis = item.Attributes.GetNamedItem("AREA_OF_THESIS").Value;
                if (!ComboBoxAreaOfThesis.Items.Contains(areaOfThesis))
                    ComboBoxAreaOfThesis.Items.Add(areaOfThesis);
                string professor = item.Attributes.GetNamedItem("PROFESSOR").Value;
                if (!ComboBoxProfessor.Items.Contains(professor))
                    ComboBoxProfessor.Items.Add(professor);
                string schedule = item.Attributes.GetNamedItem("SCHEDULE").Value;
                if (!ComboBoxSchedule.Items.Contains(schedule))
                    ComboBoxSchedule.Items.Add(schedule);
                string stage = item.Attributes.GetNamedItem("STAGE").Value;
                if (!ComboBoxStage.Items.Contains(stage))
                    ComboBoxStage.Items.Add(stage);

            }
        }

        private void ButtonTransformToHTML_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("XSL.xsl");
            string input = @"XMLDB.xml";
            string output = @"table.html";

            xslt.Transform(input, output);
        }
    }
}
