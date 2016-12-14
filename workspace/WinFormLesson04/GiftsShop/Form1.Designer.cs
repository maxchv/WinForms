namespace GiftsShop
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
            this.listBoxGifts = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxGifts
            // 
            this.listBoxGifts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxGifts.FormattingEnabled = true;
            this.listBoxGifts.Location = new System.Drawing.Point(13, 13);
            this.listBoxGifts.Name = "listBoxGifts";
            this.listBoxGifts.Size = new System.Drawing.Size(338, 264);
            this.listBoxGifts.TabIndex = 0;
            this.listBoxGifts.SelectedIndexChanged += new System.EventHandler(this.listBoxGifts_SelectedIndexChanged);
            this.listBoxGifts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxGifts_MouseDoubleClick);
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.Location = new System.Drawing.Point(276, 296);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 331);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBoxGifts);
            this.Name = "Form1";
            this.Text = "Gifts Shop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGifts;
        private System.Windows.Forms.Button button_add;
    }
}

