namespace Survey_Form
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
            this.TITLE = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.chkPhone = new System.Windows.Forms.CheckBox();
            this.chkCharger = new System.Windows.Forms.CheckBox();
            this.chkWallet = new System.Windows.Forms.CheckBox();
            this.chkKeys = new System.Windows.Forms.CheckBox();
            this.chkJacket = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radUnder18 = new System.Windows.Forms.RadioButton();
            this.radOver18 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.lblBday = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // TITLE
            // 
            this.TITLE.Enabled = false;
            this.TITLE.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.Location = new System.Drawing.Point(55, 22);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(322, 74);
            this.TITLE.TabIndex = 0;
            this.TITLE.Text = "What do you usually bring with you?";
            this.TITLE.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(311, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(105, 116);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(311, 20);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // chkPhone
            // 
            this.chkPhone.AutoSize = true;
            this.chkPhone.Location = new System.Drawing.Point(15, 19);
            this.chkPhone.Name = "chkPhone";
            this.chkPhone.Size = new System.Drawing.Size(57, 17);
            this.chkPhone.TabIndex = 3;
            this.chkPhone.Text = "Phone";
            this.chkPhone.UseVisualStyleBackColor = true;
            // 
            // chkCharger
            // 
            this.chkCharger.AutoSize = true;
            this.chkCharger.Location = new System.Drawing.Point(15, 42);
            this.chkCharger.Name = "chkCharger";
            this.chkCharger.Size = new System.Drawing.Size(63, 17);
            this.chkCharger.TabIndex = 4;
            this.chkCharger.Text = "Charger";
            this.chkCharger.UseVisualStyleBackColor = true;
            // 
            // chkWallet
            // 
            this.chkWallet.AutoSize = true;
            this.chkWallet.Location = new System.Drawing.Point(113, 19);
            this.chkWallet.Name = "chkWallet";
            this.chkWallet.Size = new System.Drawing.Size(56, 17);
            this.chkWallet.TabIndex = 5;
            this.chkWallet.Text = "Wallet";
            this.chkWallet.UseVisualStyleBackColor = true;
            // 
            // chkKeys
            // 
            this.chkKeys.AutoSize = true;
            this.chkKeys.Location = new System.Drawing.Point(113, 42);
            this.chkKeys.Name = "chkKeys";
            this.chkKeys.Size = new System.Drawing.Size(49, 17);
            this.chkKeys.TabIndex = 6;
            this.chkKeys.Text = "Keys";
            this.chkKeys.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkKeys.UseVisualStyleBackColor = true;
            // 
            // chkJacket
            // 
            this.chkJacket.AutoSize = true;
            this.chkJacket.Location = new System.Drawing.Point(216, 19);
            this.chkJacket.Name = "chkJacket";
            this.chkJacket.Size = new System.Drawing.Size(58, 17);
            this.chkJacket.TabIndex = 7;
            this.chkJacket.Text = "Jacket";
            this.chkJacket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkJacket.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone Number:";
            // 
            // radUnder18
            // 
            this.radUnder18.AutoSize = true;
            this.radUnder18.Location = new System.Drawing.Point(105, 151);
            this.radUnder18.Name = "radUnder18";
            this.radUnder18.Size = new System.Drawing.Size(69, 17);
            this.radUnder18.TabIndex = 10;
            this.radUnder18.TabStop = true;
            this.radUnder18.Text = "Under 18";
            this.radUnder18.UseVisualStyleBackColor = true;
            // 
            // radOver18
            // 
            this.radOver18.AutoSize = true;
            this.radOver18.Location = new System.Drawing.Point(221, 151);
            this.radOver18.Name = "radOver18";
            this.radOver18.Size = new System.Drawing.Size(63, 17);
            this.radOver18.TabIndex = 11;
            this.radOver18.TabStop = true;
            this.radOver18.Text = "Over 18";
            this.radOver18.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(105, 255);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date of birth:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(196, 474);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "How many cars do you have?";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(24, 533);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 25);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(296, 533);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(120, 25);
            this.Submit.TabIndex = 18;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(40, 596);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 19;
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.chkJacket);
            this.grpItem.Controls.Add(this.chkKeys);
            this.grpItem.Controls.Add(this.chkWallet);
            this.grpItem.Controls.Add(this.chkCharger);
            this.grpItem.Controls.Add(this.chkPhone);
            this.grpItem.Location = new System.Drawing.Point(12, 174);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(319, 67);
            this.grpItem.TabIndex = 20;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Items";
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Location = new System.Drawing.Point(109, 438);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(51, 13);
            this.lblBday.TabIndex = 21;
            this.lblBday.Text = "Birthday: ";
            this.lblBday.Click += new System.EventHandler(this.lblBday_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(439, 620);
            this.Controls.Add(this.lblBday);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radOver18);
            this.Controls.Add(this.radUnder18);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.TITLE);
            this.Name = "Form1";
            this.Text = "Survey";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.CheckBox chkCharger;
        private System.Windows.Forms.CheckBox chkWallet;
        private System.Windows.Forms.CheckBox chkKeys;
        private System.Windows.Forms.CheckBox chkJacket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radUnder18;
        private System.Windows.Forms.RadioButton radOver18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.Label lblBday;
    }
}

