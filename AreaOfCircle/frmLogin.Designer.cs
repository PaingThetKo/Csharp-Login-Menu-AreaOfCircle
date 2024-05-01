namespace AreaOfCircle
{
    partial class frmLogin
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
            lblUname = new Label();
            txtUname = new TextBox();
            txtPass = new TextBox();
            lblPass = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUname
            // 
            lblUname.AutoSize = true;
            lblUname.Location = new Point(40, 30);
            lblUname.Name = "lblUname";
            lblUname.Size = new Size(82, 20);
            lblUname.TabIndex = 0;
            lblUname.Text = "User Name";
            // 
            // txtUname
            // 
            txtUname.Location = new Point(139, 30);
            txtUname.Name = "txtUname";
            txtUname.Size = new Size(125, 27);
            txtUname.TabIndex = 1;
            txtUname.KeyDown += txtUname_KeyDown;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(139, 82);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(125, 27);
            txtPass.TabIndex = 3;
            txtPass.KeyDown += txtPass_KeyDown;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(40, 82);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(70, 20);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(69, 142);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 238);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(txtUname);
            Controls.Add(lblUname);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUname;
        private TextBox txtUname;
        private TextBox txtPass;
        private Label lblPass;
        private Button btnLogin;
    }
}