namespace ITS245_FinalProject
{
    partial class FamilyHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSelPat = new System.Windows.Forms.Button();
            this.btnFamily = new System.Windows.Forms.Button();
            this.btnPatientDem = new System.Windows.Forms.Button();
            this.btnGenHist = new System.Windows.Forms.Button();
            this.btnAllergy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.familyListBox = new System.Windows.Forms.ListBox();
            this.comboPatID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRelation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlive = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLivesWPat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDisorder = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDisorderType = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRelation = new System.Windows.Forms.Button();
            this.btnDisorder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnSelPat);
            this.panel1.Controls.Add(this.btnFamily);
            this.panel1.Controls.Add(this.btnPatientDem);
            this.panel1.Controls.Add(this.btnGenHist);
            this.panel1.Controls.Add(this.btnAllergy);
            this.panel1.Location = new System.Drawing.Point(130, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 105);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patient Display";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(194, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 55);
            this.panel2.TabIndex = 7;
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
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
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(275, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(130, 50);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // familyListBox
            // 
            this.familyListBox.FormattingEnabled = true;
            this.familyListBox.ItemHeight = 16;
            this.familyListBox.Location = new System.Drawing.Point(128, 88);
            this.familyListBox.Name = "familyListBox";
            this.familyListBox.Size = new System.Drawing.Size(30, 164);
            this.familyListBox.TabIndex = 9;
            this.familyListBox.SelectedValueChanged += new System.EventHandler(this.familyListBox_SelectedValueChanged);
            // 
            // comboPatID
            // 
            this.comboPatID.FormattingEnabled = true;
            this.comboPatID.Location = new System.Drawing.Point(102, 12);
            this.comboPatID.Name = "comboPatID";
            this.comboPatID.Size = new System.Drawing.Size(87, 24);
            this.comboPatID.TabIndex = 50;
            this.comboPatID.SelectedIndexChanged += new System.EventHandler(this.comboPatID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "Patient ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 36);
            this.label3.TabIndex = 52;
            this.label3.Text = "Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(310, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 22);
            this.txtName.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 36);
            this.label4.TabIndex = 54;
            this.label4.Text = "Relation:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRelation
            // 
            this.txtRelation.Location = new System.Drawing.Point(310, 139);
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.Size = new System.Drawing.Size(161, 22);
            this.txtRelation.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 36);
            this.label5.TabIndex = 56;
            this.label5.Text = "Alive:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlive
            // 
            this.txtAlive.Location = new System.Drawing.Point(310, 178);
            this.txtAlive.Name = "txtAlive";
            this.txtAlive.Size = new System.Drawing.Size(161, 22);
            this.txtAlive.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 44);
            this.label6.TabIndex = 58;
            this.label6.Text = "Lives With Patient:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLivesWPat
            // 
            this.txtLivesWPat.Location = new System.Drawing.Point(310, 230);
            this.txtLivesWPat.Name = "txtLivesWPat";
            this.txtLivesWPat.Size = new System.Drawing.Size(161, 22);
            this.txtLivesWPat.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(495, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 36);
            this.label7.TabIndex = 60;
            this.label7.Text = "Major Disorder:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDisorder
            // 
            this.txtDisorder.Location = new System.Drawing.Point(595, 120);
            this.txtDisorder.Name = "txtDisorder";
            this.txtDisorder.Size = new System.Drawing.Size(161, 22);
            this.txtDisorder.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 36);
            this.label9.TabIndex = 62;
            this.label9.Text = "Specific Type Disorder:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDisorderType
            // 
            this.txtDisorderType.Location = new System.Drawing.Point(595, 185);
            this.txtDisorderType.Name = "txtDisorderType";
            this.txtDisorderType.Size = new System.Drawing.Size(161, 22);
            this.txtDisorderType.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 55);
            this.button1.TabIndex = 64;
            this.button1.Text = "Populate All Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRelation
            // 
            this.btnRelation.Location = new System.Drawing.Point(27, 88);
            this.btnRelation.Name = "btnRelation";
            this.btnRelation.Size = new System.Drawing.Size(95, 41);
            this.btnRelation.TabIndex = 65;
            this.btnRelation.Text = "Relation Data";
            this.btnRelation.UseVisualStyleBackColor = true;
            this.btnRelation.Click += new System.EventHandler(this.btnRelation_Click);
            // 
            // btnDisorder
            // 
            this.btnDisorder.Location = new System.Drawing.Point(27, 145);
            this.btnDisorder.Name = "btnDisorder";
            this.btnDisorder.Size = new System.Drawing.Size(95, 41);
            this.btnDisorder.TabIndex = 66;
            this.btnDisorder.Text = "Disorder Data";
            this.btnDisorder.UseVisualStyleBackColor = true;
            this.btnDisorder.Click += new System.EventHandler(this.btnDisorder_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Controls.Add(this.comboPatID);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnDisorder);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtDisorderType);
            this.panel3.Controls.Add(this.btnRelation);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.familyListBox);
            this.panel3.Controls.Add(this.txtDisorder);
            this.panel3.Controls.Add(this.txtLivesWPat);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtRelation);
            this.panel3.Controls.Add(this.txtAlive);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(95, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 327);
            this.panel3.TabIndex = 67;
            // 
            // FamilyHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1052, 523);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FamilyHistory";
            this.Text = "FamilyHistory";
            this.Load += new System.EventHandler(this.FamilyHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSelPat;
        private System.Windows.Forms.Button btnFamily;
        private System.Windows.Forms.Button btnPatientDem;
        private System.Windows.Forms.Button btnGenHist;
        private System.Windows.Forms.Button btnAllergy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox familyListBox;
        private System.Windows.Forms.ComboBox comboPatID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRelation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLivesWPat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDisorder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDisorderType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRelation;
        private System.Windows.Forms.Button btnDisorder;
        private System.Windows.Forms.Panel panel3;
    }
}