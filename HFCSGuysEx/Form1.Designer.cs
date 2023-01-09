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
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.give10Button = new System.Windows.Forms.Button();
            this.receive5Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeNameLabel
            // 
            this.joeNameLabel.AutoSize = true;
            this.joeNameLabel.Location = new System.Drawing.Point(9, 9);
            this.joeNameLabel.Name = "joeNameLabel";
            this.joeNameLabel.Size = new System.Drawing.Size(0, 13);
            this.joeNameLabel.TabIndex = 0;
            // 
            // bobNameLabel
            // 
            this.bobNameLabel.AutoSize = true;
            this.bobNameLabel.Location = new System.Drawing.Point(9, 58);
            this.bobNameLabel.Name = "bobNameLabel";
            this.bobNameLabel.Size = new System.Drawing.Size(0, 13);
            this.bobNameLabel.TabIndex = 1;
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(12, 109);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(0, 13);
            this.bankCashLabel.TabIndex = 2;
            // 
            // give10Button
            // 
            this.give10Button.Location = new System.Drawing.Point(12, 169);
            this.give10Button.Name = "give10Button";
            this.give10Button.Size = new System.Drawing.Size(148, 58);
            this.give10Button.TabIndex = 3;
            this.give10Button.Text = "Give $10 to Joe";
            this.give10Button.UseVisualStyleBackColor = true;
            this.give10Button.Click += new System.EventHandler(this.give10Button_Click);
            // 
            // receive5Button
            // 
            this.receive5Button.Location = new System.Drawing.Point(187, 169);
            this.receive5Button.Name = "receive5Button";
            this.receive5Button.Size = new System.Drawing.Size(148, 58);
            this.receive5Button.TabIndex = 4;
            this.receive5Button.Text = "Receive $5 from Bob";
            this.receive5Button.UseVisualStyleBackColor = true;
            this.receive5Button.Click += new System.EventHandler(this.receive5Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 239);
            this.Controls.Add(this.receive5Button);
            this.Controls.Add(this.give10Button);
            this.Controls.Add(this.bankCashLabel);
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
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button give10Button;
        private System.Windows.Forms.Button receive5Button;
    }
}

