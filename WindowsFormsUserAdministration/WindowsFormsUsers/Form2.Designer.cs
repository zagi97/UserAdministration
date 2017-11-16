﻿namespace WindowsFormsUsers
{
    partial class FormEditUser
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
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.lblEditUserName = new System.Windows.Forms.Label();
            this.lblEditUserID = new System.Windows.Forms.Label();
            this.lblEditName = new System.Windows.Forms.Label();
            this.inptEditName = new System.Windows.Forms.TextBox();
            this.inptEditSurname = new System.Windows.Forms.TextBox();
            this.inptEditPassword = new System.Windows.Forms.TextBox();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.lblEditPassword = new System.Windows.Forms.Label();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTitle.Location = new System.Drawing.Point(309, 55);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(133, 24);
            this.lblEditTitle.TabIndex = 0;
            this.lblEditTitle.Text = "Uredi korisnika";
            // 
            // lblEditUserName
            // 
            this.lblEditUserName.AutoSize = true;
            this.lblEditUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUserName.Location = new System.Drawing.Point(330, 79);
            this.lblEditUserName.Name = "lblEditUserName";
            this.lblEditUserName.Size = new System.Drawing.Size(74, 16);
            this.lblEditUserName.TabIndex = 1;
            this.lblEditUserName.Text = "UserName";
            // 
            // lblEditUserID
            // 
            this.lblEditUserID.AutoSize = true;
            this.lblEditUserID.Location = new System.Drawing.Point(345, 106);
            this.lblEditUserID.Name = "lblEditUserID";
            this.lblEditUserID.Size = new System.Drawing.Size(40, 13);
            this.lblEditUserID.TabIndex = 2;
            this.lblEditUserID.Text = "UserID";
            this.lblEditUserID.Visible = false;
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Location = new System.Drawing.Point(157, 145);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(24, 13);
            this.lblEditName.TabIndex = 3;
            this.lblEditName.Text = "Ime";
            // 
            // inptEditName
            // 
            this.inptEditName.Location = new System.Drawing.Point(238, 138);
            this.inptEditName.Name = "inptEditName";
            this.inptEditName.Size = new System.Drawing.Size(280, 20);
            this.inptEditName.TabIndex = 4;
            // 
            // inptEditSurname
            // 
            this.inptEditSurname.Location = new System.Drawing.Point(238, 182);
            this.inptEditSurname.Name = "inptEditSurname";
            this.inptEditSurname.Size = new System.Drawing.Size(280, 20);
            this.inptEditSurname.TabIndex = 5;
            // 
            // inptEditPassword
            // 
            this.inptEditPassword.Location = new System.Drawing.Point(238, 221);
            this.inptEditPassword.Name = "inptEditPassword";
            this.inptEditPassword.Size = new System.Drawing.Size(280, 20);
            this.inptEditPassword.TabIndex = 6;
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Location = new System.Drawing.Point(157, 188);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.Size = new System.Drawing.Size(44, 13);
            this.lblEditLastName.TabIndex = 7;
            this.lblEditLastName.Text = "Prezime";
            // 
            // lblEditPassword
            // 
            this.lblEditPassword.AutoSize = true;
            this.lblEditPassword.Location = new System.Drawing.Point(157, 228);
            this.lblEditPassword.Name = "lblEditPassword";
            this.lblEditPassword.Size = new System.Drawing.Size(44, 13);
            this.lblEditPassword.TabIndex = 8;
            this.lblEditPassword.Text = "Lozinka";
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(255, 279);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(104, 38);
            this.btnEditCancel.TabIndex = 9;
            this.btnEditCancel.Text = "ZATVORI";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(398, 279);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(102, 38);
            this.btnEditUser.TabIndex = 10;
            this.btnEditUser.Text = "SPREMI";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 447);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.lblEditPassword);
            this.Controls.Add(this.lblEditLastName);
            this.Controls.Add(this.inptEditPassword);
            this.Controls.Add(this.inptEditSurname);
            this.Controls.Add(this.inptEditName);
            this.Controls.Add(this.lblEditName);
            this.Controls.Add(this.lblEditUserID);
            this.Controls.Add(this.lblEditUserName);
            this.Controls.Add(this.lblEditTitle);
            this.Name = "FormEditUser";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditTitle;
        public System.Windows.Forms.Label lblEditUserName;
        public System.Windows.Forms.Label lblEditUserID;
        private System.Windows.Forms.Label lblEditName;
        public System.Windows.Forms.TextBox inptEditName;
        public System.Windows.Forms.TextBox inptEditSurname;
        public System.Windows.Forms.TextBox inptEditPassword;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.Label lblEditPassword;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditUser;
    }
}