namespace SA47Team07AProject
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.shelfCB = new System.Windows.Forms.ComboBox();
            this.caseCB = new System.Windows.Forms.ComboBox();
            this.levelCB = new System.Windows.Forms.ComboBox();
            this.bookIDTB = new System.Windows.Forms.TextBox();
            this.bookIDLabel = new System.Windows.Forms.Label();
            this.shelfLabel = new System.Windows.Forms.Label();
            this.caseLabel = new System.Windows.Forms.Label();
            this.yearOfPublicationDTP = new System.Windows.Forms.DateTimePicker();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.numberOfBooksBorrowedTB = new System.Windows.Forms.TextBox();
            this.totalStockTB = new System.Windows.Forms.TextBox();
            this.genreTB = new System.Windows.Forms.TextBox();
            this.bookTypeTB = new System.Windows.Forms.TextBox();
            this.languageTB = new System.Windows.Forms.TextBox();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.publisherTB = new System.Windows.Forms.TextBox();
            this.bookNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalStockLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.bookTypeLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.yearOfPublicationLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Size = new System.Drawing.Size(100, 23);
            this.Header.Text = "Add Book";
            // 
            // shelfCB
            // 
            this.shelfCB.BackColor = System.Drawing.Color.LavenderBlush;
            this.shelfCB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.shelfCB.FormattingEnabled = true;
            this.shelfCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.shelfCB.Location = new System.Drawing.Point(547, 435);
            this.shelfCB.Name = "shelfCB";
            this.shelfCB.Size = new System.Drawing.Size(52, 24);
            this.shelfCB.TabIndex = 112;
            // 
            // caseCB
            // 
            this.caseCB.BackColor = System.Drawing.Color.LavenderBlush;
            this.caseCB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.caseCB.FormattingEnabled = true;
            this.caseCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.caseCB.Location = new System.Drawing.Point(409, 435);
            this.caseCB.Name = "caseCB";
            this.caseCB.Size = new System.Drawing.Size(52, 24);
            this.caseCB.TabIndex = 111;
            // 
            // levelCB
            // 
            this.levelCB.BackColor = System.Drawing.Color.LavenderBlush;
            this.levelCB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.levelCB.FormattingEnabled = true;
            this.levelCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.levelCB.Location = new System.Drawing.Point(286, 435);
            this.levelCB.Name = "levelCB";
            this.levelCB.Size = new System.Drawing.Size(52, 24);
            this.levelCB.TabIndex = 110;
            // 
            // bookIDTB
            // 
            this.bookIDTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.bookIDTB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIDTB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bookIDTB.Location = new System.Drawing.Point(286, 107);
            this.bookIDTB.Name = "bookIDTB";
            this.bookIDTB.ReadOnly = true;
            this.bookIDTB.Size = new System.Drawing.Size(52, 22);
            this.bookIDTB.TabIndex = 109;
            // 
            // bookIDLabel
            // 
            this.bookIDLabel.AutoSize = true;
            this.bookIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookIDLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIDLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bookIDLabel.Location = new System.Drawing.Point(204, 109);
            this.bookIDLabel.Name = "bookIDLabel";
            this.bookIDLabel.Size = new System.Drawing.Size(71, 16);
            this.bookIDLabel.TabIndex = 108;
            this.bookIDLabel.Text = "Book ID:";
            this.bookIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shelfLabel
            // 
            this.shelfLabel.AutoSize = true;
            this.shelfLabel.BackColor = System.Drawing.Color.Transparent;
            this.shelfLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shelfLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.shelfLabel.Location = new System.Drawing.Point(488, 437);
            this.shelfLabel.Name = "shelfLabel";
            this.shelfLabel.Size = new System.Drawing.Size(49, 16);
            this.shelfLabel.TabIndex = 107;
            this.shelfLabel.Text = "Shelf:";
            this.shelfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caseLabel
            // 
            this.caseLabel.AutoSize = true;
            this.caseLabel.BackColor = System.Drawing.Color.Transparent;
            this.caseLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.caseLabel.Location = new System.Drawing.Point(354, 437);
            this.caseLabel.Name = "caseLabel";
            this.caseLabel.Size = new System.Drawing.Size(46, 16);
            this.caseLabel.TabIndex = 106;
            this.caseLabel.Text = "Case:";
            this.caseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearOfPublicationDTP
            // 
            this.yearOfPublicationDTP.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.yearOfPublicationDTP.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.yearOfPublicationDTP.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.yearOfPublicationDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.yearOfPublicationDTP.Location = new System.Drawing.Point(286, 227);
            this.yearOfPublicationDTP.Name = "yearOfPublicationDTP";
            this.yearOfPublicationDTP.Size = new System.Drawing.Size(134, 22);
            this.yearOfPublicationDTP.TabIndex = 87;
            this.yearOfPublicationDTP.Value = new System.DateTime(2018, 9, 26, 13, 38, 43, 0);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmBtn.BackgroundImage")));
            this.confirmBtn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.confirmBtn.Location = new System.Drawing.Point(275, 561);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(125, 34);
            this.confirmBtn.TabIndex = 94;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cancelBtn.Location = new System.Drawing.Point(422, 561);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(125, 34);
            this.cancelBtn.TabIndex = 95;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // numberOfBooksBorrowedTB
            // 
            this.numberOfBooksBorrowedTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.numberOfBooksBorrowedTB.Enabled = false;
            this.numberOfBooksBorrowedTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.numberOfBooksBorrowedTB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.numberOfBooksBorrowedTB.Location = new System.Drawing.Point(286, 517);
            this.numberOfBooksBorrowedTB.Name = "numberOfBooksBorrowedTB";
            this.numberOfBooksBorrowedTB.ReadOnly = true;
            this.numberOfBooksBorrowedTB.Size = new System.Drawing.Size(52, 22);
            this.numberOfBooksBorrowedTB.TabIndex = 93;
            this.numberOfBooksBorrowedTB.Text = "0";
            // 
            // totalStockTB
            // 
            this.totalStockTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.totalStockTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.totalStockTB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.totalStockTB.Location = new System.Drawing.Point(286, 476);
            this.totalStockTB.Name = "totalStockTB";
            this.totalStockTB.Size = new System.Drawing.Size(52, 22);
            this.totalStockTB.TabIndex = 92;
            this.totalStockTB.Text = "0";
            this.totalStockTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.totalStockTB_MouseClick);
            // 
            // genreTB
            // 
            this.genreTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.genreTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.genreTB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.genreTB.Location = new System.Drawing.Point(286, 394);
            this.genreTB.Name = "genreTB";
            this.genreTB.Size = new System.Drawing.Size(240, 22);
            this.genreTB.TabIndex = 91;
            this.genreTB.Text = "Input genre";
            this.genreTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.genreTB_MouseClick);
            // 
            // bookTypeTB
            // 
            this.bookTypeTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.bookTypeTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.bookTypeTB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bookTypeTB.Location = new System.Drawing.Point(286, 353);
            this.bookTypeTB.Name = "bookTypeTB";
            this.bookTypeTB.Size = new System.Drawing.Size(240, 22);
            this.bookTypeTB.TabIndex = 90;
            this.bookTypeTB.Text = "Input book type";
            this.bookTypeTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bookTypeTB_MouseClick);
            // 
            // languageTB
            // 
            this.languageTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.languageTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.languageTB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.languageTB.Location = new System.Drawing.Point(286, 312);
            this.languageTB.Name = "languageTB";
            this.languageTB.Size = new System.Drawing.Size(240, 22);
            this.languageTB.TabIndex = 89;
            this.languageTB.Text = "Input language";
            this.languageTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.languageTB_MouseClick);
            // 
            // authorTB
            // 
            this.authorTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.authorTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.authorTB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.authorTB.Location = new System.Drawing.Point(286, 271);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(240, 22);
            this.authorTB.TabIndex = 88;
            this.authorTB.Text = "Input author";
            this.authorTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.authorTB_MouseClick);
            // 
            // publisherTB
            // 
            this.publisherTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.publisherTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.publisherTB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.publisherTB.Location = new System.Drawing.Point(286, 189);
            this.publisherTB.Name = "publisherTB";
            this.publisherTB.Size = new System.Drawing.Size(240, 22);
            this.publisherTB.TabIndex = 86;
            this.publisherTB.Text = "Input publisher";
            this.publisherTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.publisherTB_MouseClick);
            // 
            // bookNameTB
            // 
            this.bookNameTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.bookNameTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.bookNameTB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bookNameTB.Location = new System.Drawing.Point(286, 148);
            this.bookNameTB.Name = "bookNameTB";
            this.bookNameTB.Size = new System.Drawing.Size(240, 22);
            this.bookNameTB.TabIndex = 85;
            this.bookNameTB.Text = "Input new book name";
            this.bookNameTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bookNameTB_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(62, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Number of Books Borrowed:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalStockLabel
            // 
            this.totalStockLabel.AutoSize = true;
            this.totalStockLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalStockLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.totalStockLabel.Location = new System.Drawing.Point(178, 479);
            this.totalStockLabel.Name = "totalStockLabel";
            this.totalStockLabel.Size = new System.Drawing.Size(95, 16);
            this.totalStockLabel.TabIndex = 104;
            this.totalStockLabel.Text = "Total Stock:";
            this.totalStockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.levelLabel.Location = new System.Drawing.Point(220, 437);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(53, 16);
            this.levelLabel.TabIndex = 103;
            this.levelLabel.Text = "Level:";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.BackColor = System.Drawing.Color.Transparent;
            this.genreLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.genreLabel.Location = new System.Drawing.Point(216, 394);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(57, 16);
            this.genreLabel.TabIndex = 102;
            this.genreLabel.Text = "Genre:";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookTypeLabel
            // 
            this.bookTypeLabel.AutoSize = true;
            this.bookTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookTypeLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTypeLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bookTypeLabel.Location = new System.Drawing.Point(187, 355);
            this.bookTypeLabel.Name = "bookTypeLabel";
            this.bookTypeLabel.Size = new System.Drawing.Size(90, 16);
            this.bookTypeLabel.TabIndex = 101;
            this.bookTypeLabel.Text = "Book Type:";
            this.bookTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.BackColor = System.Drawing.Color.Transparent;
            this.languageLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.languageLabel.Location = new System.Drawing.Point(192, 315);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(83, 16);
            this.languageLabel.TabIndex = 100;
            this.languageLabel.Text = "Language:";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.authorLabel.Location = new System.Drawing.Point(207, 271);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(66, 16);
            this.authorLabel.TabIndex = 99;
            this.authorLabel.Text = "Author:";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearOfPublicationLabel
            // 
            this.yearOfPublicationLabel.AutoSize = true;
            this.yearOfPublicationLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearOfPublicationLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOfPublicationLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.yearOfPublicationLabel.Location = new System.Drawing.Point(122, 232);
            this.yearOfPublicationLabel.Name = "yearOfPublicationLabel";
            this.yearOfPublicationLabel.Size = new System.Drawing.Size(151, 16);
            this.yearOfPublicationLabel.TabIndex = 98;
            this.yearOfPublicationLabel.Text = "Year of Publication:";
            this.yearOfPublicationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.BackColor = System.Drawing.Color.Transparent;
            this.publisherLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.publisherLabel.Location = new System.Drawing.Point(192, 189);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(83, 16);
            this.publisherLabel.TabIndex = 97;
            this.publisherLabel.Text = "Publisher:";
            this.publisherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookNameLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bookNameLabel.Location = new System.Drawing.Point(178, 148);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(95, 16);
            this.bookNameLabel.TabIndex = 96;
            this.bookNameLabel.Text = "Book Name:";
            this.bookNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 607);
            this.Controls.Add(this.shelfCB);
            this.Controls.Add(this.caseCB);
            this.Controls.Add(this.levelCB);
            this.Controls.Add(this.bookIDTB);
            this.Controls.Add(this.bookIDLabel);
            this.Controls.Add(this.shelfLabel);
            this.Controls.Add(this.caseLabel);
            this.Controls.Add(this.yearOfPublicationDTP);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.numberOfBooksBorrowedTB);
            this.Controls.Add(this.totalStockTB);
            this.Controls.Add(this.genreTB);
            this.Controls.Add(this.bookTypeTB);
            this.Controls.Add(this.languageTB);
            this.Controls.Add(this.authorTB);
            this.Controls.Add(this.publisherTB);
            this.Controls.Add(this.bookNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalStockLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.bookTypeLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.yearOfPublicationLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.bookNameLabel);
            this.Name = "Add";
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.bookNameLabel, 0);
            this.Controls.SetChildIndex(this.publisherLabel, 0);
            this.Controls.SetChildIndex(this.yearOfPublicationLabel, 0);
            this.Controls.SetChildIndex(this.authorLabel, 0);
            this.Controls.SetChildIndex(this.languageLabel, 0);
            this.Controls.SetChildIndex(this.bookTypeLabel, 0);
            this.Controls.SetChildIndex(this.genreLabel, 0);
            this.Controls.SetChildIndex(this.levelLabel, 0);
            this.Controls.SetChildIndex(this.totalStockLabel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.bookNameTB, 0);
            this.Controls.SetChildIndex(this.publisherTB, 0);
            this.Controls.SetChildIndex(this.authorTB, 0);
            this.Controls.SetChildIndex(this.languageTB, 0);
            this.Controls.SetChildIndex(this.bookTypeTB, 0);
            this.Controls.SetChildIndex(this.genreTB, 0);
            this.Controls.SetChildIndex(this.totalStockTB, 0);
            this.Controls.SetChildIndex(this.numberOfBooksBorrowedTB, 0);
            this.Controls.SetChildIndex(this.cancelBtn, 0);
            this.Controls.SetChildIndex(this.confirmBtn, 0);
            this.Controls.SetChildIndex(this.yearOfPublicationDTP, 0);
            this.Controls.SetChildIndex(this.caseLabel, 0);
            this.Controls.SetChildIndex(this.shelfLabel, 0);
            this.Controls.SetChildIndex(this.bookIDLabel, 0);
            this.Controls.SetChildIndex(this.bookIDTB, 0);
            this.Controls.SetChildIndex(this.levelCB, 0);
            this.Controls.SetChildIndex(this.caseCB, 0);
            this.Controls.SetChildIndex(this.shelfCB, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox shelfCB;
        private System.Windows.Forms.ComboBox caseCB;
        private System.Windows.Forms.ComboBox levelCB;
        private System.Windows.Forms.TextBox bookIDTB;
        private System.Windows.Forms.Label bookIDLabel;
        private System.Windows.Forms.Label shelfLabel;
        private System.Windows.Forms.Label caseLabel;
        private System.Windows.Forms.DateTimePicker yearOfPublicationDTP;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox numberOfBooksBorrowedTB;
        private System.Windows.Forms.TextBox totalStockTB;
        private System.Windows.Forms.TextBox genreTB;
        private System.Windows.Forms.TextBox bookTypeTB;
        private System.Windows.Forms.TextBox languageTB;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.TextBox publisherTB;
        private System.Windows.Forms.TextBox bookNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalStockLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label bookTypeLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label yearOfPublicationLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label bookNameLabel;
    }
}
