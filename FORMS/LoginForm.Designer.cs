namespace Library_Management_System.FORMS
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.label_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.pictureBoxPass);
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.textBox_username);
            this.panel1.Controls.Add(this.pictureBoxUser);
            this.panel1.Controls.Add(this.label_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.DarkOrange;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_login.Location = new System.Drawing.Point(29, 321);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(436, 57);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.BackColor = System.Drawing.Color.Green;
            this.pictureBoxPass.Location = new System.Drawing.Point(29, 234);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(44, 44);
            this.pictureBoxPass.TabIndex = 5;
            this.pictureBoxPass.TabStop = false;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox_password.Location = new System.Drawing.Point(79, 234);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(386, 44);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox_username.Location = new System.Drawing.Point(79, 145);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(386, 44);
            this.textBox_username.TabIndex = 3;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.Green;
            this.pictureBoxUser.Location = new System.Drawing.Point(29, 145);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(44, 44);
            this.pictureBoxUser.TabIndex = 2;
            this.pictureBoxUser.TabStop = false;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.DarkOrange;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_close.Location = new System.Drawing.Point(464, 9);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(24, 22);
            this.label_close.TabIndex = 1;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label1;
    }
}