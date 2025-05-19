namespace TransportContractManager.Forms
{
    partial class RegisterForm
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(382, 231);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(265, 20);
            txtUsername.TabIndex = 3;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            txtUsername.MouseDown += txtUsername_Down;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.ForeColor = Color.Black;
            txtFullName.Location = new Point(382, 169);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(265, 20);
            txtFullName.TabIndex = 1;
            txtFullName.Enter += txtFullName_Enter;
            txtFullName.Leave += txtFullName_Leave;
            txtFullName.MouseDown += xtFullName_MouseDown;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(382, 290);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(265, 20);
            txtPassword.TabIndex = 5;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            txtPassword.MouseDown += txtPassword_Down;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Location = new Point(382, 360);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(265, 20);
            txtConfirmPassword.TabIndex = 7;
            txtConfirmPassword.Enter += txtConfirmPassword_Enter;
            txtConfirmPassword.Leave += txtConfirmPassword_Leave;
            txtConfirmPassword.MouseDown += txtConfirmPassword_Down;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DeepSkyBlue;
            btnRegister.Location = new Point(405, 411);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(214, 35);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1002, 535);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnRegister);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
    }
}
