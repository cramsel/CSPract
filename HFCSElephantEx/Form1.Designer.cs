namespace HFCSElephantEx
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
            this.LloydButton = new System.Windows.Forms.Button();
            this.LuciaButton = new System.Windows.Forms.Button();
            this.SwapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LloydButton
            // 
            this.LloydButton.Location = new System.Drawing.Point(12, 12);
            this.LloydButton.Name = "LloydButton";
            this.LloydButton.Size = new System.Drawing.Size(125, 31);
            this.LloydButton.TabIndex = 0;
            this.LloydButton.Text = "Lloyd";
            this.LloydButton.UseVisualStyleBackColor = true;
            this.LloydButton.Click += new System.EventHandler(this.LloydButton_Click);
            // 
            // LuciaButton
            // 
            this.LuciaButton.Location = new System.Drawing.Point(12, 49);
            this.LuciaButton.Name = "LuciaButton";
            this.LuciaButton.Size = new System.Drawing.Size(125, 32);
            this.LuciaButton.TabIndex = 1;
            this.LuciaButton.Text = "Lucia";
            this.LuciaButton.UseVisualStyleBackColor = true;
            this.LuciaButton.Click += new System.EventHandler(this.LuciaButton_Click);
            // 
            // SwapButton
            // 
            this.SwapButton.Location = new System.Drawing.Point(12, 87);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Size = new System.Drawing.Size(125, 30);
            this.SwapButton.TabIndex = 2;
            this.SwapButton.Text = "Swap";
            this.SwapButton.UseVisualStyleBackColor = true;
            this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 146);
            this.Controls.Add(this.SwapButton);
            this.Controls.Add(this.LuciaButton);
            this.Controls.Add(this.LloydButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LloydButton;
        private System.Windows.Forms.Button LuciaButton;
        private System.Windows.Forms.Button SwapButton;
    }
}

