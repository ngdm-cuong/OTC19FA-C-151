namespace PizzaDelivery
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbCrust = new System.Windows.Forms.ComboBox();
            this.chkTopping = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPizza = new System.Windows.Forms.TabPage();
            this.tbBeverage = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSpecialty = new System.Windows.Forms.TabPage();
            this.cbSpecialty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbPizza.SuspendLayout();
            this.tbBeverage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tbSpecialty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Selections";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crust";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toppings - $1.50 each";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Small - $8.00",
            "Medium -$11.75",
            "Lagre - $12.95"});
            this.cbSize.Location = new System.Drawing.Point(20, 98);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(112, 21);
            this.cbSize.TabIndex = 4;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // cbCrust
            // 
            this.cbCrust.DisplayMember = "1";
            this.cbCrust.FormattingEnabled = true;
            this.cbCrust.Items.AddRange(new object[] {
            "Thin",
            "Thick",
            "Crispy ",
            "Thin and Crispy",
            "Thick and Crispy"});
            this.cbCrust.Location = new System.Drawing.Point(208, 98);
            this.cbCrust.Name = "cbCrust";
            this.cbCrust.Size = new System.Drawing.Size(127, 21);
            this.cbCrust.TabIndex = 5;
            this.cbCrust.SelectedIndexChanged += new System.EventHandler(this.cbCrust_SelectedIndexChanged);
            // 
            // chkTopping
            // 
            this.chkTopping.CheckOnClick = true;
            this.chkTopping.FormattingEnabled = true;
            this.chkTopping.Items.AddRange(new object[] {
            "Pepperoni",
            "Mushroom",
            "Green Pepper",
            "Olives",
            "Chicken",
            "Sausage",
            "Bacon",
            "Pork"});
            this.chkTopping.Location = new System.Drawing.Point(20, 181);
            this.chkTopping.Name = "chkTopping";
            this.chkTopping.Size = new System.Drawing.Size(111, 109);
            this.chkTopping.TabIndex = 6;
            this.chkTopping.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkTopping_ItemCheck);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPizza);
            this.tabControl1.Controls.Add(this.tbBeverage);
            this.tabControl1.Controls.Add(this.tbSpecialty);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 349);
            this.tabControl1.TabIndex = 7;
            // 
            // tbPizza
            // 
            this.tbPizza.Controls.Add(this.label10);
            this.tbPizza.Controls.Add(this.pictureBox1);
            this.tbPizza.Controls.Add(this.label1);
            this.tbPizza.Controls.Add(this.chkTopping);
            this.tbPizza.Controls.Add(this.label2);
            this.tbPizza.Controls.Add(this.label4);
            this.tbPizza.Controls.Add(this.cbCrust);
            this.tbPizza.Controls.Add(this.label3);
            this.tbPizza.Controls.Add(this.cbSize);
            this.tbPizza.Location = new System.Drawing.Point(4, 22);
            this.tbPizza.Name = "tbPizza";
            this.tbPizza.Padding = new System.Windows.Forms.Padding(3);
            this.tbPizza.Size = new System.Drawing.Size(358, 323);
            this.tbPizza.TabIndex = 0;
            this.tbPizza.Text = "Pizza";
            this.tbPizza.UseVisualStyleBackColor = true;
            // 
            // tbBeverage
            // 
            this.tbBeverage.Controls.Add(this.numericUpDown2);
            this.tbBeverage.Controls.Add(this.numericUpDown1);
            this.tbBeverage.Controls.Add(this.label9);
            this.tbBeverage.Controls.Add(this.label8);
            this.tbBeverage.Controls.Add(this.label7);
            this.tbBeverage.Controls.Add(this.label6);
            this.tbBeverage.Location = new System.Drawing.Point(4, 22);
            this.tbBeverage.Name = "tbBeverage";
            this.tbBeverage.Padding = new System.Windows.Forms.Padding(3);
            this.tbBeverage.Size = new System.Drawing.Size(358, 323);
            this.tbBeverage.TabIndex = 1;
            this.tbBeverage.Text = "Beverage";
            this.tbBeverage.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(134, 160);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(124, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(133, 111);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(125, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Soda cost is $1.75 - Water is free!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Water";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Soda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Drink Selections";
            // 
            // tbSpecialty
            // 
            this.tbSpecialty.Controls.Add(this.cbSpecialty);
            this.tbSpecialty.Controls.Add(this.label5);
            this.tbSpecialty.Location = new System.Drawing.Point(4, 22);
            this.tbSpecialty.Name = "tbSpecialty";
            this.tbSpecialty.Padding = new System.Windows.Forms.Padding(3);
            this.tbSpecialty.Size = new System.Drawing.Size(358, 323);
            this.tbSpecialty.TabIndex = 2;
            this.tbSpecialty.Text = "Specialty Items";
            this.tbSpecialty.UseVisualStyleBackColor = true;
            // 
            // cbSpecialty
            // 
            this.cbSpecialty.FormattingEnabled = true;
            this.cbSpecialty.Items.AddRange(new object[] {
            "None",
            "Chicken Wings - $5.00",
            "Chicken Legs - $3.95",
            "French fries - $3.00",
            "Potsticker - $3.80"});
            this.cbSpecialty.Location = new System.Drawing.Point(109, 78);
            this.cbSpecialty.Name = "cbSpecialty";
            this.cbSpecialty.Size = new System.Drawing.Size(149, 21);
            this.cbSpecialty.TabIndex = 2;
            this.cbSpecialty.Text = "None";
            this.cbSpecialty.SelectedIndexChanged += new System.EventHandler(this.cbSpecialty_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Specialty Items";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(50, 412);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(212, 412);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(101, 23);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaDelivery.Resource1.tenor;
            this.pictureBox1.Location = new System.Drawing.Point(191, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Should i eat Pizza or Pizza???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 445);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Kronk\'s Pizza";
            this.tabControl1.ResumeLayout(false);
            this.tbPizza.ResumeLayout(false);
            this.tbPizza.PerformLayout();
            this.tbBeverage.ResumeLayout(false);
            this.tbBeverage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tbSpecialty.ResumeLayout(false);
            this.tbSpecialty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbCrust;
        private System.Windows.Forms.CheckedListBox chkTopping;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPizza;
        private System.Windows.Forms.TabPage tbBeverage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tbSpecialty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbSpecialty;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
    }
}

