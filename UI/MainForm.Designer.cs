namespace FontBuilder.UI
{
    partial class MainForm
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
            this.cmbFontFamily = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCharHeight = new System.Windows.Forms.NumericUpDown();
            this.txtCharWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numCharWidth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numCharHeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbPrintedChars = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fontPreview = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblForegroundColor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharHeight)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFontFamily
            // 
            this.cmbFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFontFamily.FormattingEnabled = true;
            this.cmbFontFamily.Location = new System.Drawing.Point(10, 37);
            this.cmbFontFamily.Name = "cmbFontFamily";
            this.cmbFontFamily.Size = new System.Drawing.Size(184, 24);
            this.cmbFontFamily.TabIndex = 0;
            this.cmbFontFamily.SelectedIndexChanged += new System.EventHandler(this.RefreshSelectedFont);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Font Families";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCharHeight);
            this.groupBox1.Controls.Add(this.txtCharWidth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Size";
            // 
            // txtCharHeight
            // 
            this.txtCharHeight.Location = new System.Drawing.Point(53, 52);
            this.txtCharHeight.Maximum = new decimal(new int[] {
            2046,
            0,
            0,
            0});
            this.txtCharHeight.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.txtCharHeight.Name = "txtCharHeight";
            this.txtCharHeight.Size = new System.Drawing.Size(79, 23);
            this.txtCharHeight.TabIndex = 7;
            this.txtCharHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // txtCharWidth
            // 
            this.txtCharWidth.Location = new System.Drawing.Point(53, 21);
            this.txtCharWidth.Maximum = new decimal(new int[] {
            2046,
            0,
            0,
            0});
            this.txtCharWidth.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.txtCharWidth.Name = "txtCharWidth";
            this.txtCharWidth.Size = new System.Drawing.Size(79, 23);
            this.txtCharWidth.TabIndex = 6;
            this.txtCharWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "px";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "px";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbFontFamily);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 86);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appareance";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numCharWidth);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numCharHeight);
            this.groupBox3.Location = new System.Drawing.Point(224, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 92);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grouping";
            // 
            // numCharWidth
            // 
            this.numCharWidth.AutoSize = true;
            this.numCharWidth.Location = new System.Drawing.Point(6, 24);
            this.numCharWidth.Name = "numCharWidth";
            this.numCharWidth.Size = new System.Drawing.Size(15, 16);
            this.numCharWidth.TabIndex = 4;
            this.numCharWidth.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "chars height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "characters total";
            // 
            // numCharHeight
            // 
            this.numCharHeight.Location = new System.Drawing.Point(7, 63);
            this.numCharHeight.Name = "numCharHeight";
            this.numCharHeight.Size = new System.Drawing.Size(53, 23);
            this.numCharHeight.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbPrintedChars);
            this.groupBox4.Location = new System.Drawing.Point(12, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 52);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Printed Chars";
            // 
            // cmbPrintedChars
            // 
            this.cmbPrintedChars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrintedChars.FormattingEnabled = true;
            this.cmbPrintedChars.Items.AddRange(new object[] {
            "Numeric",
            "Alphabet",
            "Alphanumeric",
            "Alphanumeric and symbols"});
            this.cmbPrintedChars.Location = new System.Drawing.Point(10, 23);
            this.cmbPrintedChars.Name = "cmbPrintedChars";
            this.cmbPrintedChars.Size = new System.Drawing.Size(184, 24);
            this.cmbPrintedChars.TabIndex = 0;
            this.cmbPrintedChars.SelectedIndexChanged += new System.EventHandler(this.CmbPrintedCharsSelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save as...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // fontPreview
            // 
            this.fontPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontPreview.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontPreview.Location = new System.Drawing.Point(12, 262);
            this.fontPreview.Name = "fontPreview";
            this.fontPreview.Size = new System.Drawing.Size(383, 51);
            this.fontPreview.TabIndex = 8;
            this.fontPreview.Text = "The quick fox jumped over the lazy dog...";
            this.fontPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblForegroundColor);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.lblBackgroundColor);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(12, 162);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 97);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Color";
            // 
            // lblForegroundColor
            // 
            this.lblForegroundColor.BackColor = System.Drawing.Color.White;
            this.lblForegroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblForegroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForegroundColor.Location = new System.Drawing.Point(135, 57);
            this.lblForegroundColor.Name = "lblForegroundColor";
            this.lblForegroundColor.Size = new System.Drawing.Size(25, 25);
            this.lblForegroundColor.TabIndex = 3;
            this.lblForegroundColor.Click += new System.EventHandler(this.PickBackgroundColor);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Foreground Color";
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.BackColor = System.Drawing.Color.White;
            this.lblBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBackgroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackgroundColor.Location = new System.Drawing.Point(135, 19);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(25, 25);
            this.lblBackgroundColor.TabIndex = 1;
            this.lblBackgroundColor.Click += new System.EventHandler(this.PickBackgroundColor);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Background Color";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 322);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.fontPreview);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Font Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharHeight)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFontFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCharHeight;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbPrintedChars;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label fontPreview;
        private System.Windows.Forms.Label numCharWidth;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblForegroundColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.NumericUpDown txtCharHeight;
        private System.Windows.Forms.NumericUpDown txtCharWidth;
    }
}

