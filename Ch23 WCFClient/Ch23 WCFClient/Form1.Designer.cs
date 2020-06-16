namespace Ch23_WCFClient
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
            this.txtBxMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxResponse = new System.Windows.Forms.TextBox();
            this.btnSendNumber = new System.Windows.Forms.Button();
            this.btnSendWords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your message:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBxMessage
            // 
            this.txtBxMessage.Location = new System.Drawing.Point(121, 48);
            this.txtBxMessage.Name = "txtBxMessage";
            this.txtBxMessage.Size = new System.Drawing.Size(223, 20);
            this.txtBxMessage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Response:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBxResponse
            // 
            this.txtBxResponse.Location = new System.Drawing.Point(121, 166);
            this.txtBxResponse.Name = "txtBxResponse";
            this.txtBxResponse.Size = new System.Drawing.Size(223, 20);
            this.txtBxResponse.TabIndex = 1;
            // 
            // btnSendNumber
            // 
            this.btnSendNumber.Location = new System.Drawing.Point(121, 87);
            this.btnSendNumber.Name = "btnSendNumber";
            this.btnSendNumber.Size = new System.Drawing.Size(108, 61);
            this.btnSendNumber.TabIndex = 2;
            this.btnSendNumber.Text = "Send Number";
            this.btnSendNumber.UseVisualStyleBackColor = true;
            this.btnSendNumber.Click += new System.EventHandler(this.btnSendNumber_Click);
            // 
            // btnSendWords
            // 
            this.btnSendWords.Location = new System.Drawing.Point(235, 87);
            this.btnSendWords.Name = "btnSendWords";
            this.btnSendWords.Size = new System.Drawing.Size(109, 61);
            this.btnSendWords.TabIndex = 2;
            this.btnSendWords.Text = "Send Words";
            this.btnSendWords.UseVisualStyleBackColor = true;
            this.btnSendWords.Click += new System.EventHandler(this.btnSendNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSendWords);
            this.Controls.Add(this.btnSendNumber);
            this.Controls.Add(this.txtBxResponse);
            this.Controls.Add(this.txtBxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxResponse;
        private System.Windows.Forms.Button btnSendNumber;
        private System.Windows.Forms.Button btnSendWords;
    }
}

