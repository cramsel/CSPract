namespace HFCSMileReimburseEx
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
            this.StartMilesLabel = new System.Windows.Forms.Label();
            this.EndMilesLabel = new System.Windows.Forms.Label();
            this.StartMilesCounter = new System.Windows.Forms.NumericUpDown();
            this.EndMilesCounter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountOwedLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartMilesCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndMilesCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // StartMilesLabel
            // 
            this.StartMilesLabel.AutoSize = true;
            this.StartMilesLabel.Location = new System.Drawing.Point(109, 31);
            this.StartMilesLabel.Name = "StartMilesLabel";
            this.StartMilesLabel.Size = new System.Drawing.Size(83, 13);
            this.StartMilesLabel.TabIndex = 0;
            this.StartMilesLabel.Text = "Starting Mileage";
            // 
            // EndMilesLabel
            // 
            this.EndMilesLabel.AutoSize = true;
            this.EndMilesLabel.Location = new System.Drawing.Point(112, 70);
            this.EndMilesLabel.Name = "EndMilesLabel";
            this.EndMilesLabel.Size = new System.Drawing.Size(80, 13);
            this.EndMilesLabel.TabIndex = 1;
            this.EndMilesLabel.Text = "Ending Mileage";
            // 
            // StartMilesCounter
            // 
            this.StartMilesCounter.Location = new System.Drawing.Point(218, 29);
            this.StartMilesCounter.Name = "StartMilesCounter";
            this.StartMilesCounter.Size = new System.Drawing.Size(120, 20);
            this.StartMilesCounter.TabIndex = 2;
            // 
            // EndMilesCounter
            // 
            this.EndMilesCounter.Location = new System.Drawing.Point(218, 68);
            this.EndMilesCounter.Name = "EndMilesCounter";
            this.EndMilesCounter.Size = new System.Drawing.Size(120, 20);
            this.EndMilesCounter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount Owed:";
            // 
            // AmountOwedLabel
            // 
            this.AmountOwedLabel.AutoSize = true;
            this.AmountOwedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountOwedLabel.Location = new System.Drawing.Point(214, 116);
            this.AmountOwedLabel.Name = "AmountOwedLabel";
            this.AmountOwedLabel.Size = new System.Drawing.Size(57, 20);
            this.AmountOwedLabel.TabIndex = 5;
            this.AmountOwedLabel.Text = "label2";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(170, 161);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 214);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AmountOwedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndMilesCounter);
            this.Controls.Add(this.StartMilesCounter);
            this.Controls.Add(this.EndMilesLabel);
            this.Controls.Add(this.StartMilesLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StartMilesCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndMilesCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartMilesLabel;
        private System.Windows.Forms.Label EndMilesLabel;
        private System.Windows.Forms.NumericUpDown StartMilesCounter;
        private System.Windows.Forms.NumericUpDown EndMilesCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AmountOwedLabel;
        private System.Windows.Forms.Button CalculateButton;
    }
}

