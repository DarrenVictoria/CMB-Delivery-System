namespace CMB_Delivery_Management
{
    partial class LoginUser
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
            this.b_forgotpassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_rememberme = new System.Windows.Forms.CheckBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_forgotpassword
            // 
            this.b_forgotpassword.BackColor = System.Drawing.Color.White;
            this.b_forgotpassword.FlatAppearance.BorderSize = 0;
            this.b_forgotpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_forgotpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_forgotpassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.b_forgotpassword.Location = new System.Drawing.Point(306, 429);
            this.b_forgotpassword.Name = "b_forgotpassword";
            this.b_forgotpassword.Size = new System.Drawing.Size(195, 41);
            this.b_forgotpassword.TabIndex = 23;
            this.b_forgotpassword.Text = "Forgot password?";
            this.b_forgotpassword.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Location = new System.Drawing.Point(50, 303);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(451, 22);
            this.tb_password.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Username";
            // 
            // cb_rememberme
            // 
            this.cb_rememberme.AutoSize = true;
            this.cb_rememberme.Location = new System.Drawing.Point(51, 439);
            this.cb_rememberme.Name = "cb_rememberme";
            this.cb_rememberme.Size = new System.Drawing.Size(119, 20);
            this.cb_rememberme.TabIndex = 19;
            this.cb_rememberme.Text = "Remember me";
            this.cb_rememberme.UseVisualStyleBackColor = true;
            // 
            // tb_username
            // 
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Location = new System.Drawing.Point(49, 239);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(452, 22);
            this.tb_username.TabIndex = 18;
           
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.RoyalBlue;
            this.b_login.FlatAppearance.BorderSize = 0;
            this.b_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_login.ForeColor = System.Drawing.Color.White;
            this.b_login.Location = new System.Drawing.Point(127, 524);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(334, 46);
            this.b_login.TabIndex = 17;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome to CMB Baggage Delivery";
           
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 642);
            this.Controls.Add(this.b_forgotpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_rememberme);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginUser";
            this.Text = "LoginUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_forgotpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_rememberme;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}