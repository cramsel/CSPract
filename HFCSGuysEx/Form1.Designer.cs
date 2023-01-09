namespace HFCSGuysEx
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
            this.joeNameLabel = new System.Windows.Forms.Label();
            this.bobNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // joeNameLabel
            // 
            this.joeNameLabel.AutoSize = true;
            this.joeNameLabel.Location = new System.Drawing.Point(12, 9);
            this.joeNameLabel.Name = "joeNameLabel";
            this.joeNameLabel.Size = new System.Drawing.Size(35, 13);
            this.joeNameLabel.TabIndex = 0;
            this.joeNameLabel.Text = "joeNameLabel";
            // 
            // bobNameLabel
            // 
            this.bobNameLabel.AutoSize = true;
            this.bobNameLabel.Location = new System.Drawing.Point(15, 58);
            this.bobNameLabel.Name = "bobNameLabel";
            this.bobNameLabel.Size = new System.Drawing.Size(35, 13);
            this.bobNameLabel.TabIndex = 1;
            this.bobNameLabel.Text = "bobNameLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 239);
            this.Controls.Add(this.bobNameLabel);
            this.Controls.Add(this.joeNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joeNameLabel;
        private System.Windows.Forms.Label bobNameLabel;
    }
}

