namespace Exam2
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
            this.btnIssueTicket = new System.Windows.Forms.Button();
            this.radBtnCheckIn = new System.Windows.Forms.RadioButton();
            this.radBtnCheckOut = new System.Windows.Forms.RadioButton();
            this.txtBxTicketNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTicketIssue = new System.Windows.Forms.Label();
            this.lstBxIssuedTicket = new System.Windows.Forms.ListBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(288, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parking Garage";
            // 
            // btnIssueTicket
            // 
            this.btnIssueTicket.Location = new System.Drawing.Point(99, 353);
            this.btnIssueTicket.Name = "btnIssueTicket";
            this.btnIssueTicket.Size = new System.Drawing.Size(75, 23);
            this.btnIssueTicket.TabIndex = 2;
            this.btnIssueTicket.Text = "Issue Ticket";
            this.btnIssueTicket.UseVisualStyleBackColor = true;
            this.btnIssueTicket.Click += new System.EventHandler(this.btnIssueTicket_Click);
            // 
            // radBtnCheckIn
            // 
            this.radBtnCheckIn.AutoSize = true;
            this.radBtnCheckIn.Location = new System.Drawing.Point(99, 105);
            this.radBtnCheckIn.Name = "radBtnCheckIn";
            this.radBtnCheckIn.Size = new System.Drawing.Size(68, 17);
            this.radBtnCheckIn.TabIndex = 3;
            this.radBtnCheckIn.TabStop = true;
            this.radBtnCheckIn.Text = "Check In";
            this.radBtnCheckIn.UseVisualStyleBackColor = true;
            // 
            // radBtnCheckOut
            // 
            this.radBtnCheckOut.AutoSize = true;
            this.radBtnCheckOut.Location = new System.Drawing.Point(548, 105);
            this.radBtnCheckOut.Name = "radBtnCheckOut";
            this.radBtnCheckOut.Size = new System.Drawing.Size(76, 17);
            this.radBtnCheckOut.TabIndex = 4;
            this.radBtnCheckOut.TabStop = true;
            this.radBtnCheckOut.Text = "Check Out";
            this.radBtnCheckOut.UseVisualStyleBackColor = true;
            this.radBtnCheckOut.CheckedChanged += new System.EventHandler(this.radBtnCheckOut_CheckedChanged);
            // 
            // txtBxTicketNumber
            // 
            this.txtBxTicketNumber.Location = new System.Drawing.Point(579, 148);
            this.txtBxTicketNumber.Name = "txtBxTicketNumber";
            this.txtBxTicketNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBxTicketNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ticket Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ticket Number:";
            // 
            // lblTicketIssue
            // 
            this.lblTicketIssue.AutoSize = true;
            this.lblTicketIssue.Location = new System.Drawing.Point(118, 151);
            this.lblTicketIssue.Name = "lblTicketIssue";
            this.lblTicketIssue.Size = new System.Drawing.Size(44, 13);
            this.lblTicketIssue.TabIndex = 7;
            this.lblTicketIssue.Text = "Ticket#";
            // 
            // lstBxIssuedTicket
            // 
            this.lstBxIssuedTicket.FormattingEnabled = true;
            this.lstBxIssuedTicket.HorizontalScrollbar = true;
            this.lstBxIssuedTicket.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstBxIssuedTicket.Location = new System.Drawing.Point(256, 151);
            this.lstBxIssuedTicket.Name = "lstBxIssuedTicket";
            this.lstBxIssuedTicket.Size = new System.Drawing.Size(233, 225);
            this.lstBxIssuedTicket.TabIndex = 8;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(591, 353);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 9;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCheckout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lstBxIssuedTicket);
            this.Controls.Add(this.lblTicketIssue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxTicketNumber);
            this.Controls.Add(this.radBtnCheckOut);
            this.Controls.Add(this.radBtnCheckIn);
            this.Controls.Add(this.btnIssueTicket);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Parking Garage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIssueTicket;
        private System.Windows.Forms.RadioButton radBtnCheckIn;
        private System.Windows.Forms.RadioButton radBtnCheckOut;
        private System.Windows.Forms.TextBox txtBxTicketNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTicketIssue;
        private System.Windows.Forms.ListBox lstBxIssuedTicket;
        private System.Windows.Forms.Button btnCheckout;
    }
}

