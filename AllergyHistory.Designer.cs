namespace ITS245_FinalProject
{
    partial class AllergyHistory
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_famhist = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_genHistory = new System.Windows.Forms.Button();
            this.btn_allergy = new System.Windows.Forms.Button();
            this.PatientView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_allergen = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_pid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_famhist);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.btn_genHistory);
            this.panel1.Controls.Add(this.btn_allergy);
            this.panel1.Location = new System.Drawing.Point(275, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 105);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 36);
            this.label3.TabIndex = 64;
            this.label3.Text = "Patient ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pid
            // 
            this.txt_pid.Enabled = false;
            this.txt_pid.Location = new System.Drawing.Point(104, 63);
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.Size = new System.Drawing.Size(87, 22);
            this.txt_pid.TabIndex = 63;
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
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(683, 3);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(130, 50);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Select Patient";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_famhist
            // 
            this.btn_famhist.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_famhist.Location = new System.Drawing.Point(547, 3);
            this.btn_famhist.Name = "btn_famhist";
            this.btn_famhist.Size = new System.Drawing.Size(130, 50);
            this.btn_famhist.TabIndex = 3;
            this.btn_famhist.Text = "Family History";
            this.btn_famhist.UseVisualStyleBackColor = true;
            this.btn_famhist.Click += new System.EventHandler(this.btn_famhist_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(139, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 50);
            this.button8.TabIndex = 2;
            this.button8.Text = "Patient Demographics";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_genHistory
            // 
            this.btn_genHistory.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genHistory.Location = new System.Drawing.Point(275, 3);
            this.btn_genHistory.Name = "btn_genHistory";
            this.btn_genHistory.Size = new System.Drawing.Size(130, 50);
            this.btn_genHistory.TabIndex = 4;
            this.btn_genHistory.Text = "General Medical History";
            this.btn_genHistory.UseVisualStyleBackColor = true;
            this.btn_genHistory.Click += new System.EventHandler(this.btn_genHistory_Click);
            // 
            // btn_allergy
            // 
            this.btn_allergy.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_allergy.Location = new System.Drawing.Point(411, 3);
            this.btn_allergy.Name = "btn_allergy";
            this.btn_allergy.Size = new System.Drawing.Size(130, 50);
            this.btn_allergy.TabIndex = 5;
            this.btn_allergy.Text = "Allergy History";
            this.btn_allergy.UseVisualStyleBackColor = true;
            this.btn_allergy.Click += new System.EventHandler(this.btn_allergy_Click);
            // 
            // PatientView
            // 
            this.PatientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientView.Location = new System.Drawing.Point(278, 123);
            this.PatientView.Name = "PatientView";
            this.PatientView.RowHeadersWidth = 51;
            this.PatientView.RowTemplate.Height = 24;
            this.PatientView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.PatientView.Size = new System.Drawing.Size(813, 151);
            this.PatientView.TabIndex = 11;
            this.PatientView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientView_CellContentClick_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(475, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(394, 64);
            this.button4.TabIndex = 12;
            this.button4.Text = "Gell All Patients";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_allergen);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.textBox25);
            this.panel2.Controls.Add(this.textBox27);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(414, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 197);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 36);
            this.label2.TabIndex = 71;
            this.label2.Text = "Allergen:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_allergen
            // 
            this.txt_allergen.Enabled = false;
            this.txt_allergen.Location = new System.Drawing.Point(264, 158);
            this.txt_allergen.Name = "txt_allergen";
            this.txt_allergen.Size = new System.Drawing.Size(87, 22);
            this.txt_allergen.TabIndex = 70;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(349, 101);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 51);
            this.textBox1.TabIndex = 69;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(269, 110);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(82, 36);
            this.label27.TabIndex = 68;
            this.label27.Text = "Allergy Description:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(77, 110);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 36);
            this.label28.TabIndex = 67;
            this.label28.Text = "Allergen End:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(271, 56);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 36);
            this.label29.TabIndex = 66;
            this.label29.Text = "Allergen Start:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox25
            // 
            this.textBox25.Enabled = false;
            this.textBox25.Location = new System.Drawing.Point(171, 117);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(87, 22);
            this.textBox25.TabIndex = 65;
            // 
            // textBox27
            // 
            this.textBox27.Enabled = false;
            this.textBox27.Location = new System.Drawing.Point(349, 63);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(87, 22);
            this.textBox27.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 36);
            this.label7.TabIndex = 62;
            this.label7.Text = "Allergen ID:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(171, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 22);
            this.textBox2.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Allergen Info:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Location = new System.Drawing.Point(341, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 55);
            this.panel3.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 50);
            this.button5.TabIndex = 0;
            this.button5.Text = "ADD";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(547, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 50);
            this.button6.TabIndex = 3;
            this.button6.Text = "UNDO";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(139, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(130, 50);
            this.button12.TabIndex = 2;
            this.button12.Text = "MODIFY";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(275, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(130, 50);
            this.button13.TabIndex = 4;
            this.button13.Text = "DELETE";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Enabled = false;
            this.button14.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(411, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(130, 50);
            this.button14.TabIndex = 5;
            this.button14.Text = "SAVE";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // AllergyHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1344, 617);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PatientView);
            this.Controls.Add(this.panel1);
            this.Name = "AllergyHistory";
            this.Text = "AllergyHistory";
            this.Load += new System.EventHandler(this.AllergyHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_famhist;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn_genHistory;
        private System.Windows.Forms.Button btn_allergy;
        private System.Windows.Forms.DataGridView PatientView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_allergen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pid;
    }
}