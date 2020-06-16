namespace _7LibraryXML
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
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.txtBxISBN = new System.Windows.Forms.TextBox();
            this.txtBxSubject = new System.Windows.Forms.TextBox();
            this.txtBxAuthor = new System.Windows.Forms.TextBox();
            this.txtBxTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxDateAdded = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxNumOfCoppies = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxNumOfCopiesCheckedOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCheckIn.Location = new System.Drawing.Point(254, 275);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(116, 26);
            this.btnCheckIn.TabIndex = 20;
            this.btnCheckIn.Text = "Check in";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // txtBxISBN
            // 
            this.txtBxISBN.Location = new System.Drawing.Point(496, 138);
            this.txtBxISBN.Name = "txtBxISBN";
            this.txtBxISBN.ReadOnly = true;
            this.txtBxISBN.Size = new System.Drawing.Size(151, 20);
            this.txtBxISBN.TabIndex = 19;
            // 
            // txtBxSubject
            // 
            this.txtBxSubject.Location = new System.Drawing.Point(496, 112);
            this.txtBxSubject.Name = "txtBxSubject";
            this.txtBxSubject.ReadOnly = true;
            this.txtBxSubject.Size = new System.Drawing.Size(151, 20);
            this.txtBxSubject.TabIndex = 18;
            // 
            // txtBxAuthor
            // 
            this.txtBxAuthor.Location = new System.Drawing.Point(496, 80);
            this.txtBxAuthor.Name = "txtBxAuthor";
            this.txtBxAuthor.ReadOnly = true;
            this.txtBxAuthor.Size = new System.Drawing.Size(151, 20);
            this.txtBxAuthor.TabIndex = 17;
            // 
            // txtBxTitle
            // 
            this.txtBxTitle.Location = new System.Drawing.Point(496, 48);
            this.txtBxTitle.Name = "txtBxTitle";
            this.txtBxTitle.ReadOnly = true;
            this.txtBxTitle.Size = new System.Drawing.Size(151, 20);
            this.txtBxTitle.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.HorizontalScrollbar = true;
            this.lstBooks.Location = new System.Drawing.Point(52, 51);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(318, 199);
            this.lstBooks.TabIndex = 11;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date Added";
            // 
            // txtBxDateAdded
            // 
            this.txtBxDateAdded.Location = new System.Drawing.Point(496, 169);
            this.txtBxDateAdded.Name = "txtBxDateAdded";
            this.txtBxDateAdded.ReadOnly = true;
            this.txtBxDateAdded.Size = new System.Drawing.Size(151, 20);
            this.txtBxDateAdded.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Number of copies";
            // 
            // txtBxNumOfCoppies
            // 
            this.txtBxNumOfCoppies.Location = new System.Drawing.Point(550, 207);
            this.txtBxNumOfCoppies.Name = "txtBxNumOfCoppies";
            this.txtBxNumOfCoppies.ReadOnly = true;
            this.txtBxNumOfCoppies.Size = new System.Drawing.Size(97, 20);
            this.txtBxNumOfCoppies.TabIndex = 19;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCheckOut.Location = new System.Drawing.Point(402, 275);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(116, 26);
            this.btnCheckOut.TabIndex = 20;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Number of copies Checked Out";
            // 
            // txtBxNumOfCopiesCheckedOut
            // 
            this.txtBxNumOfCopiesCheckedOut.Location = new System.Drawing.Point(602, 237);
            this.txtBxNumOfCopiesCheckedOut.Name = "txtBxNumOfCopiesCheckedOut";
            this.txtBxNumOfCopiesCheckedOut.ReadOnly = true;
            this.txtBxNumOfCopiesCheckedOut.Size = new System.Drawing.Size(45, 20);
            this.txtBxNumOfCopiesCheckedOut.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtBxNumOfCopiesCheckedOut);
            this.Controls.Add(this.txtBxNumOfCoppies);
            this.Controls.Add(this.txtBxDateAdded);
            this.Controls.Add(this.txtBxISBN);
            this.Controls.Add(this.txtBxSubject);
            this.Controls.Add(this.txtBxAuthor);
            this.Controls.Add(this.txtBxTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.TextBox txtBxISBN;
        private System.Windows.Forms.TextBox txtBxSubject;
        private System.Windows.Forms.TextBox txtBxAuthor;
        private System.Windows.Forms.TextBox txtBxTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxDateAdded;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxNumOfCoppies;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxNumOfCopiesCheckedOut;
    }
}

