namespace Chess
{
    partial class MainForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayerOneSakkL = new System.Windows.Forms.Label();
            this.PlayerOneNameL = new System.Windows.Forms.Label();
            this.PlayerOneUnitsP = new System.Windows.Forms.Panel();
            this.PlayerTwoUnitsP = new System.Windows.Forms.Panel();
            this.PlayerTwoNameL = new System.Windows.Forms.Label();
            this.PlayerTwoSakkL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PlayerOneELOLabel = new System.Windows.Forms.Label();
            this.PlayerOneELORankLabel = new System.Windows.Forms.Label();
            this.PlayerTwoELORankLabel = new System.Windows.Forms.Label();
            this.PlayerTwoELOLabel = new System.Windows.Forms.Label();
            this.StatusBAR = new System.Windows.Forms.TextBox();
            this.Screen.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButton.Location = new System.Drawing.Point(8, 6);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartButton.Location = new System.Drawing.Point(8, 37);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(97, 25);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Play";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Screen
            // 
            this.Screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Screen.Controls.Add(this.label2);
            this.Screen.Font = new System.Drawing.Font("MS Outlook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Screen.Location = new System.Drawing.Point(28, 92);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(211, 211);
            this.Screen.TabIndex = 0;
            this.Screen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Screen_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-26, 3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(17, 144);
            this.label2.TabIndex = 7;
            this.label2.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.richTextBox1.Location = new System.Drawing.Point(406, -2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(229, 334);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 308);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(204, 11);
            this.label1.TabIndex = 6;
            this.label1.Text = "A       B      C       D      E       F       G       H  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(13, 195);
            this.label3.TabIndex = 7;
            this.label3.Text = "1\r\n\r\n2\r\n\r\n3\r\n\r\n4\r\n\r\n5\r\n\r\n6\r\n\r\n7\r\n\r\n8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(190, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chess";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(266, 39);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(84, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "by donix, version: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(1, 62);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(405, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "________________________________________________________________________________";
            // 
            // PlayerOneSakkL
            // 
            this.PlayerOneSakkL.AutoSize = true;
            this.PlayerOneSakkL.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerOneSakkL.ForeColor = System.Drawing.Color.Black;
            this.PlayerOneSakkL.Location = new System.Drawing.Point(322, 170);
            this.PlayerOneSakkL.Name = "PlayerOneSakkL";
            this.PlayerOneSakkL.Size = new System.Drawing.Size(64, 22);
            this.PlayerOneSakkL.TabIndex = 11;
            this.PlayerOneSakkL.Text = "SAKK!";
            this.PlayerOneSakkL.Visible = false;
            // 
            // PlayerOneNameL
            // 
            this.PlayerOneNameL.AutoSize = true;
            this.PlayerOneNameL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerOneNameL.ForeColor = System.Drawing.Color.Black;
            this.PlayerOneNameL.Location = new System.Drawing.Point(258, 90);
            this.PlayerOneNameL.Name = "PlayerOneNameL";
            this.PlayerOneNameL.Size = new System.Drawing.Size(72, 22);
            this.PlayerOneNameL.TabIndex = 12;
            this.PlayerOneNameL.Text = "player1";
            this.PlayerOneNameL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerOneNameL.Visible = false;
            // 
            // PlayerOneUnitsP
            // 
            this.PlayerOneUnitsP.ForeColor = System.Drawing.Color.Black;
            this.PlayerOneUnitsP.Location = new System.Drawing.Point(259, 118);
            this.PlayerOneUnitsP.Name = "PlayerOneUnitsP";
            this.PlayerOneUnitsP.Size = new System.Drawing.Size(131, 27);
            this.PlayerOneUnitsP.TabIndex = 13;
            // 
            // PlayerTwoUnitsP
            // 
            this.PlayerTwoUnitsP.ForeColor = System.Drawing.Color.Black;
            this.PlayerTwoUnitsP.Location = new System.Drawing.Point(259, 246);
            this.PlayerTwoUnitsP.Name = "PlayerTwoUnitsP";
            this.PlayerTwoUnitsP.Size = new System.Drawing.Size(131, 27);
            this.PlayerTwoUnitsP.TabIndex = 16;
            // 
            // PlayerTwoNameL
            // 
            this.PlayerTwoNameL.AutoSize = true;
            this.PlayerTwoNameL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerTwoNameL.ForeColor = System.Drawing.Color.Black;
            this.PlayerTwoNameL.Location = new System.Drawing.Point(257, 219);
            this.PlayerTwoNameL.Name = "PlayerTwoNameL";
            this.PlayerTwoNameL.Size = new System.Drawing.Size(72, 22);
            this.PlayerTwoNameL.TabIndex = 15;
            this.PlayerTwoNameL.Text = "player2";
            this.PlayerTwoNameL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerTwoNameL.Visible = false;
            // 
            // PlayerTwoSakkL
            // 
            this.PlayerTwoSakkL.AutoSize = true;
            this.PlayerTwoSakkL.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerTwoSakkL.ForeColor = System.Drawing.Color.Black;
            this.PlayerTwoSakkL.Location = new System.Drawing.Point(322, 297);
            this.PlayerTwoSakkL.Name = "PlayerTwoSakkL";
            this.PlayerTwoSakkL.Size = new System.Drawing.Size(64, 22);
            this.PlayerTwoSakkL.TabIndex = 14;
            this.PlayerTwoSakkL.Text = "SAKK!";
            this.PlayerTwoSakkL.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(250, 190);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(145, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "____________________________";
            // 
            // PlayerOneELOLabel
            // 
            this.PlayerOneELOLabel.AutoSize = true;
            this.PlayerOneELOLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerOneELOLabel.ForeColor = System.Drawing.Color.Black;
            this.PlayerOneELOLabel.Location = new System.Drawing.Point(260, 149);
            this.PlayerOneELOLabel.Name = "PlayerOneELOLabel";
            this.PlayerOneELOLabel.Size = new System.Drawing.Size(43, 22);
            this.PlayerOneELOLabel.TabIndex = 18;
            this.PlayerOneELOLabel.Text = "999";
            this.PlayerOneELOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerOneELOLabel.Visible = false;
            // 
            // PlayerOneELORankLabel
            // 
            this.PlayerOneELORankLabel.AutoSize = true;
            this.PlayerOneELORankLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerOneELORankLabel.ForeColor = System.Drawing.Color.Black;
            this.PlayerOneELORankLabel.Location = new System.Drawing.Point(303, 148);
            this.PlayerOneELORankLabel.Name = "PlayerOneELORankLabel";
            this.PlayerOneELORankLabel.Size = new System.Drawing.Size(23, 14);
            this.PlayerOneELORankLabel.TabIndex = 19;
            this.PlayerOneELORankLabel.Text = "|#1|";
            this.PlayerOneELORankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerOneELORankLabel.Visible = false;
            // 
            // PlayerTwoELORankLabel
            // 
            this.PlayerTwoELORankLabel.AutoSize = true;
            this.PlayerTwoELORankLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerTwoELORankLabel.ForeColor = System.Drawing.Color.Black;
            this.PlayerTwoELORankLabel.Location = new System.Drawing.Point(303, 275);
            this.PlayerTwoELORankLabel.Name = "PlayerTwoELORankLabel";
            this.PlayerTwoELORankLabel.Size = new System.Drawing.Size(23, 14);
            this.PlayerTwoELORankLabel.TabIndex = 21;
            this.PlayerTwoELORankLabel.Text = "|#1|";
            this.PlayerTwoELORankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerTwoELORankLabel.Visible = false;
            // 
            // PlayerTwoELOLabel
            // 
            this.PlayerTwoELOLabel.AutoSize = true;
            this.PlayerTwoELOLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerTwoELOLabel.ForeColor = System.Drawing.Color.Black;
            this.PlayerTwoELOLabel.Location = new System.Drawing.Point(260, 276);
            this.PlayerTwoELOLabel.Name = "PlayerTwoELOLabel";
            this.PlayerTwoELOLabel.Size = new System.Drawing.Size(43, 22);
            this.PlayerTwoELOLabel.TabIndex = 20;
            this.PlayerTwoELOLabel.Text = "999";
            this.PlayerTwoELOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerTwoELOLabel.Visible = false;
            // 
            // StatusBAR
            // 
            this.StatusBAR.BackColor = System.Drawing.Color.White;
            this.StatusBAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusBAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatusBAR.Font = new System.Drawing.Font("Candara", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusBAR.Location = new System.Drawing.Point(9, 302);
            this.StatusBAR.MaxLength = 20;
            this.StatusBAR.Name = "StatusBAR";
            this.StatusBAR.ReadOnly = true;
            this.StatusBAR.Size = new System.Drawing.Size(20, 18);
            this.StatusBAR.TabIndex = 23;
            this.StatusBAR.TabStop = false;
            this.StatusBAR.Text = "()";
            this.StatusBAR.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(631, 332);
            this.Controls.Add(this.StatusBAR);
            this.Controls.Add(this.PlayerTwoELORankLabel);
            this.Controls.Add(this.PlayerTwoELOLabel);
            this.Controls.Add(this.PlayerOneELORankLabel);
            this.Controls.Add(this.PlayerOneELOLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PlayerTwoUnitsP);
            this.Controls.Add(this.PlayerTwoNameL);
            this.Controls.Add(this.PlayerOneUnitsP);
            this.Controls.Add(this.PlayerTwoSakkL);
            this.Controls.Add(this.PlayerOneNameL);
            this.Controls.Add(this.PlayerOneSakkL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Screen);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.NewForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.Screen.ResumeLayout(false);
            this.Screen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PlayerOneSakkL;
        private System.Windows.Forms.Label PlayerOneNameL;
        private System.Windows.Forms.Panel PlayerOneUnitsP;
        private System.Windows.Forms.Panel PlayerTwoUnitsP;
        private System.Windows.Forms.Label PlayerTwoNameL;
        private System.Windows.Forms.Label PlayerTwoSakkL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PlayerOneELOLabel;
        private System.Windows.Forms.Label PlayerOneELORankLabel;
        private System.Windows.Forms.Label PlayerTwoELORankLabel;
        private System.Windows.Forms.Label PlayerTwoELOLabel;
        private System.Windows.Forms.TextBox StatusBAR;
    }
}