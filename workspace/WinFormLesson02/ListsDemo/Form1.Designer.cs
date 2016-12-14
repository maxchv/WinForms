namespace ListsDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(13, 13);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbStudents.Size = new System.Drawing.Size(189, 251);
            this.lbStudents.TabIndex = 0;
            this.lbStudents.SelectedValueChanged += new System.EventHandler(this.lbStudents_SelectedValueChanged);
            this.lbStudents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbStudents_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Возраст";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(286, 12);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbFirstName, "It is tool tip for field name");
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(286, 39);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tbLastName, "It is tool tip for field surname");
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(290, 106);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(99, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(286, 68);
            this.numAge.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(103, 20);
            this.numAge.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(401, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(218, 155);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(171, 109);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 10;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Red;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ToolTipTitle = "title for tooltip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 300);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStudents);
            this.Name = "Form1";
            this.Text = "Студенты";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

