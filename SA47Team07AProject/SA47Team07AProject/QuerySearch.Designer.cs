namespace SA47Team07AProject
{
    partial class QuerySearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuerySearch));
            this.BookTypeBox = new System.Windows.Forms.ComboBox();
            this.BookSearchTextBox = new System.Windows.Forms.TextBox();
            this.SelectionBox = new System.Windows.Forms.ComboBox();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(125, 23);
            this.Header.Text = "Search Book";
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
            this.BookTypeBox.Location = new System.Drawing.Point(14, 205);
            this.BookTypeBox.Name = "BookTypeBox";
            this.BookTypeBox.Size = new System.Drawing.Size(202, 26);
            this.BookTypeBox.TabIndex = 53;
            // 
            // BookSearchTextBox
            // 
            this.BookSearchTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.BookSearchTextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookSearchTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BookSearchTextBox.Location = new System.Drawing.Point(14, 206);
            this.BookSearchTextBox.Name = "BookSearchTextBox";
            this.BookSearchTextBox.Size = new System.Drawing.Size(313, 26);
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
            this.SelectionBox.Location = new System.Drawing.Point(14, 173);
            this.SelectionBox.Name = "SelectionBox";
            this.SelectionBox.Size = new System.Drawing.Size(202, 26);
            this.SelectionBox.TabIndex = 51;
            this.SelectionBox.TextChanged += new System.EventHandler(this.SelectionBox_TextChanged);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.QuestionLabel.Location = new System.Drawing.Point(9, 134);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(241, 18);
            this.QuestionLabel.TabIndex = 50;
            this.QuestionLabel.Text = "What are you searching for?";
            // 
            // OKButton
            // 
            this.OKButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OKButton.BackgroundImage")));
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.OKButton.Location = new System.Drawing.Point(500, 147);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(153, 34);
            this.OKButton.TabIndex = 49;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SearchButton.Location = new System.Drawing.Point(500, 206);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(153, 34);
            this.SearchButton.TabIndex = 48;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 342);
            this.dataGridView1.TabIndex = 47;
            // 
            // QuerySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 607);
            this.Controls.Add(this.BookTypeBox);
            this.Controls.Add(this.BookSearchTextBox);
            this.Controls.Add(this.SelectionBox);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuerySearch";
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.SearchButton, 0);
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.QuestionLabel, 0);
            this.Controls.SetChildIndex(this.SelectionBox, 0);
            this.Controls.SetChildIndex(this.BookSearchTextBox, 0);
            this.Controls.SetChildIndex(this.BookTypeBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BookTypeBox;
        private System.Windows.Forms.TextBox BookSearchTextBox;
        private System.Windows.Forms.ComboBox SelectionBox;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
