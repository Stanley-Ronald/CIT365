namespace MegaDesk_3_RonaldStanley
{
    partial class AddQuote
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
            this.displayQuoteButton = new System.Windows.Forms.Button();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.drawersBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.materialsDropDownBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rushOrderDropDownBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayQuoteButton
            // 
            this.displayQuoteButton.Location = new System.Drawing.Point(149, 211);
            this.displayQuoteButton.Name = "displayQuoteButton";
            this.displayQuoteButton.Size = new System.Drawing.Size(99, 38);
            this.displayQuoteButton.TabIndex = 0;
            this.displayQuoteButton.Text = "Get Quote";
            this.displayQuoteButton.UseVisualStyleBackColor = true;
            this.displayQuoteButton.Click += new System.EventHandler(this.displayQuoteButton_Click);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(137, 48);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(111, 20);
            this.widthTextBox.TabIndex = 1;
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthTextBox_Validating);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(137, 74);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(111, 20);
            this.heightTextBox.TabIndex = 2;
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTextBox_KeyPress);
            // 
            // drawersBox
            // 
            this.drawersBox.Location = new System.Drawing.Point(137, 100);
            this.drawersBox.Name = "drawersBox";
            this.drawersBox.Size = new System.Drawing.Size(111, 20);
            this.drawersBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Drawers #";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(137, 22);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(111, 20);
            this.nameBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // materialsDropDownBox
            // 
            this.materialsDropDownBox.FormattingEnabled = true;
            this.materialsDropDownBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialsDropDownBox.Location = new System.Drawing.Point(137, 126);
            this.materialsDropDownBox.Name = "materialsDropDownBox";
            this.materialsDropDownBox.Size = new System.Drawing.Size(111, 21);
            this.materialsDropDownBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Materials";
            // 
            // rushOrderDropDownBox
            // 
            this.rushOrderDropDownBox.FormattingEnabled = true;
            this.rushOrderDropDownBox.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "7 days"});
            this.rushOrderDropDownBox.Location = new System.Drawing.Point(137, 153);
            this.rushOrderDropDownBox.Name = "rushOrderDropDownBox";
            this.rushOrderDropDownBox.Size = new System.Drawing.Size(111, 21);
            this.rushOrderDropDownBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rush Order";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rushOrderDropDownBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materialsDropDownBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawersBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.displayQuoteButton);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayQuoteButton;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox drawersBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox materialsDropDownBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox rushOrderDropDownBox;
        private System.Windows.Forms.Label label6;
    }
}