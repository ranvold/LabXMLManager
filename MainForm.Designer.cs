
namespace LabXMLManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckBoxGroup = new System.Windows.Forms.CheckBox();
            this.CheckBoxAreaOfThesis = new System.Windows.Forms.CheckBox();
            this.CheckBoxProfessor = new System.Windows.Forms.CheckBox();
            this.CheckBoxSchedule = new System.Windows.Forms.CheckBox();
            this.CheckBoxStage = new System.Windows.Forms.CheckBox();
            this.ComboBoxGroup = new System.Windows.Forms.ComboBox();
            this.ComboBoxAreaOfThesis = new System.Windows.Forms.ComboBox();
            this.ComboBoxProfessor = new System.Windows.Forms.ComboBox();
            this.ComboBoxSchedule = new System.Windows.Forms.ComboBox();
            this.ComboBoxStage = new System.Windows.Forms.ComboBox();
            this.RadBtnSax = new System.Windows.Forms.RadioButton();
            this.RadBtnDom = new System.Windows.Forms.RadioButton();
            this.RadBtnLinq = new System.Windows.Forms.RadioButton();
            this.RichTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonTransformToHTML = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckBoxGroup
            // 
            this.CheckBoxGroup.AutoSize = true;
            this.CheckBoxGroup.Location = new System.Drawing.Point(46, 88);
            this.CheckBoxGroup.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxGroup.Name = "CheckBoxGroup";
            this.CheckBoxGroup.Size = new System.Drawing.Size(67, 23);
            this.CheckBoxGroup.TabIndex = 0;
            this.CheckBoxGroup.Text = "Group";
            this.CheckBoxGroup.UseVisualStyleBackColor = true;
            this.CheckBoxGroup.CheckedChanged += new System.EventHandler(this.CheckBoxGroup_CheckedChanged);
            // 
            // CheckBoxAreaOfThesis
            // 
            this.CheckBoxAreaOfThesis.AutoSize = true;
            this.CheckBoxAreaOfThesis.Location = new System.Drawing.Point(46, 156);
            this.CheckBoxAreaOfThesis.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxAreaOfThesis.Name = "CheckBoxAreaOfThesis";
            this.CheckBoxAreaOfThesis.Size = new System.Drawing.Size(111, 23);
            this.CheckBoxAreaOfThesis.TabIndex = 1;
            this.CheckBoxAreaOfThesis.Text = "Area of thesis";
            this.CheckBoxAreaOfThesis.UseVisualStyleBackColor = true;
            this.CheckBoxAreaOfThesis.CheckedChanged += new System.EventHandler(this.CheckBoxAreaOfThesis_CheckedChanged);
            // 
            // CheckBoxProfessor
            // 
            this.CheckBoxProfessor.AutoSize = true;
            this.CheckBoxProfessor.Location = new System.Drawing.Point(46, 225);
            this.CheckBoxProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxProfessor.Name = "CheckBoxProfessor";
            this.CheckBoxProfessor.Size = new System.Drawing.Size(86, 23);
            this.CheckBoxProfessor.TabIndex = 2;
            this.CheckBoxProfessor.Text = "Professor";
            this.CheckBoxProfessor.UseVisualStyleBackColor = true;
            this.CheckBoxProfessor.CheckedChanged += new System.EventHandler(this.CheckBoxProfessor_CheckedChanged);
            // 
            // CheckBoxSchedule
            // 
            this.CheckBoxSchedule.AutoSize = true;
            this.CheckBoxSchedule.Location = new System.Drawing.Point(46, 291);
            this.CheckBoxSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxSchedule.Name = "CheckBoxSchedule";
            this.CheckBoxSchedule.Size = new System.Drawing.Size(83, 23);
            this.CheckBoxSchedule.TabIndex = 3;
            this.CheckBoxSchedule.Text = "Schedule";
            this.CheckBoxSchedule.UseVisualStyleBackColor = true;
            this.CheckBoxSchedule.CheckedChanged += new System.EventHandler(this.CheckBoxSchedule_CheckedChanged);
            // 
            // CheckBoxStage
            // 
            this.CheckBoxStage.AutoSize = true;
            this.CheckBoxStage.Location = new System.Drawing.Point(46, 358);
            this.CheckBoxStage.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxStage.Name = "CheckBoxStage";
            this.CheckBoxStage.Size = new System.Drawing.Size(62, 23);
            this.CheckBoxStage.TabIndex = 4;
            this.CheckBoxStage.Text = "Stage";
            this.CheckBoxStage.UseVisualStyleBackColor = true;
            this.CheckBoxStage.CheckedChanged += new System.EventHandler(this.CheckBoxStage_CheckedChanged);
            // 
            // ComboBoxGroup
            // 
            this.ComboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGroup.Enabled = false;
            this.ComboBoxGroup.FormattingEnabled = true;
            this.ComboBoxGroup.Location = new System.Drawing.Point(180, 86);
            this.ComboBoxGroup.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxGroup.Name = "ComboBoxGroup";
            this.ComboBoxGroup.Size = new System.Drawing.Size(265, 27);
            this.ComboBoxGroup.TabIndex = 5;
            // 
            // ComboBoxAreaOfThesis
            // 
            this.ComboBoxAreaOfThesis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAreaOfThesis.Enabled = false;
            this.ComboBoxAreaOfThesis.FormattingEnabled = true;
            this.ComboBoxAreaOfThesis.Location = new System.Drawing.Point(180, 154);
            this.ComboBoxAreaOfThesis.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxAreaOfThesis.Name = "ComboBoxAreaOfThesis";
            this.ComboBoxAreaOfThesis.Size = new System.Drawing.Size(265, 27);
            this.ComboBoxAreaOfThesis.TabIndex = 6;
            // 
            // ComboBoxProfessor
            // 
            this.ComboBoxProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProfessor.Enabled = false;
            this.ComboBoxProfessor.FormattingEnabled = true;
            this.ComboBoxProfessor.Location = new System.Drawing.Point(180, 223);
            this.ComboBoxProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxProfessor.Name = "ComboBoxProfessor";
            this.ComboBoxProfessor.Size = new System.Drawing.Size(265, 27);
            this.ComboBoxProfessor.TabIndex = 7;
            // 
            // ComboBoxSchedule
            // 
            this.ComboBoxSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSchedule.Enabled = false;
            this.ComboBoxSchedule.FormattingEnabled = true;
            this.ComboBoxSchedule.Location = new System.Drawing.Point(180, 289);
            this.ComboBoxSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxSchedule.Name = "ComboBoxSchedule";
            this.ComboBoxSchedule.Size = new System.Drawing.Size(265, 27);
            this.ComboBoxSchedule.TabIndex = 8;
            // 
            // ComboBoxStage
            // 
            this.ComboBoxStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStage.Enabled = false;
            this.ComboBoxStage.FormattingEnabled = true;
            this.ComboBoxStage.Location = new System.Drawing.Point(180, 356);
            this.ComboBoxStage.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxStage.Name = "ComboBoxStage";
            this.ComboBoxStage.Size = new System.Drawing.Size(265, 27);
            this.ComboBoxStage.TabIndex = 9;
            // 
            // RadBtnSax
            // 
            this.RadBtnSax.AutoSize = true;
            this.RadBtnSax.Location = new System.Drawing.Point(46, 501);
            this.RadBtnSax.Margin = new System.Windows.Forms.Padding(4);
            this.RadBtnSax.Name = "RadBtnSax";
            this.RadBtnSax.Size = new System.Drawing.Size(58, 23);
            this.RadBtnSax.TabIndex = 10;
            this.RadBtnSax.TabStop = true;
            this.RadBtnSax.Text = "SAX";
            this.RadBtnSax.UseVisualStyleBackColor = true;
            // 
            // RadBtnDom
            // 
            this.RadBtnDom.AutoSize = true;
            this.RadBtnDom.Location = new System.Drawing.Point(208, 501);
            this.RadBtnDom.Margin = new System.Windows.Forms.Padding(4);
            this.RadBtnDom.Name = "RadBtnDom";
            this.RadBtnDom.Size = new System.Drawing.Size(64, 23);
            this.RadBtnDom.TabIndex = 11;
            this.RadBtnDom.TabStop = true;
            this.RadBtnDom.Text = "DOM";
            this.RadBtnDom.UseVisualStyleBackColor = true;
            // 
            // RadBtnLinq
            // 
            this.RadBtnLinq.AutoSize = true;
            this.RadBtnLinq.Location = new System.Drawing.Point(380, 501);
            this.RadBtnLinq.Margin = new System.Windows.Forms.Padding(4);
            this.RadBtnLinq.Name = "RadBtnLinq";
            this.RadBtnLinq.Size = new System.Drawing.Size(65, 23);
            this.RadBtnLinq.TabIndex = 12;
            this.RadBtnLinq.TabStop = true;
            this.RadBtnLinq.Text = "LINQ";
            this.RadBtnLinq.UseVisualStyleBackColor = true;
            // 
            // RichTextBoxDisplay
            // 
            this.RichTextBoxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBoxDisplay.Location = new System.Drawing.Point(493, 86);
            this.RichTextBoxDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.RichTextBoxDisplay.Name = "RichTextBoxDisplay";
            this.RichTextBoxDisplay.Size = new System.Drawing.Size(729, 548);
            this.RichTextBoxDisplay.TabIndex = 13;
            this.RichTextBoxDisplay.Text = "";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonSearch.Location = new System.Drawing.Point(46, 542);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(399, 42);
            this.ButtonSearch.TabIndex = 14;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonTransformToHTML
            // 
            this.ButtonTransformToHTML.Location = new System.Drawing.Point(46, 590);
            this.ButtonTransformToHTML.Name = "ButtonTransformToHTML";
            this.ButtonTransformToHTML.Size = new System.Drawing.Size(195, 44);
            this.ButtonTransformToHTML.TabIndex = 15;
            this.ButtonTransformToHTML.Text = "Transform to HTML";
            this.ButtonTransformToHTML.UseVisualStyleBackColor = true;
            this.ButtonTransformToHTML.Click += new System.EventHandler(this.ButtonTransformToHTML_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(247, 590);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(198, 44);
            this.ButtonClear.TabIndex = 16;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonTransformToHTML);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.RichTextBoxDisplay);
            this.Controls.Add(this.RadBtnLinq);
            this.Controls.Add(this.RadBtnDom);
            this.Controls.Add(this.RadBtnSax);
            this.Controls.Add(this.ComboBoxStage);
            this.Controls.Add(this.ComboBoxSchedule);
            this.Controls.Add(this.ComboBoxProfessor);
            this.Controls.Add(this.ComboBoxAreaOfThesis);
            this.Controls.Add(this.ComboBoxGroup);
            this.Controls.Add(this.CheckBoxStage);
            this.Controls.Add(this.CheckBoxSchedule);
            this.Controls.Add(this.CheckBoxProfessor);
            this.Controls.Add(this.CheckBoxAreaOfThesis);
            this.Controls.Add(this.CheckBoxGroup);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JournalOfThesis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBoxGroup;
        private System.Windows.Forms.CheckBox CheckBoxAreaOfThesis;
        private System.Windows.Forms.CheckBox CheckBoxProfessor;
        private System.Windows.Forms.CheckBox CheckBoxSchedule;
        private System.Windows.Forms.CheckBox CheckBoxStage;
        private System.Windows.Forms.ComboBox ComboBoxGroup;
        private System.Windows.Forms.ComboBox ComboBoxAreaOfThesis;
        private System.Windows.Forms.ComboBox ComboBoxProfessor;
        private System.Windows.Forms.ComboBox ComboBoxSchedule;
        private System.Windows.Forms.ComboBox ComboBoxStage;
        private System.Windows.Forms.RadioButton RadBtnSax;
        private System.Windows.Forms.RadioButton RadBtnDom;
        private System.Windows.Forms.RadioButton RadBtnLinq;
        private System.Windows.Forms.RichTextBox RichTextBoxDisplay;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonTransformToHTML;
        private System.Windows.Forms.Button ButtonClear;
    }
}

