namespace FormUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemsFoundListBox = new System.Windows.Forms.ListBox();
            this.itemNumberText = new System.Windows.Forms.TextBox();
            this.itemNumberLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.itemDescriptionText = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemsFoundListBox
            // 
            this.itemsFoundListBox.FormattingEnabled = true;
            this.itemsFoundListBox.ItemHeight = 30;
            this.itemsFoundListBox.Location = new System.Drawing.Point(12, 153);
            this.itemsFoundListBox.Name = "itemsFoundListBox";
            this.itemsFoundListBox.Size = new System.Drawing.Size(516, 274);
            this.itemsFoundListBox.TabIndex = 0;
            // 
            // itemNumberText
            // 
            this.itemNumberText.Location = new System.Drawing.Point(12, 52);
            this.itemNumberText.Name = "itemNumberText";
            this.itemNumberText.Size = new System.Drawing.Size(227, 35);
            this.itemNumberText.TabIndex = 1;
            // 
            // itemNumberLabel
            // 
            this.itemNumberLabel.AutoSize = true;
            this.itemNumberLabel.Location = new System.Drawing.Point(12, 19);
            this.itemNumberLabel.Name = "itemNumberLabel";
            this.itemNumberLabel.Size = new System.Drawing.Size(137, 30);
            this.itemNumberLabel.TabIndex = 2;
            this.itemNumberLabel.Text = "Item Number";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 93);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 40);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.AutoSize = true;
            this.itemDescriptionLabel.Location = new System.Drawing.Point(248, 19);
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(166, 30);
            this.itemDescriptionLabel.TabIndex = 5;
            this.itemDescriptionLabel.Text = "Item Description";
            // 
            // itemDescriptionText
            // 
            this.itemDescriptionText.Location = new System.Drawing.Point(248, 52);
            this.itemDescriptionText.Name = "itemDescriptionText";
            this.itemDescriptionText.Size = new System.Drawing.Size(280, 35);
            this.itemDescriptionText.TabIndex = 4;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(123, 93);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(116, 40);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(248, 93);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(105, 40);
            this.showAll.TabIndex = 7;
            this.showAll.Text = "Show All";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(359, 93);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 40);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 438);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.itemDescriptionLabel);
            this.Controls.Add(this.itemDescriptionText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.itemNumberLabel);
            this.Controls.Add(this.itemNumberText);
            this.Controls.Add(this.itemsFoundListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox itemsFoundListBox;
        private TextBox itemNumberText;
        private Label itemNumberLabel;
        private Button searchButton;
        private Label itemDescriptionLabel;
        private TextBox itemDescriptionText;
        private Button insertButton;
        private Button showAll;
        private Button deleteButton;
    }
}