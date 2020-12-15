
namespace TipCalculator
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.rightSubPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.totallabel = new System.Windows.Forms.Label();
            this.tiptxt = new System.Windows.Forms.TextBox();
            this.tiplabel = new System.Windows.Forms.Label();
            this.leftSubPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.noptxt = new System.Windows.Forms.TextBox();
            this.btnNOPincrement = new System.Windows.Forms.Button();
            this.btnNOPdecrement = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tippercenttxt = new System.Windows.Forms.TextBox();
            this.btntipincrement = new System.Windows.Forms.Button();
            this.btntipdecrement = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Tippercentlabel = new System.Windows.Forms.Label();
            this.Billlabel = new System.Windows.Forms.Label();
            this.billtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countryCB1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.rightSubPanel.SuspendLayout();
            this.leftSubPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.btnClose);
            this.mainPanel.Controls.Add(this.btncalculate);
            this.mainPanel.Controls.Add(this.rightSubPanel);
            this.mainPanel.Controls.Add(this.leftSubPanel);
            this.mainPanel.Location = new System.Drawing.Point(12, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(806, 388);
            this.mainPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(401, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Reset";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(304, 338);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(87, 23);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // rightSubPanel
            // 
            this.rightSubPanel.Controls.Add(this.label3);
            this.rightSubPanel.Controls.Add(this.label2);
            this.rightSubPanel.Controls.Add(this.totaltxt);
            this.rightSubPanel.Controls.Add(this.totallabel);
            this.rightSubPanel.Controls.Add(this.tiptxt);
            this.rightSubPanel.Controls.Add(this.tiplabel);
            this.rightSubPanel.Location = new System.Drawing.Point(482, 15);
            this.rightSubPanel.Name = "rightSubPanel";
            this.rightSubPanel.Size = new System.Drawing.Size(311, 360);
            this.rightSubPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(27, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "per person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "per person";
            // 
            // totaltxt
            // 
            this.totaltxt.BackColor = System.Drawing.SystemColors.Control;
            this.totaltxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totaltxt.Enabled = false;
            this.totaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltxt.Location = new System.Drawing.Point(122, 175);
            this.totaltxt.Multiline = true;
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(186, 71);
            this.totaltxt.TabIndex = 3;
            this.totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.Location = new System.Drawing.Point(23, 176);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(49, 20);
            this.totallabel.TabIndex = 2;
            this.totallabel.Text = "Total\r\n";
            // 
            // tiptxt
            // 
            this.tiptxt.BackColor = System.Drawing.SystemColors.Control;
            this.tiptxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tiptxt.Enabled = false;
            this.tiptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiptxt.Location = new System.Drawing.Point(122, 38);
            this.tiptxt.Multiline = true;
            this.tiptxt.Name = "tiptxt";
            this.tiptxt.Size = new System.Drawing.Size(186, 37);
            this.tiptxt.TabIndex = 1;
            this.tiptxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tiplabel
            // 
            this.tiplabel.AutoSize = true;
            this.tiplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiplabel.Location = new System.Drawing.Point(23, 35);
            this.tiplabel.Name = "tiplabel";
            this.tiplabel.Size = new System.Drawing.Size(33, 20);
            this.tiplabel.TabIndex = 0;
            this.tiplabel.Text = "Tip\r\n";
            // 
            // leftSubPanel
            // 
            this.leftSubPanel.Controls.Add(this.label12);
            this.leftSubPanel.Controls.Add(this.label11);
            this.leftSubPanel.Controls.Add(this.label10);
            this.leftSubPanel.Controls.Add(this.label9);
            this.leftSubPanel.Controls.Add(this.label8);
            this.leftSubPanel.Controls.Add(this.label7);
            this.leftSubPanel.Controls.Add(this.noptxt);
            this.leftSubPanel.Controls.Add(this.btnNOPincrement);
            this.leftSubPanel.Controls.Add(this.btnNOPdecrement);
            this.leftSubPanel.Controls.Add(this.label6);
            this.leftSubPanel.Controls.Add(this.label5);
            this.leftSubPanel.Controls.Add(this.Tippercenttxt);
            this.leftSubPanel.Controls.Add(this.btntipincrement);
            this.leftSubPanel.Controls.Add(this.btntipdecrement);
            this.leftSubPanel.Controls.Add(this.label4);
            this.leftSubPanel.Controls.Add(this.Tippercentlabel);
            this.leftSubPanel.Controls.Add(this.Billlabel);
            this.leftSubPanel.Controls.Add(this.billtxt);
            this.leftSubPanel.Location = new System.Drawing.Point(14, 15);
            this.leftSubPanel.Name = "leftSubPanel";
            this.leftSubPanel.Size = new System.Drawing.Size(284, 360);
            this.leftSubPanel.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(200, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(174, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(77, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(58, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(58, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(52, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 12;
            // 
            // noptxt
            // 
            this.noptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noptxt.Location = new System.Drawing.Point(87, 240);
            this.noptxt.Multiline = true;
            this.noptxt.Name = "noptxt";
            this.noptxt.Size = new System.Drawing.Size(100, 29);
            this.noptxt.TabIndex = 11;
            this.noptxt.Text = "0";
            this.noptxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.noptxt.TextChanged += new System.EventHandler(this.noptxt_TextChanged);
            this.noptxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noptxt_KeyPress);
            // 
            // btnNOPincrement
            // 
            this.btnNOPincrement.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNOPincrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNOPincrement.Location = new System.Drawing.Point(187, 240);
            this.btnNOPincrement.Name = "btnNOPincrement";
            this.btnNOPincrement.Size = new System.Drawing.Size(35, 29);
            this.btnNOPincrement.TabIndex = 10;
            this.btnNOPincrement.Text = "+";
            this.btnNOPincrement.UseVisualStyleBackColor = false;
            this.btnNOPincrement.Click += new System.EventHandler(this.btnNOPincrement_Click);
            // 
            // btnNOPdecrement
            // 
            this.btnNOPdecrement.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNOPdecrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNOPdecrement.Location = new System.Drawing.Point(55, 239);
            this.btnNOPdecrement.Name = "btnNOPdecrement";
            this.btnNOPdecrement.Size = new System.Drawing.Size(33, 30);
            this.btnNOPdecrement.TabIndex = 9;
            this.btnNOPdecrement.Text = "-";
            this.btnNOPdecrement.UseVisualStyleBackColor = false;
            this.btnNOPdecrement.Click += new System.EventHandler(this.btnNOPdecrement_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(55, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 35);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of People";
            // 
            // Tippercenttxt
            // 
            this.Tippercenttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tippercenttxt.Location = new System.Drawing.Point(87, 133);
            this.Tippercenttxt.Multiline = true;
            this.Tippercenttxt.Name = "Tippercenttxt";
            this.Tippercenttxt.Size = new System.Drawing.Size(100, 29);
            this.Tippercenttxt.TabIndex = 6;
            this.Tippercenttxt.Text = "0";
            this.Tippercenttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tippercenttxt.TextChanged += new System.EventHandler(this.Tippercenttxt_TextChanged);
            this.Tippercenttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tippercenttxt_KeyPress);
            // 
            // btntipincrement
            // 
            this.btntipincrement.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btntipincrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntipincrement.Location = new System.Drawing.Point(187, 133);
            this.btntipincrement.Name = "btntipincrement";
            this.btntipincrement.Size = new System.Drawing.Size(38, 30);
            this.btntipincrement.TabIndex = 5;
            this.btntipincrement.Text = "+";
            this.btntipincrement.UseVisualStyleBackColor = false;
            this.btntipincrement.Click += new System.EventHandler(this.btntipincrement_Click);
            // 
            // btntipdecrement
            // 
            this.btntipdecrement.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btntipdecrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntipdecrement.Location = new System.Drawing.Point(52, 133);
            this.btntipdecrement.Name = "btntipdecrement";
            this.btntipdecrement.Size = new System.Drawing.Size(34, 29);
            this.btntipdecrement.TabIndex = 4;
            this.btntipdecrement.Text = "-";
            this.btntipdecrement.UseVisualStyleBackColor = false;
            this.btntipdecrement.Click += new System.EventHandler(this.btntipdecrement_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(55, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // Tippercentlabel
            // 
            this.Tippercentlabel.AutoSize = true;
            this.Tippercentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tippercentlabel.Location = new System.Drawing.Point(48, 100);
            this.Tippercentlabel.Name = "Tippercentlabel";
            this.Tippercentlabel.Size = new System.Drawing.Size(130, 20);
            this.Tippercentlabel.TabIndex = 2;
            this.Tippercentlabel.Text = "Tip Percentage";
            // 
            // Billlabel
            // 
            this.Billlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billlabel.Location = new System.Drawing.Point(48, 13);
            this.Billlabel.Name = "Billlabel";
            this.Billlabel.Size = new System.Drawing.Size(100, 23);
            this.Billlabel.TabIndex = 1;
            this.Billlabel.Text = "Bill";
            // 
            // billtxt
            // 
            this.billtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billtxt.Location = new System.Drawing.Point(52, 39);
            this.billtxt.Multiline = true;
            this.billtxt.Name = "billtxt";
            this.billtxt.Size = new System.Drawing.Size(167, 29);
            this.billtxt.TabIndex = 0;
            this.billtxt.TextChanged += new System.EventHandler(this.billtxt_TextChanged);
            this.billtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.billtxt_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tip Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // countryCB1
            // 
            this.countryCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryCB1.FormattingEnabled = true;
            this.countryCB1.Items.AddRange(new object[] {
            "INDIA",
            "USA",
            "LONDON"});
            this.countryCB1.Location = new System.Drawing.Point(740, 15);
            this.countryCB1.Name = "countryCB1";
            this.countryCB1.Size = new System.Drawing.Size(78, 21);
            this.countryCB1.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(667, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Country";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.countryCB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.rightSubPanel.ResumeLayout(false);
            this.rightSubPanel.PerformLayout();
            this.leftSubPanel.ResumeLayout(false);
            this.leftSubPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel rightSubPanel;
        private System.Windows.Forms.Panel leftSubPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tippercenttxt;
        private System.Windows.Forms.Button btntipincrement;
        private System.Windows.Forms.Button btntipdecrement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Tippercentlabel;
        private System.Windows.Forms.Label Billlabel;
        private System.Windows.Forms.TextBox billtxt;
        private System.Windows.Forms.TextBox noptxt;
        private System.Windows.Forms.Button btnNOPincrement;
        private System.Windows.Forms.Button btnNOPdecrement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tiplabel;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.TextBox tiptxt;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox countryCB1;
        private System.Windows.Forms.Label label13;
    }
}

