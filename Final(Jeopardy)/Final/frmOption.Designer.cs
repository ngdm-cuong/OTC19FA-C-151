namespace Final
{
    partial class frmOption
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
            this.nUDnumofPlayers = new System.Windows.Forms.NumericUpDown();
            this.lblNumofPlayers = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDnumofPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // nUDnumofPlayers
            // 
            this.nUDnumofPlayers.Location = new System.Drawing.Point(428, 172);
            this.nUDnumofPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.nUDnumofPlayers.Name = "nUDnumofPlayers";
            this.nUDnumofPlayers.Size = new System.Drawing.Size(160, 22);
            this.nUDnumofPlayers.TabIndex = 0;
            // 
            // lblNumofPlayers
            // 
            this.lblNumofPlayers.AutoSize = true;
            this.lblNumofPlayers.Location = new System.Drawing.Point(281, 175);
            this.lblNumofPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumofPlayers.Name = "lblNumofPlayers";
            this.lblNumofPlayers.Size = new System.Drawing.Size(125, 17);
            this.lblNumofPlayers.TabIndex = 1;
            this.lblNumofPlayers.Text = "Number of Players";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(281, 228);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(89, 17);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Player Name";
            this.lblPlayerName.Visible = false;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(428, 224);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(159, 22);
            this.txtPlayerName.TabIndex = 3;
            this.txtPlayerName.Visible = false;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(621, 170);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(100, 28);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(621, 222);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnStart
            // 
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.FlatAppearance.BorderSize = 5;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.Location = new System.Drawing.Point(443, 322);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Let\'s Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmOption
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblNumofPlayers);
            this.Controls.Add(this.nUDnumofPlayers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOption";
            this.Load += new System.EventHandler(this.FrmOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDnumofPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUDnumofPlayers;
        private System.Windows.Forms.Label lblNumofPlayers;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnStart;
    }
}