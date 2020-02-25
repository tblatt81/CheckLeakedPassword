namespace CheckLeakedPassword
{
    partial class CheckLeakedPassword
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckLeakedPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonCheckAtPwnedPasswords = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSHA1 = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.checkBoxHidePassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumberOccurrences = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 65);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(170, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonCheckAtPwnedPasswords
            // 
            this.buttonCheckAtPwnedPasswords.Location = new System.Drawing.Point(188, 63);
            this.buttonCheckAtPwnedPasswords.Name = "buttonCheckAtPwnedPasswords";
            this.buttonCheckAtPwnedPasswords.Size = new System.Drawing.Size(190, 23);
            this.buttonCheckAtPwnedPasswords.TabIndex = 2;
            this.buttonCheckAtPwnedPasswords.Text = "Check at PwnedPasswords.com";
            this.buttonCheckAtPwnedPasswords.UseVisualStyleBackColor = true;
            this.buttonCheckAtPwnedPasswords.Click += new System.EventHandler(this.buttonCheckAtPwnedPasswords_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SHA1:";
            // 
            // labelSHA1
            // 
            this.labelSHA1.AutoSize = true;
            this.labelSHA1.Location = new System.Drawing.Point(56, 122);
            this.labelSHA1.Name = "labelSHA1";
            this.labelSHA1.Size = new System.Drawing.Size(0, 13);
            this.labelSHA1.TabIndex = 0;
            // 
            // buttonResult
            // 
            this.buttonResult.Enabled = false;
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResult.Location = new System.Drawing.Point(104, 169);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(190, 70);
            this.buttonResult.TabIndex = 3;
            this.buttonResult.UseVisualStyleBackColor = true;
            // 
            // checkBoxHidePassword
            // 
            this.checkBoxHidePassword.AutoSize = true;
            this.checkBoxHidePassword.Checked = true;
            this.checkBoxHidePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHidePassword.Location = new System.Drawing.Point(12, 92);
            this.checkBoxHidePassword.Name = "checkBoxHidePassword";
            this.checkBoxHidePassword.Size = new System.Drawing.Size(97, 17);
            this.checkBoxHidePassword.TabIndex = 4;
            this.checkBoxHidePassword.Text = "Hide Password";
            this.checkBoxHidePassword.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of occurrences:";
            // 
            // labelNumberOccurrences
            // 
            this.labelNumberOccurrences.AutoSize = true;
            this.labelNumberOccurrences.Location = new System.Drawing.Point(139, 140);
            this.labelNumberOccurrences.Name = "labelNumberOccurrences";
            this.labelNumberOccurrences.Size = new System.Drawing.Size(0, 13);
            this.labelNumberOccurrences.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total number of leaked passwords:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "555.278.657";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 33);
            this.panel1.TabIndex = 5;
            // 
            // CheckLeakedPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 251);
            this.Controls.Add(this.checkBoxHidePassword);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonCheckAtPwnedPasswords);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelNumberOccurrences);
            this.Controls.Add(this.labelSHA1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(407, 290);
            this.MinimumSize = new System.Drawing.Size(407, 290);
            this.Name = "CheckLeakedPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Leaked Passwords";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonCheckAtPwnedPasswords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSHA1;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.CheckBox checkBoxHidePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumberOccurrences;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}

