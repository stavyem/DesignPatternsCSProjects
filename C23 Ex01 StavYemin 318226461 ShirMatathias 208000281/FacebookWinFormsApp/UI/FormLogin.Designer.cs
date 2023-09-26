namespace BasicFacebookFeatures.UI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBoxProfilePhoto = new System.Windows.Forms.PictureBox();
            this.buttonLoginAsDifferentUser = new System.Windows.Forms.Button();
            this.buttonLoginAsUser = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(126, 357);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(138, 22);
            this.checkBoxRememberMe.TabIndex = 1;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProfilePhoto
            // 
            this.pictureBoxProfilePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxProfilePhoto.Image = global::BasicFacebookFeatures.Properties.Resources.app_logo;
            this.pictureBoxProfilePhoto.Location = new System.Drawing.Point(44, 13);
            this.pictureBoxProfilePhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfilePhoto.Name = "pictureBoxProfilePhoto";
            this.pictureBoxProfilePhoto.Size = new System.Drawing.Size(298, 191);
            this.pictureBoxProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxProfilePhoto.TabIndex = 0;
            this.pictureBoxProfilePhoto.TabStop = false;
            // 
            // buttonLoginAsDifferentUser
            // 
            this.buttonLoginAsDifferentUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginAsDifferentUser.Location = new System.Drawing.Point(44, 287);
            this.buttonLoginAsDifferentUser.Name = "buttonLoginAsDifferentUser";
            this.buttonLoginAsDifferentUser.Size = new System.Drawing.Size(298, 65);
            this.buttonLoginAsDifferentUser.TabIndex = 7;
            this.buttonLoginAsDifferentUser.Text = "Login As Different User";
            this.buttonLoginAsDifferentUser.UseVisualStyleBackColor = true;
            this.buttonLoginAsDifferentUser.Visible = false;
            this.buttonLoginAsDifferentUser.Click += new System.EventHandler(this.buttonLoginAsDifferentUser_Click);
            // 
            // buttonLoginAsUser
            // 
            this.buttonLoginAsUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLoginAsUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginAsUser.Location = new System.Drawing.Point(44, 222);
            this.buttonLoginAsUser.Name = "buttonLoginAsUser";
            this.buttonLoginAsUser.Size = new System.Drawing.Size(298, 51);
            this.buttonLoginAsUser.TabIndex = 6;
            this.buttonLoginAsUser.Text = "Login As";
            this.buttonLoginAsUser.UseVisualStyleBackColor = false;
            this.buttonLoginAsUser.Visible = false;
            this.buttonLoginAsUser.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(44, 287);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(298, 65);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(398, 403);
            this.Controls.Add(this.buttonLoginAsDifferentUser);
            this.Controls.Add(this.buttonLoginAsUser);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxProfilePhoto);
            this.Controls.Add(this.checkBoxRememberMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Login";
            this.VisibleChanged += new System.EventHandler(this.FormLogin_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.PictureBox pictureBoxProfilePhoto;
        private System.Windows.Forms.Button buttonLoginAsDifferentUser;
        private System.Windows.Forms.Button buttonLoginAsUser;
        private System.Windows.Forms.Button buttonLogin;
    }
}