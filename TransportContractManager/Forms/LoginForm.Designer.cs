namespace TransportContractManager.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(381, 220);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(251, 20);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(381, 279);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(251, 20);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DeepSkyBlue;
            btnLogin.Location = new Point(532, 324);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(126, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(356, 331);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 5;
            label1.Text = "Chưa có tài khoản?";
            label1.Click += label1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1002, 535);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private Label label1;
    }
}
