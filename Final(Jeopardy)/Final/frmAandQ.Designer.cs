namespace Final
{
    partial class frmAandQ
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
            this.components = new System.ComponentModel.Container();
            this.txtBxQuestion = new System.Windows.Forms.TextBox();
            this.txtBxAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.TimerCountDown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtBxQuestion
            // 
            this.txtBxQuestion.BackColor = System.Drawing.Color.Blue;
            this.txtBxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxQuestion.ForeColor = System.Drawing.Color.White;
            this.txtBxQuestion.Location = new System.Drawing.Point(71, 69);
            this.txtBxQuestion.Multiline = true;
            this.txtBxQuestion.Name = "txtBxQuestion";
            this.txtBxQuestion.ReadOnly = true;
            this.txtBxQuestion.Size = new System.Drawing.Size(660, 179);
            this.txtBxQuestion.TabIndex = 0;
            this.txtBxQuestion.Text = "Testing";
            this.txtBxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxQuestion.WordWrap = false;
            // 
            // txtBxAnswer
            // 
            this.txtBxAnswer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtBxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxAnswer.ForeColor = System.Drawing.Color.Yellow;
            this.txtBxAnswer.Location = new System.Drawing.Point(309, 314);
            this.txtBxAnswer.Multiline = true;
            this.txtBxAnswer.Name = "txtBxAnswer";
            this.txtBxAnswer.Size = new System.Drawing.Size(200, 32);
            this.txtBxAnswer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(199, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "What is ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.btnSubmit.Location = new System.Drawing.Point(522, 314);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 32);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "?";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Yellow;
            this.lblTimer.Location = new System.Drawing.Point(363, 227);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(69, 29);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "11:00";
            // 
            // TimerCountDown
            // 
            this.TimerCountDown.Tick += new System.EventHandler(this.TimerCountDown_Tick);
            // 
            // frmAandQ
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxAnswer);
            this.Controls.Add(this.txtBxQuestion);
            this.Name = "frmAandQ";
            this.Text = "frmAandQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAandQ_FormClosing);
            this.Load += new System.EventHandler(this.FrmAandQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxQuestion;
        private System.Windows.Forms.TextBox txtBxAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer TimerCountDown;
    }
}