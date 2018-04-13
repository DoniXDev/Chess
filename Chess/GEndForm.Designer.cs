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
            this.SuspendLayout();
            // 
            // WLLabel
            // 
            this.WLLabel.AutoSize = true;
            this.WLLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WLLabel.Location = new System.Drawing.Point(52, 9);
            this.WLLabel.Name = "WLLabel";
            this.WLLabel.Size = new System.Drawing.Size(87, 40);
            this.WLLabel.TabIndex = 0;
            this.WLLabel.Text = "WIN";
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButton.Location = new System.Drawing.Point(71, 100);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 27);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Play again";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LPLabel
            // 
            this.LPLabel.AutoSize = true;
            this.LPLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LPLabel.Location = new System.Drawing.Point(150, 11);
            this.LPLabel.Name = "LPLabel";
            this.LPLabel.Size = new System.Drawing.Size(58, 24);
            this.LPLabel.TabIndex = 4;
            this.LPLabel.Text = "|+20|";
            // 
            // GoldLabel
            // 
            this.GoldLabel.AutoSize = true;
            this.GoldLabel.BackColor = System.Drawing.Color.White;
            this.GoldLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoldLabel.ForeColor = System.Drawing.Color.Gold;
            this.GoldLabel.Location = new System.Drawing.Point(75, 61);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(96, 24);
            this.GoldLabel.TabIndex = 5;
            this.GoldLabel.Text = "+ 10 gold";
            // 
            // GEndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(250, 135);
            this.ControlBox = false;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
    }
}