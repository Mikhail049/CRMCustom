namespace CRM_Custom
{
    partial class CRMWindowLogIn
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
            this.components = new System.ComponentModel.Container();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.localDBCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(157, 118);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(60, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name";
            this.userNameLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // localDBCheckBox
            // 
            this.localDBCheckBox.AutoSize = true;
            this.localDBCheckBox.Location = new System.Drawing.Point(97, 256);
            this.localDBCheckBox.Name = "localDBCheckBox";
            this.localDBCheckBox.Size = new System.Drawing.Size(105, 17);
            this.localDBCheckBox.TabIndex = 1;
            this.localDBCheckBox.Text = "Local Data Base";
            this.localDBCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(157, 183);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(97, 145);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(190, 20);
            this.userNameBox.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(97, 212);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(190, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(136, 297);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(95, 25);
            this.logInButton.TabIndex = 5;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CRMWindowLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 391);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.localDBCheckBox);
            this.Controls.Add(this.userNameLabel);
            this.Name = "CRMWindowLogIn";
            this.Text = "CRM Custom Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.CheckBox localDBCheckBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button logInButton;
    }
}

