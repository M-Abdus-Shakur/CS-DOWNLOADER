namespace CS_DOWNLOADER
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
            this.Download_BTN = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.mb_label = new System.Windows.Forms.Label();
            this.p_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Download_BTN
            // 
            this.Download_BTN.Location = new System.Drawing.Point(281, 148);
            this.Download_BTN.Name = "Download_BTN";
            this.Download_BTN.Size = new System.Drawing.Size(75, 23);
            this.Download_BTN.TabIndex = 0;
            this.Download_BTN.Text = "Download";
            this.Download_BTN.UseVisualStyleBackColor = true;
            this.Download_BTN.Click += new System.EventHandler(this.Download_BTN_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 256);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(626, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // mb_label
            // 
            this.mb_label.AutoSize = true;
            this.mb_label.Location = new System.Drawing.Point(300, 311);
            this.mb_label.Name = "mb_label";
            this.mb_label.Size = new System.Drawing.Size(26, 13);
            this.mb_label.TabIndex = 2;
            this.mb_label.Text = "MB-";
            // 
            // p_value
            // 
            this.p_value.AutoSize = true;
            this.p_value.Location = new System.Drawing.Point(300, 228);
            this.p_value.Name = "p_value";
            this.p_value.Size = new System.Drawing.Size(23, 13);
            this.p_value.TabIndex = 3;
            this.p_value.Text = "%%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 362);
            this.Controls.Add(this.p_value);
            this.Controls.Add(this.mb_label);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Download_BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Download_BTN;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label mb_label;
        private System.Windows.Forms.Label p_value;
    }
}

