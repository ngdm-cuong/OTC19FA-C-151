namespace U3ExamEmpSys
{
    partial class Form1
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
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtBxEmployeeID = new System.Windows.Forms.TextBox();
            this.txtBxFName = new System.Windows.Forms.TextBox();
            this.txtBxLName = new System.Windows.Forms.TextBox();
            this.txtBxSSN = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxPhone = new System.Windows.Forms.TextBox();
            this.txtBxTaxRate = new System.Windows.Forms.TextBox();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.txtBxSalary = new System.Windows.Forms.TextBox();
            this.txtBxHasInsurance = new System.Windows.Forms.TextBox();
            this.txtBxTaxExempt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.numBxVacationDays = new System.Windows.Forms.NumericUpDown();
            this.numBxSickDays = new System.Windows.Forms.NumericUpDown();
            this.txtBxDateHired = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numBxVacationDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBxSickDays)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee Management";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(107, 332);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(466, 439);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(2, 332);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(2, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(445, 277);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtBxEmployeeID
            // 
            this.txtBxEmployeeID.Location = new System.Drawing.Point(584, 43);
            this.txtBxEmployeeID.Name = "txtBxEmployeeID";
            this.txtBxEmployeeID.Size = new System.Drawing.Size(152, 20);
            this.txtBxEmployeeID.TabIndex = 8;
            // 
            // txtBxFName
            // 
            this.txtBxFName.Location = new System.Drawing.Point(584, 69);
            this.txtBxFName.Name = "txtBxFName";
            this.txtBxFName.Size = new System.Drawing.Size(152, 20);
            this.txtBxFName.TabIndex = 8;
            // 
            // txtBxLName
            // 
            this.txtBxLName.Location = new System.Drawing.Point(584, 95);
            this.txtBxLName.Name = "txtBxLName";
            this.txtBxLName.Size = new System.Drawing.Size(152, 20);
            this.txtBxLName.TabIndex = 8;
            // 
            // txtBxSSN
            // 
            this.txtBxSSN.Location = new System.Drawing.Point(584, 147);
            this.txtBxSSN.Name = "txtBxSSN";
            this.txtBxSSN.Size = new System.Drawing.Size(152, 20);
            this.txtBxSSN.TabIndex = 8;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(584, 173);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(152, 20);
            this.txtBxEmail.TabIndex = 8;
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Location = new System.Drawing.Point(584, 199);
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(152, 20);
            this.txtBxPhone.TabIndex = 8;
            // 
            // txtBxTaxRate
            // 
            this.txtBxTaxRate.Location = new System.Drawing.Point(584, 225);
            this.txtBxTaxRate.Name = "txtBxTaxRate";
            this.txtBxTaxRate.Size = new System.Drawing.Size(152, 20);
            this.txtBxTaxRate.TabIndex = 8;
            this.txtBxTaxRate.TextChanged += new System.EventHandler(this.txtBxTaxRate_TextChanged);
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(584, 251);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(152, 20);
            this.txtBxID.TabIndex = 8;
            // 
            // txtBxSalary
            // 
            this.txtBxSalary.Location = new System.Drawing.Point(584, 277);
            this.txtBxSalary.Name = "txtBxSalary";
            this.txtBxSalary.Size = new System.Drawing.Size(152, 20);
            this.txtBxSalary.TabIndex = 8;
            this.txtBxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxSalary_KeyPress);
            // 
            // txtBxHasInsurance
            // 
            this.txtBxHasInsurance.Location = new System.Drawing.Point(610, 329);
            this.txtBxHasInsurance.Name = "txtBxHasInsurance";
            this.txtBxHasInsurance.Size = new System.Drawing.Size(126, 20);
            this.txtBxHasInsurance.TabIndex = 8;
            // 
            // txtBxTaxExempt
            // 
            this.txtBxTaxExempt.Location = new System.Drawing.Point(610, 355);
            this.txtBxTaxExempt.Name = "txtBxTaxExempt";
            this.txtBxTaxExempt.Size = new System.Drawing.Size(126, 20);
            this.txtBxTaxExempt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "EmployeeID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date Hired:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "SSN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Phone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tax Rate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Salary:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(489, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Num Of Vacation Days:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(489, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Has Insurance:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(489, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Tax Exempt:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(489, 384);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Num Of Sick Days:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(563, 439);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(661, 439);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(372, 332);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(75, 23);
            this.btnAddnew.TabIndex = 10;
            this.btnAddnew.Text = "Add New";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.BtnAddnew_Click);
            // 
            // numBxVacationDays
            // 
            this.numBxVacationDays.Location = new System.Drawing.Point(610, 303);
            this.numBxVacationDays.Name = "numBxVacationDays";
            this.numBxVacationDays.Size = new System.Drawing.Size(126, 20);
            this.numBxVacationDays.TabIndex = 11;
            // 
            // numBxSickDays
            // 
            this.numBxSickDays.Location = new System.Drawing.Point(610, 382);
            this.numBxSickDays.Name = "numBxSickDays";
            this.numBxSickDays.Size = new System.Drawing.Size(126, 20);
            this.numBxSickDays.TabIndex = 11;
            // 
            // txtBxDateHired
            // 
            this.txtBxDateHired.Location = new System.Drawing.Point(584, 121);
            this.txtBxDateHired.Name = "txtBxDateHired";
            this.txtBxDateHired.Size = new System.Drawing.Size(152, 20);
            this.txtBxDateHired.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.txtBxDateHired);
            this.Controls.Add(this.numBxSickDays);
            this.Controls.Add(this.numBxVacationDays);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxTaxExempt);
            this.Controls.Add(this.txtBxHasInsurance);
            this.Controls.Add(this.txtBxSalary);
            this.Controls.Add(this.txtBxID);
            this.Controls.Add(this.txtBxTaxRate);
            this.Controls.Add(this.txtBxPhone);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxSSN);
            this.Controls.Add(this.txtBxLName);
            this.Controls.Add(this.txtBxFName);
            this.Controls.Add(this.txtBxEmployeeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Employeee";
            ((System.ComponentModel.ISupportInitialize)(this.numBxVacationDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBxSickDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLoad;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtBxEmployeeID;
        private System.Windows.Forms.TextBox txtBxFName;
        private System.Windows.Forms.TextBox txtBxLName;
        private System.Windows.Forms.TextBox txtBxSSN;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxPhone;
        private System.Windows.Forms.TextBox txtBxTaxRate;
        private System.Windows.Forms.TextBox txtBxID;
        private System.Windows.Forms.TextBox txtBxSalary;
        private System.Windows.Forms.TextBox txtBxHasInsurance;
        private System.Windows.Forms.TextBox txtBxTaxExempt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.NumericUpDown numBxVacationDays;
        private System.Windows.Forms.NumericUpDown numBxSickDays;
        private System.Windows.Forms.DateTimePicker txtBxDateHired;
    }
}

