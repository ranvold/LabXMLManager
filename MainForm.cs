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
        public MainForm()
        {
            InitializeComponent();
            Manager.GetAllFilters(ComboBoxGroup, ComboBoxAreaOfThesis, 
                ComboBoxProfessor, ComboBoxSchedule, ComboBoxStage);
        }

        private Student CurrentStudentFilters()
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

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            RichTextBoxDisplay.Clear();

            Student student = CurrentStudentFilters();

            Manager.Search(RadBtnLinq.Checked,
                RadBtnDom.Checked, RadBtnSax.Checked, student);

            Manager.Result(RichTextBoxDisplay);
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
            RadBtnSax.Checked = false;
            RadBtnLinq.Checked = false;
            RadBtnDom.Checked = false;
        }

        private void ButtonTransformToHTML_Click(object sender, EventArgs e)
        {
            Manager.TransformToHTML();
        }
    }
}
