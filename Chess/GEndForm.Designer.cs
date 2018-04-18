namespace Chess
{
    partial class GEndForm
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
            this.WLLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LPLabel = new System.Windows.Forms.Label();
            this.GoldLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WLLabel
            // 
            this.WLLabel.AutoSize = true;
            this.WLLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WLLabel.ForeColor = System.Drawing.Color.Black;
            this.WLLabel.Location = new System.Drawing.Point(12, 29);
            this.WLLabel.Name = "WLLabel";
            this.WLLabel.Size = new System.Drawing.Size(87, 40);
            this.WLLabel.TabIndex = 0;
            this.WLLabel.Text = "WIN";
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButton.Location = new System.Drawing.Point(12, 94);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 27);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Return";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LPLabel
            // 
            this.LPLabel.AutoSize = true;
            this.LPLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LPLabel.Location = new System.Drawing.Point(92, 27);
            this.LPLabel.Name = "LPLabel";
            this.LPLabel.Size = new System.Drawing.Size(58, 24);
            this.LPLabel.TabIndex = 4;
            this.LPLabel.Text = "|+20|";
            // 
            // GoldLabel
            // 
            this.GoldLabel.AutoSize = true;
            this.GoldLabel.BackColor = System.Drawing.Color.White;
            this.GoldLabel.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldLabel.ForeColor = System.Drawing.Color.Gold;
            this.GoldLabel.Location = new System.Drawing.Point(153, 35);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(85, 25);
            this.GoldLabel.TabIndex = 5;
            this.GoldLabel.Text = "+10 gold";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(136, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(0, 66);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(250, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "_________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(250, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "_________________________________________________";
            // 
            // GEndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(250, 135);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoldLabel);
            this.Controls.Add(this.LPLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.WLLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GEndForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GEndForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WLLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label LPLabel;
        private System.Windows.Forms.Label GoldLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}