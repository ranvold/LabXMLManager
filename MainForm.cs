using System;
using System.Windows.Forms;

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

        /* Find out the current filters */
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
            if (!RadBtnDom.Checked && !RadBtnLinq.Checked && !RadBtnSax.Checked)
            {
                MessageBox.Show(
                    "Please select one of the search methods: SAX, DOM, LINQ.",
                    "INFO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                return;
            }

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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close the program?",
                "WARNING!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            e.Cancel = result == DialogResult.No;
        }

        private void CheckBoxGroup_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxGroup.Enabled = ComboBoxGroup.Enabled != true;
            ComboBoxGroup.Text = null;
        }

        private void CheckBoxAreaOfThesis_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxAreaOfThesis.Enabled = ComboBoxAreaOfThesis.Enabled != true;
            ComboBoxAreaOfThesis.Text = null;
        }

        private void CheckBoxProfessor_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxProfessor.Enabled = ComboBoxProfessor.Enabled != true;
            ComboBoxProfessor.Text = null;
        }

        private void CheckBoxSchedule_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxSchedule.Enabled = ComboBoxSchedule.Enabled != true;
            ComboBoxSchedule.Text = null;
        }

        private void CheckBoxStage_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStage.Enabled = ComboBoxStage.Enabled != true;
            ComboBoxStage.Text = null;
        }
    }
}
