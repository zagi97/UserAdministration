namespace WindowsFormsUsers
{
    partial class Form4
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
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddSurname = new System.Windows.Forms.Label();
            this.lblAddUsername = new System.Windows.Forms.Label();
            this.lblAddPassword = new System.Windows.Forms.Label();
            this.inptAddName = new System.Windows.Forms.TextBox();
            this.inptAddSurname = new System.Windows.Forms.TextBox();
            this.inptAddUsername = new System.Windows.Forms.TextBox();
            this.inptAddPassword = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj korisnika";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(77, 113);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(24, 13);
            this.lblAddName.TabIndex = 1;
            this.lblAddName.Text = "Ime";
            // 
            // lblAddSurname
            // 
            this.lblAddSurname.AutoSize = true;
            this.lblAddSurname.Location = new System.Drawing.Point(77, 153);
            this.lblAddSurname.Name = "lblAddSurname";
            this.lblAddSurname.Size = new System.Drawing.Size(44, 13);
            this.lblAddSurname.TabIndex = 2;
            this.lblAddSurname.Text = "Prezime";
            // 
            // lblAddUsername
            // 
            this.lblAddUsername.AutoSize = true;
            this.lblAddUsername.Location = new System.Drawing.Point(77, 188);
            this.lblAddUsername.Name = "lblAddUsername";
            this.lblAddUsername.Size = new System.Drawing.Size(75, 13);
            this.lblAddUsername.TabIndex = 3;
            this.lblAddUsername.Text = "Korisničko ime";
            // 
            // lblAddPassword
            // 
            this.lblAddPassword.AutoSize = true;
            this.lblAddPassword.Location = new System.Drawing.Point(77, 228);
            this.lblAddPassword.Name = "lblAddPassword";
            this.lblAddPassword.Size = new System.Drawing.Size(44, 13);
            this.lblAddPassword.TabIndex = 4;
            this.lblAddPassword.Text = "Lozinka";
            // 
            // inptAddName
            // 
            this.inptAddName.Location = new System.Drawing.Point(174, 113);
            this.inptAddName.Name = "inptAddName";
            this.inptAddName.Size = new System.Drawing.Size(228, 20);
            this.inptAddName.TabIndex = 5;
            // 
            // inptAddSurname
            // 
            this.inptAddSurname.Location = new System.Drawing.Point(174, 150);
            this.inptAddSurname.Name = "inptAddSurname";
            this.inptAddSurname.Size = new System.Drawing.Size(228, 20);
            this.inptAddSurname.TabIndex = 6;
            // 
            // inptAddUsername
            // 
            this.inptAddUsername.Location = new System.Drawing.Point(174, 185);
            this.inptAddUsername.Name = "inptAddUsername";
            this.inptAddUsername.Size = new System.Drawing.Size(228, 20);
            this.inptAddUsername.TabIndex = 7;
            // 
            // inptAddPassword
            // 
            this.inptAddPassword.Location = new System.Drawing.Point(174, 228);
            this.inptAddPassword.Name = "inptAddPassword";
            this.inptAddPassword.Size = new System.Drawing.Size(228, 20);
            this.inptAddPassword.TabIndex = 8;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(202, 280);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(156, 60);
            this.btnAddUser.TabIndex = 9;
            this.btnAddUser.Text = "Dodaj korisnika";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 375);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.inptAddPassword);
            this.Controls.Add(this.inptAddUsername);
            this.Controls.Add(this.inptAddSurname);
            this.Controls.Add(this.inptAddName);
            this.Controls.Add(this.lblAddPassword);
            this.Controls.Add(this.lblAddUsername);
            this.Controls.Add(this.lblAddSurname);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddSurname;
        private System.Windows.Forms.Label lblAddUsername;
        private System.Windows.Forms.Label lblAddPassword;
        private System.Windows.Forms.TextBox inptAddName;
        private System.Windows.Forms.TextBox inptAddSurname;
        private System.Windows.Forms.TextBox inptAddUsername;
        private System.Windows.Forms.TextBox inptAddPassword;
        private System.Windows.Forms.Button btnAddUser;
    }
}