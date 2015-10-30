namespace WindowsFormsApplication1
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.liningBox = new System.Windows.Forms.ComboBox();
            this.topmaterialBox = new System.Windows.Forms.ComboBox();
            this.colourBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.solematerialBox = new System.Windows.Forms.ComboBox();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.soleTextbox = new System.Windows.Forms.TextBox();
            this.topTextbox = new System.Windows.Forms.TextBox();
            this.liningTextBox = new System.Windows.Forms.TextBox();
            this.colourTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.calculateButton.Location = new System.Drawing.Point(210, 433);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(211, 100);
            this.calculateButton.TabIndex = 20;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Olive;
            this.titleLabel.Location = new System.Drawing.Point(49, 38);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(592, 36);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "Enter options in the boxes below for a quote";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Colour";
            // 
            // liningBox
            // 
            this.liningBox.BackColor = System.Drawing.Color.Khaki;
            this.liningBox.FormattingEnabled = true;
            this.liningBox.Items.AddRange(new object[] {
            "Swede",
            "Brushed Swede",
            "Polished Leather",
            "Canvas"});
            this.liningBox.Location = new System.Drawing.Point(345, 294);
            this.liningBox.Name = "liningBox";
            this.liningBox.Size = new System.Drawing.Size(121, 21);
            this.liningBox.TabIndex = 17;
            this.liningBox.Text = "l";
            this.liningBox.SelectedIndexChanged += new System.EventHandler(this.liningBox_SelectedIndexChanged);
            // 
            // topmaterialBox
            // 
            this.topmaterialBox.BackColor = System.Drawing.Color.Khaki;
            this.topmaterialBox.FormattingEnabled = true;
            this.topmaterialBox.Items.AddRange(new object[] {
            "Leather",
            "Canvas",
            "Fake Leather",
            "Plastic"});
            this.topmaterialBox.Location = new System.Drawing.Point(176, 294);
            this.topmaterialBox.Name = "topmaterialBox";
            this.topmaterialBox.Size = new System.Drawing.Size(121, 21);
            this.topmaterialBox.TabIndex = 16;
            this.topmaterialBox.Text = "l";
            this.topmaterialBox.SelectedIndexChanged += new System.EventHandler(this.topmaterialBox_SelectedIndexChanged);
            // 
            // colourBox
            // 
            this.colourBox.BackColor = System.Drawing.Color.Khaki;
            this.colourBox.FormattingEnabled = true;
            this.colourBox.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Beige",
            "White",
            "Red"});
            this.colourBox.Location = new System.Drawing.Point(530, 294);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(121, 21);
            this.colourBox.TabIndex = 15;
            this.colourBox.Text = "l";
            this.colourBox.SelectedIndexChanged += new System.EventHandler(this.colourBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lining";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Top Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sole Material";
            // 
            // solematerialBox
            // 
            this.solematerialBox.BackColor = System.Drawing.Color.Khaki;
            this.solematerialBox.FormattingEnabled = true;
            this.solematerialBox.Items.AddRange(new object[] {
            "Leather",
            "Rubber",
            "Metal"});
            this.solematerialBox.Location = new System.Drawing.Point(13, 294);
            this.solematerialBox.Name = "solematerialBox";
            this.solematerialBox.Size = new System.Drawing.Size(121, 21);
            this.solematerialBox.TabIndex = 11;
            this.solematerialBox.Text = "l";
            this.solematerialBox.SelectedIndexChanged += new System.EventHandler(this.solematerialBox_SelectedIndexChanged);
            // 
            // priceTextbox
            // 
            this.priceTextbox.BackColor = System.Drawing.Color.DarkOrange;
            this.priceTextbox.Location = new System.Drawing.Point(235, 179);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(198, 20);
            this.priceTextbox.TabIndex = 10;
            this.priceTextbox.TextChanged += new System.EventHandler(this.priceTextbox_TextChanged);
            // 
            // soleTextbox
            // 
            this.soleTextbox.BackColor = System.Drawing.Color.Wheat;
            this.soleTextbox.Location = new System.Drawing.Point(13, 361);
            this.soleTextbox.Name = "soleTextbox";
            this.soleTextbox.Size = new System.Drawing.Size(121, 20);
            this.soleTextbox.TabIndex = 21;
            this.soleTextbox.TextChanged += new System.EventHandler(this.soleTextbox_TextChanged);
            // 
            // topTextbox
            // 
            this.topTextbox.BackColor = System.Drawing.Color.Wheat;
            this.topTextbox.Location = new System.Drawing.Point(176, 361);
            this.topTextbox.Name = "topTextbox";
            this.topTextbox.Size = new System.Drawing.Size(121, 20);
            this.topTextbox.TabIndex = 22;
            // 
            // liningTextBox
            // 
            this.liningTextBox.BackColor = System.Drawing.Color.Wheat;
            this.liningTextBox.Location = new System.Drawing.Point(345, 361);
            this.liningTextBox.Name = "liningTextBox";
            this.liningTextBox.Size = new System.Drawing.Size(121, 20);
            this.liningTextBox.TabIndex = 23;
            // 
            // colourTextBox
            // 
            this.colourTextBox.BackColor = System.Drawing.Color.Wheat;
            this.colourTextBox.Location = new System.Drawing.Point(530, 361);
            this.colourTextBox.Name = "colourTextBox";
            this.colourTextBox.Size = new System.Drawing.Size(121, 20);
            this.colourTextBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Peru;
            this.label5.Location = new System.Drawing.Point(276, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Your Quote";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(677, 576);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.colourTextBox);
            this.Controls.Add(this.liningTextBox);
            this.Controls.Add(this.topTextbox);
            this.Controls.Add(this.soleTextbox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.liningBox);
            this.Controls.Add(this.topmaterialBox);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solematerialBox);
            this.Controls.Add(this.priceTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox liningBox;
        private System.Windows.Forms.ComboBox topmaterialBox;
        private System.Windows.Forms.ComboBox colourBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox solematerialBox;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.TextBox soleTextbox;
        private System.Windows.Forms.TextBox topTextbox;
        private System.Windows.Forms.TextBox liningTextBox;
        private System.Windows.Forms.TextBox colourTextBox;
        private System.Windows.Forms.Label label5;
    }
}

