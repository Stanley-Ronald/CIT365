namespace MegaDesk_3_RonaldStanley
{
    partial class MainMenu
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
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.viewAllQuotesButton = new System.Windows.Forms.Button();
            this.searchAllQuotesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.Location = new System.Drawing.Point(24, 35);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(166, 45);
            this.addQuoteButton.TabIndex = 0;
            this.addQuoteButton.Text = "Add New Quote";
            this.addQuoteButton.UseVisualStyleBackColor = true;
            this.addQuoteButton.Click += new System.EventHandler(this.addNewQuoteButton_Click);
            // 
            // viewAllQuotesButton
            // 
            this.viewAllQuotesButton.Location = new System.Drawing.Point(24, 86);
            this.viewAllQuotesButton.Name = "viewAllQuotesButton";
            this.viewAllQuotesButton.Size = new System.Drawing.Size(166, 45);
            this.viewAllQuotesButton.TabIndex = 1;
            this.viewAllQuotesButton.Text = "View Quotes";
            this.viewAllQuotesButton.UseVisualStyleBackColor = true;
            this.viewAllQuotesButton.Click += new System.EventHandler(this.viewAllQuotesButton_Click);
            // 
            // searchAllQuotesButton
            // 
            this.searchAllQuotesButton.Location = new System.Drawing.Point(24, 137);
            this.searchAllQuotesButton.Name = "searchAllQuotesButton";
            this.searchAllQuotesButton.Size = new System.Drawing.Size(166, 45);
            this.searchAllQuotesButton.TabIndex = 3;
            this.searchAllQuotesButton.Text = "Search Quotes";
            this.searchAllQuotesButton.UseVisualStyleBackColor = true;
            this.searchAllQuotesButton.Click += new System.EventHandler(this.searchAllQuotesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(24, 188);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(166, 45);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 265);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchAllQuotesButton);
            this.Controls.Add(this.viewAllQuotesButton);
            this.Controls.Add(this.addQuoteButton);
            this.Name = "MainMenu";
            this.Text = "MegaDesk - Ronald Stanley";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.Button viewAllQuotesButton;
        private System.Windows.Forms.Button searchAllQuotesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

