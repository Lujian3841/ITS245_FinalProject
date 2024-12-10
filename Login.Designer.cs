namespace ITS245_FinalProject
{
    partial class Login
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
            this.btnSubmitLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSelPat = new System.Windows.Forms.Button();
            this.btnFamily = new System.Windows.Forms.Button();
            this.btnPatientDem = new System.Windows.Forms.Button();
            this.btnGenHist = new System.Windows.Forms.Button();
            this.btnAllergy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmitLogin
            // 
            this.btnSubmitLogin.Location = new System.Drawing.Point(536, 314);
            this.btnSubmitLogin.Name = "btnSubmitLogin";
            this.btnSubmitLogin.Size = new System.Drawing.Size(153, 44);
            this.btnSubmitLogin.TabIndex = 18;
            this.btnSubmitLogin.Text = "Submit Credentials";
            this.btnSubmitLogin.UseVisualStyleBackColor = true;
            this.btnSubmitLogin.Click += new System.EventHandler(this.btnSubmitLogin_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 51);
            this.label4.TabIndex = 16;
            this.label4.Text = "User Login";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(268, 623);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 55);
            this.panel2.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(547, 3);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(130, 50);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.Text = "UNDO";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(139, 3);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(130, 50);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "MODIFY";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(275, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 50);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(411, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnSelPat);
            this.panel1.Controls.Add(this.btnFamily);
            this.panel1.Controls.Add(this.btnPatientDem);
            this.panel1.Controls.Add(this.btnGenHist);
            this.panel1.Controls.Add(this.btnAllergy);
            this.panel1.Location = new System.Drawing.Point(207, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 58);
            this.panel1.TabIndex = 15;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(683, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 50);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSelPat
            // 
            this.btnSelPat.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelPat.Location = new System.Drawing.Point(3, 3);
            this.btnSelPat.Name = "btnSelPat";
            this.btnSelPat.Size = new System.Drawing.Size(130, 50);
            this.btnSelPat.TabIndex = 0;
            this.btnSelPat.Text = "Select Patient";
            this.btnSelPat.UseVisualStyleBackColor = true;
            this.btnSelPat.Click += new System.EventHandler(this.btnSelPat_Click);
            // 
            // btnFamily
            // 
            this.btnFamily.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamily.Location = new System.Drawing.Point(547, 3);
            this.btnFamily.Name = "btnFamily";
            this.btnFamily.Size = new System.Drawing.Size(130, 50);
            this.btnFamily.TabIndex = 3;
            this.btnFamily.Text = "Family History";
            this.btnFamily.UseVisualStyleBackColor = true;
            this.btnFamily.Click += new System.EventHandler(this.btnFamily_Click);
            // 
            // btnPatientDem
            // 
            this.btnPatientDem.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDem.Location = new System.Drawing.Point(139, 3);
            this.btnPatientDem.Name = "btnPatientDem";
            this.btnPatientDem.Size = new System.Drawing.Size(130, 50);
            this.btnPatientDem.TabIndex = 2;
            this.btnPatientDem.Text = "Patient Demographics";
            this.btnPatientDem.UseVisualStyleBackColor = true;
            this.btnPatientDem.Click += new System.EventHandler(this.btnPatientDem_Click);
            // 
            // btnGenHist
            // 
            this.btnGenHist.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenHist.Location = new System.Drawing.Point(275, 3);
            this.btnGenHist.Name = "btnGenHist";
            this.btnGenHist.Size = new System.Drawing.Size(130, 50);
            this.btnGenHist.TabIndex = 4;
            this.btnGenHist.Text = "General Medical History";
            this.btnGenHist.UseVisualStyleBackColor = true;
            this.btnGenHist.Click += new System.EventHandler(this.btnGenHist_Click);
            // 
            // btnAllergy
            // 
            this.btnAllergy.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllergy.Location = new System.Drawing.Point(411, 3);
            this.btnAllergy.Name = "btnAllergy";
            this.btnAllergy.Size = new System.Drawing.Size(130, 50);
            this.btnAllergy.TabIndex = 5;
            this.btnAllergy.Text = "Allergy History";
            this.btnAllergy.UseVisualStyleBackColor = true;
            this.btnAllergy.Click += new System.EventHandler(this.btnAllergy_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Username:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(492, 286);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(251, 22);
            this.txtPassword.TabIndex = 12;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(492, 258);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(251, 22);
            this.txtUser.TabIndex = 11;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1219, 690);
            this.Controls.Add(this.btnSubmitLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSelPat;
        private System.Windows.Forms.Button btnFamily;
        private System.Windows.Forms.Button btnPatientDem;
        private System.Windows.Forms.Button btnGenHist;
        private System.Windows.Forms.Button btnAllergy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
    }
}