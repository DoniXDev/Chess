namespace Chess
{
    partial class NameInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SwichButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(34, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.Location = new System.Drawing.Point(39, 127);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(221, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Location = new System.Drawing.Point(39, 237);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(123, 32);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Login";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassTextBox
            // 
            this.PassTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassTextBox.Location = new System.Drawing.Point(39, 190);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(221, 22);
            this.PassTextBox.TabIndex = 2;
            this.PassTextBox.TextChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            this.PassTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(34, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // SwichButton
            // 
            this.SwichButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwichButton.Location = new System.Drawing.Point(168, 237);
            this.SwichButton.Name = "SwichButton";
            this.SwichButton.Size = new System.Drawing.Size(92, 32);
            this.SwichButton.TabIndex = 5;
            this.SwichButton.Text = "Register =>";
            this.SwichButton.UseVisualStyleBackColor = true;
            this.SwichButton.Click += new System.EventHandler(this.SwichButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(94, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chess";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(94, 61);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(84, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "by donix, version: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButton.Location = new System.Drawing.Point(100, 275);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 25);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.StatusLabel.Location = new System.Drawing.Point(39, 216);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 14);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(49, 136);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(202, 54);
            this.label4.TabIndex = 13;
            this.label4.Text = "Your version is up to date!\r\n   Click here to download \r\nthe lastest version of C" +
    "hess.\r\n";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NameInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SwichButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NameInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NameInput";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NameInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SwichButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label4;
    }
}