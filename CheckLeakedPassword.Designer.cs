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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(13, 30);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(170, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonCheckAtPwnedPasswords
            // 
            this.buttonCheckAtPwnedPasswords.Location = new System.Drawing.Point(189, 28);
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
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SHA1:";
            // 
            // labelSHA1
            // 
            this.labelSHA1.AutoSize = true;
            this.labelSHA1.Location = new System.Drawing.Point(13, 103);
            this.labelSHA1.Name = "labelSHA1";
            this.labelSHA1.Size = new System.Drawing.Size(0, 13);
            this.labelSHA1.TabIndex = 0;
            // 
            // buttonResult
            // 
            this.buttonResult.Enabled = false;
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResult.Location = new System.Drawing.Point(105, 137);
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
            this.checkBoxHidePassword.Location = new System.Drawing.Point(13, 57);
            this.checkBoxHidePassword.Name = "checkBoxHidePassword";
            this.checkBoxHidePassword.Size = new System.Drawing.Size(97, 17);
            this.checkBoxHidePassword.TabIndex = 4;
            this.checkBoxHidePassword.Text = "Hide Password";
            this.checkBoxHidePassword.UseVisualStyleBackColor = true;
            // 
            // CheckLeakedPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 219);
            this.Controls.Add(this.checkBoxHidePassword);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonCheckAtPwnedPasswords);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelSHA1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(407, 258);
            this.MinimumSize = new System.Drawing.Size(407, 258);
            this.Name = "CheckLeakedPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Leaked Passwords";
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
    }
}

