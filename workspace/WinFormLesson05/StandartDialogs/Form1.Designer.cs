namespace StandartDialogs
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
            this.button1 = new System.Windows.Forms.Button();
            this.label_color = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label_font = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label_dir = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label_file = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_color
            // 
            this.label_color.BackColor = System.Drawing.SystemColors.Control;
            this.label_color.Location = new System.Drawing.Point(35, 17);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(36, 39);
            this.label_color.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Choose Font";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_font
            // 
            this.label_font.AutoSize = true;
            this.label_font.Location = new System.Drawing.Point(36, 81);
            this.label_font.Name = "label_font";
            this.label_font.Size = new System.Drawing.Size(131, 13);
            this.label_font.TabIndex = 3;
            this.label_font.Text = "Lorem ipsum dolor sit amet";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(265, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Choose dir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_dir
            // 
            this.label_dir.AutoSize = true;
            this.label_dir.Location = new System.Drawing.Point(39, 131);
            this.label_dir.Name = "label_dir";
            this.label_dir.Size = new System.Drawing.Size(0, 13);
            this.label_dir.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "OpenFile";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(265, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "SaveFile";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label_file
            // 
            this.label_file.AutoSize = true;
            this.label_file.Location = new System.Drawing.Point(39, 179);
            this.label_file.Name = "label_file";
            this.label_file.Size = new System.Drawing.Size(0, 13);
            this.label_file.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileItem,
            this.toolStripSeparator1,
            this.openFolderItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 76);
            // 
            // openFileItem
            // 
            this.openFileItem.Name = "openFileItem";
            this.openFileItem.Size = new System.Drawing.Size(127, 22);
            this.openFileItem.Text = "Open File";
            this.openFileItem.Click += new System.EventHandler(this.openFileItem_Click);
            // 
            // openFolderItem
            // 
            this.openFolderItem.Name = "openFolderItem";
            this.openFolderItem.Size = new System.Drawing.Size(127, 22);
            this.openFolderItem.Text = "Open Folder";
            this.openFolderItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 285);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_file);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label_dir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label_font);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_font;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_dir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label_file;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openFolderItem;
    }
}

