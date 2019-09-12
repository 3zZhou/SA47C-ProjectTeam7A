namespace SA47Team07AProject
{
    partial class SearchInBookMaintainance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchInBookMaintainance));
            this.removeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.BookTypeBox = new System.Windows.Forms.ComboBox();
            this.BookSearchTextBox = new System.Windows.Forms.TextBox();
            this.SelectionBox = new System.Windows.Forms.ComboBox();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.bookSearchDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bookSearchDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(125, 23);
            this.Header.Text = "Search Book";
            // 
            // removeBtn
            // 
            this.removeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeBtn.BackgroundImage")));
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.removeBtn.Location = new System.Drawing.Point(563, 103);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(108, 34);
            this.removeBtn.TabIndex = 55;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editBtn.BackgroundImage")));
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.editBtn.Location = new System.Drawing.Point(563, 150);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(108, 34);
            this.editBtn.TabIndex = 54;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // BookTypeBox
            // 
            this.BookTypeBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.BookTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookTypeBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTypeBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BookTypeBox.FormattingEnabled = true;
            this.BookTypeBox.Items.AddRange(new object[] {
            "Fiction",
            "Non-Fiction",
            "Textbook",
            "Magazine"});
            this.BookTypeBox.Location = new System.Drawing.Point(13, 197);
            this.BookTypeBox.Margin = new System.Windows.Forms.Padding(4);
            this.BookTypeBox.Name = "BookTypeBox";
            this.BookTypeBox.Size = new System.Drawing.Size(253, 26);
            this.BookTypeBox.TabIndex = 53;
            // 
            // BookSearchTextBox
            // 
            this.BookSearchTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.BookSearchTextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookSearchTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BookSearchTextBox.Location = new System.Drawing.Point(13, 199);
            this.BookSearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BookSearchTextBox.Name = "BookSearchTextBox";
            this.BookSearchTextBox.Size = new System.Drawing.Size(353, 26);
            this.BookSearchTextBox.TabIndex = 52;
            // 
            // SelectionBox
            // 
            this.SelectionBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.SelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectionBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SelectionBox.FormattingEnabled = true;
            this.SelectionBox.Items.AddRange(new object[] {
            "Book Name",
            "Book ID",
            "Publisher",
            "Year",
            "Language",
            "Author",
            "Book Type",
            "Genre",
            "Location Number"});
            this.SelectionBox.Location = new System.Drawing.Point(13, 151);
            this.SelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.SelectionBox.Name = "SelectionBox";
            this.SelectionBox.Size = new System.Drawing.Size(253, 26);
            this.SelectionBox.TabIndex = 51;
            this.SelectionBox.TextChanged += new System.EventHandler(this.SelectionBox_TextChanged);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.QuestionLabel.Location = new System.Drawing.Point(13, 120);
            this.QuestionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(241, 18);
            this.QuestionLabel.TabIndex = 50;
            this.QuestionLabel.Text = "What are you searching for?";
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SearchButton.Location = new System.Drawing.Point(563, 198);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(108, 34);
            this.SearchButton.TabIndex = 49;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // bookSearchDGV
            // 
            this.bookSearchDGV.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.bookSearchDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookSearchDGV.GridColor = System.Drawing.SystemColors.Control;
            this.bookSearchDGV.Location = new System.Drawing.Point(13, 238);
            this.bookSearchDGV.Margin = new System.Windows.Forms.Padding(4);
            this.bookSearchDGV.Name = "bookSearchDGV";
            this.bookSearchDGV.Size = new System.Drawing.Size(658, 358);
            this.bookSearchDGV.TabIndex = 48;
            // 
            // SearchInBookMaintainance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 607);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.BookTypeBox);
            this.Controls.Add(this.BookSearchTextBox);
            this.Controls.Add(this.SelectionBox);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.bookSearchDGV);
            this.Name = "SearchInBookMaintainance";
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.bookSearchDGV, 0);
            this.Controls.SetChildIndex(this.SearchButton, 0);
            this.Controls.SetChildIndex(this.QuestionLabel, 0);
            this.Controls.SetChildIndex(this.SelectionBox, 0);
            this.Controls.SetChildIndex(this.BookSearchTextBox, 0);
            this.Controls.SetChildIndex(this.BookTypeBox, 0);
            this.Controls.SetChildIndex(this.editBtn, 0);
            this.Controls.SetChildIndex(this.removeBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bookSearchDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ComboBox BookTypeBox;
        private System.Windows.Forms.TextBox BookSearchTextBox;
        private System.Windows.Forms.ComboBox SelectionBox;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView bookSearchDGV;
    }
}
