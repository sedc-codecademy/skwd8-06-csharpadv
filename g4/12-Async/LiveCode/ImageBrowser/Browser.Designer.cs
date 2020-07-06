namespace ImageBrowser
{
    partial class Browser
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
            this.lbxAuthors = new System.Windows.Forms.ListBox();
            this.btnLoadAuthors = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlBookImages = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbxAuthors
            // 
            this.lbxAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxAuthors.FormattingEnabled = true;
            this.lbxAuthors.ItemHeight = 20;
            this.lbxAuthors.Location = new System.Drawing.Point(12, 12);
            this.lbxAuthors.Name = "lbxAuthors";
            this.lbxAuthors.Size = new System.Drawing.Size(207, 544);
            this.lbxAuthors.TabIndex = 0;
            this.lbxAuthors.SelectedIndexChanged += new System.EventHandler(this.lbxAuthors_SelectedIndexChanged);
            // 
            // btnLoadAuthors
            // 
            this.btnLoadAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadAuthors.Location = new System.Drawing.Point(1235, 12);
            this.btnLoadAuthors.Name = "btnLoadAuthors";
            this.btnLoadAuthors.Size = new System.Drawing.Size(177, 29);
            this.btnLoadAuthors.TabIndex = 1;
            this.btnLoadAuthors.Text = "Load Authors";
            this.btnLoadAuthors.UseVisualStyleBackColor = true;
            this.btnLoadAuthors.Click += new System.EventHandler(this.btnLoadAuthors_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStatus.Location = new System.Drawing.Point(226, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 2;
            // 
            // pnlBookImages
            // 
            this.pnlBookImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBookImages.AutoScroll = true;
            this.pnlBookImages.Location = new System.Drawing.Point(225, 61);
            this.pnlBookImages.Name = "pnlBookImages";
            this.pnlBookImages.Size = new System.Drawing.Size(1187, 491);
            this.pnlBookImages.TabIndex = 3;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 567);
            this.Controls.Add(this.pnlBookImages);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLoadAuthors);
            this.Controls.Add(this.lbxAuthors);
            this.Name = "Browser";
            this.Text = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAuthors;
        private System.Windows.Forms.Button btnLoadAuthors;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlBookImages;
    }
}

