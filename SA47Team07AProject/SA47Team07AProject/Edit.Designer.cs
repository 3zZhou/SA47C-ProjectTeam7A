namespace SA47Team07AProject
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.yearOfPublicationDTP = new System.Windows.Forms.DateTimePicker();
            this.shelfTB = new System.Windows.Forms.TextBox();
            this.shelfLabel = new System.Windows.Forms.Label();
            this.caseTB = new System.Windows.Forms.TextBox();
            this.caseLabel = new System.Windows.Forms.Label();
            this.levelTB = new System.Windows.Forms.TextBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.numberOfBooksBorrowedTB = new System.Windows.Forms.TextBox();
            this.totalStockTB = new System.Windows.Forms.TextBox();
            this.genreTB = new System.Windows.Forms.TextBox();
            this.bookTypeTB = new System.Windows.Forms.TextBox();
            this.languageTB = new System.Windows.Forms.TextBox();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.publisherTB = new System.Windows.Forms.TextBox();
            this.bookNameTB = new System.Windows.Forms.TextBox();
            this.bookIDTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalStockLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.bookTypeLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.yearOfPublicationLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.bookIDLabel = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Location = new System.Drawing.Point(33, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header.Size = new System.Drawing.Size(105, 23);
            this.Header.Text = "Edit Form";
            // 
            // yearOfPublicationDTP
            // 
            this.yearOfPublicationDTP.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.yearOfPublicationDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.yearOfPublicationDTP.Location = new System.Drawing.Point(296, 243);
            this.yearOfPublicationDTP.Name = "yearOfPublicationDTP";
            this.yearOfPublicationDTP.Size = new System.Drawing.Size(144, 22);
            this.yearOfPublicationDTP.TabIndex = 114;
            this.yearOfPublicationDTP.Value = new System.DateTime(2018, 9, 26, 13, 38, 43, 0);
            // 
            // shelfTB
            // 
            this.shelfTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.shelfTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.shelfTB.Location = new System.Drawing.Point(557, 451);
            this.shelfTB.Name = "shelfTB";
            this.shelfTB.Size = new System.Drawing.Size(52, 22);
            this.shelfTB.TabIndex = 110;
            this.shelfTB.Text = "0";
            // 
            // shelfLabel
            // 
            this.shelfLabel.AutoSize = true;
            this.shelfLabel.BackColor = System.Drawing.Color.Transparent;
            this.shelfLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shelfLabel.Location = new System.Drawing.Point(498, 453);
            this.shelfLabel.Name = "shelfLabel";
            this.shelfLabel.Size = new System.Drawing.Size(49, 16);
            this.shelfLabel.TabIndex = 113;
            this.shelfLabel.Text = "Shelf:";
            this.shelfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caseTB
            // 
            this.caseTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.caseTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.caseTB.Location = new System.Drawing.Point(423, 451);
            this.caseTB.Name = "caseTB";
            this.caseTB.Size = new System.Drawing.Size(52, 22);
            this.caseTB.TabIndex = 109;
            this.caseTB.Text = "0";
            // 
            // caseLabel
            // 
            this.caseLabel.AutoSize = true;
            this.caseLabel.BackColor = System.Drawing.Color.Transparent;
            this.caseLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseLabel.Location = new System.Drawing.Point(364, 453);
            this.caseLabel.Name = "caseLabel";
            this.caseLabel.Size = new System.Drawing.Size(46, 16);
            this.caseLabel.TabIndex = 112;
            this.caseLabel.Text = "Case:";
            this.caseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelTB
            // 
            this.levelTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.levelTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.levelTB.Location = new System.Drawing.Point(296, 451);
            this.levelTB.Name = "levelTB";
            this.levelTB.Size = new System.Drawing.Size(52, 22);
            this.levelTB.TabIndex = 108;
            this.levelTB.Text = "0";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.levelLabel.Location = new System.Drawing.Point(237, 453);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(53, 16);
            this.levelLabel.TabIndex = 111;
            this.levelLabel.Text = "Level:";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(439, 567);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(133, 34);
            this.cancelBtn.TabIndex = 107;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmBtn.BackgroundImage")));
            this.confirmBtn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(277, 567);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(133, 34);
            this.confirmBtn.TabIndex = 106;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // numberOfBooksBorrowedTB
            // 
            this.numberOfBooksBorrowedTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.numberOfBooksBorrowedTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.numberOfBooksBorrowedTB.Location = new System.Drawing.Point(296, 533);
            this.numberOfBooksBorrowedTB.Name = "numberOfBooksBorrowedTB";
            this.numberOfBooksBorrowedTB.Size = new System.Drawing.Size(52, 22);
            this.numberOfBooksBorrowedTB.TabIndex = 105;
            // 
            // totalStockTB
            // 
            this.totalStockTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.totalStockTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.totalStockTB.Location = new System.Drawing.Point(296, 492);
            this.totalStockTB.Name = "totalStockTB";
            this.totalStockTB.Size = new System.Drawing.Size(52, 22);
            this.totalStockTB.TabIndex = 104;
            // 
            // genreTB
            // 
            this.genreTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.genreTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.genreTB.Location = new System.Drawing.Point(296, 410);
            this.genreTB.Name = "genreTB";
            this.genreTB.Size = new System.Drawing.Size(240, 22);
            this.genreTB.TabIndex = 103;
            // 
            // bookTypeTB
            // 
            this.bookTypeTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.bookTypeTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.bookTypeTB.Location = new System.Drawing.Point(296, 369);
            this.bookTypeTB.Name = "bookTypeTB";
            this.bookTypeTB.Size = new System.Drawing.Size(240, 22);
            this.bookTypeTB.TabIndex = 102;
            // 
            // languageTB
            // 
            this.languageTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.languageTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.languageTB.Location = new System.Drawing.Point(296, 328);
            this.languageTB.Name = "languageTB";
            this.languageTB.Size = new System.Drawing.Size(240, 22);
            this.languageTB.TabIndex = 101;
            // 
            // authorTB
            // 
            this.authorTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.authorTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.authorTB.Location = new System.Drawing.Point(296, 287);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(240, 22);
            this.authorTB.TabIndex = 100;
            // 
            // publisherTB
            // 
            this.publisherTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.publisherTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.publisherTB.Location = new System.Drawing.Point(296, 205);
            this.publisherTB.Name = "publisherTB";
            this.publisherTB.Size = new System.Drawing.Size(240, 22);
            this.publisherTB.TabIndex = 99;
            // 
            // bookNameTB
            // 
            this.bookNameTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.bookNameTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.bookNameTB.Location = new System.Drawing.Point(296, 164);
            this.bookNameTB.Name = "bookNameTB";
            this.bookNameTB.Size = new System.Drawing.Size(240, 22);
            this.bookNameTB.TabIndex = 98;
            // 
            // bookIDTB
            // 
            this.bookIDTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.bookIDTB.Enabled = false;
            this.bookIDTB.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.bookIDTB.Location = new System.Drawing.Point(296, 123);
            this.bookIDTB.Name = "bookIDTB";
            this.bookIDTB.ReadOnly = true;
            this.bookIDTB.Size = new System.Drawing.Size(52, 22);
            this.bookIDTB.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(67, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Number of Books Borrowed:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalStockLabel
            // 
            this.totalStockLabel.AutoSize = true;
            this.totalStockLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalStockLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.totalStockLabel.Location = new System.Drawing.Point(190, 494);
            this.totalStockLabel.Name = "totalStockLabel";
            this.totalStockLabel.Size = new System.Drawing.Size(95, 16);
            this.totalStockLabel.TabIndex = 95;
            this.totalStockLabel.Text = "Total Stock:";
            this.totalStockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.BackColor = System.Drawing.Color.Transparent;
            this.genreLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.genreLabel.Location = new System.Drawing.Point(231, 412);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(57, 16);
            this.genreLabel.TabIndex = 94;
            this.genreLabel.Text = "Genre:";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookTypeLabel
            // 
            this.bookTypeLabel.AutoSize = true;
            this.bookTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookTypeLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTypeLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bookTypeLabel.Location = new System.Drawing.Point(197, 371);
            this.bookTypeLabel.Name = "bookTypeLabel";
            this.bookTypeLabel.Size = new System.Drawing.Size(90, 16);
            this.bookTypeLabel.TabIndex = 93;
            this.bookTypeLabel.Text = "Book Type:";
            this.bookTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.BackColor = System.Drawing.Color.Transparent;
            this.languageLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.languageLabel.Location = new System.Drawing.Point(202, 330);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(83, 16);
            this.languageLabel.TabIndex = 92;
            this.languageLabel.Text = "Language:";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.authorLabel.Location = new System.Drawing.Point(223, 289);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(66, 16);
            this.authorLabel.TabIndex = 91;
            this.authorLabel.Text = "Author:";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearOfPublicationLabel
            // 
            this.yearOfPublicationLabel.AutoSize = true;
            this.yearOfPublicationLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearOfPublicationLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOfPublicationLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.yearOfPublicationLabel.Location = new System.Drawing.Point(132, 248);
            this.yearOfPublicationLabel.Name = "yearOfPublicationLabel";
            this.yearOfPublicationLabel.Size = new System.Drawing.Size(151, 16);
            this.yearOfPublicationLabel.TabIndex = 90;
            this.yearOfPublicationLabel.Text = "Year of Publication:";
            this.yearOfPublicationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.BackColor = System.Drawing.Color.Transparent;
            this.publisherLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.publisherLabel.Location = new System.Drawing.Point(204, 207);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(83, 16);
            this.publisherLabel.TabIndex = 89;
            this.publisherLabel.Text = "Publisher:";
            this.publisherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookIDLabel
            // 
            this.bookIDLabel.AutoSize = true;
            this.bookIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookIDLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIDLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bookIDLabel.Location = new System.Drawing.Point(214, 125);
            this.bookIDLabel.Name = "bookIDLabel";
            this.bookIDLabel.Size = new System.Drawing.Size(71, 16);
            this.bookIDLabel.TabIndex = 88;
            this.bookIDLabel.Text = "Book ID:";
            this.bookIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookNameLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bookNameLabel.Location = new System.Drawing.Point(189, 166);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(95, 16);
            this.bookNameLabel.TabIndex = 87;
            this.bookNameLabel.Text = "Book Name:";
            this.bookNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.ClientSize = new System.Drawing.Size(684, 607);
            this.Controls.Add(this.yearOfPublicationDTP);
            this.Controls.Add(this.shelfTB);
            this.Controls.Add(this.shelfLabel);
            this.Controls.Add(this.caseTB);
            this.Controls.Add(this.caseLabel);
            this.Controls.Add(this.levelTB);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.numberOfBooksBorrowedTB);
            this.Controls.Add(this.totalStockTB);
            this.Controls.Add(this.genreTB);
            this.Controls.Add(this.bookTypeTB);
            this.Controls.Add(this.languageTB);
            this.Controls.Add(this.authorTB);
            this.Controls.Add(this.publisherTB);
            this.Controls.Add(this.bookNameTB);
            this.Controls.Add(this.bookIDTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalStockLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.bookTypeLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.yearOfPublicationLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.bookIDLabel);
            this.Controls.Add(this.bookNameLabel);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Name = "Edit";
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.bookNameLabel, 0);
            this.Controls.SetChildIndex(this.bookIDLabel, 0);
            this.Controls.SetChildIndex(this.publisherLabel, 0);
            this.Controls.SetChildIndex(this.yearOfPublicationLabel, 0);
            this.Controls.SetChildIndex(this.authorLabel, 0);
            this.Controls.SetChildIndex(this.languageLabel, 0);
            this.Controls.SetChildIndex(this.bookTypeLabel, 0);
            this.Controls.SetChildIndex(this.genreLabel, 0);
            this.Controls.SetChildIndex(this.totalStockLabel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.bookIDTB, 0);
            this.Controls.SetChildIndex(this.bookNameTB, 0);
            this.Controls.SetChildIndex(this.publisherTB, 0);
            this.Controls.SetChildIndex(this.authorTB, 0);
            this.Controls.SetChildIndex(this.languageTB, 0);
            this.Controls.SetChildIndex(this.bookTypeTB, 0);
            this.Controls.SetChildIndex(this.genreTB, 0);
            this.Controls.SetChildIndex(this.totalStockTB, 0);
            this.Controls.SetChildIndex(this.numberOfBooksBorrowedTB, 0);
            this.Controls.SetChildIndex(this.confirmBtn, 0);
            this.Controls.SetChildIndex(this.cancelBtn, 0);
            this.Controls.SetChildIndex(this.levelLabel, 0);
            this.Controls.SetChildIndex(this.levelTB, 0);
            this.Controls.SetChildIndex(this.caseLabel, 0);
            this.Controls.SetChildIndex(this.caseTB, 0);
            this.Controls.SetChildIndex(this.shelfLabel, 0);
            this.Controls.SetChildIndex(this.shelfTB, 0);
            this.Controls.SetChildIndex(this.yearOfPublicationDTP, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker yearOfPublicationDTP;
        private System.Windows.Forms.TextBox shelfTB;
        private System.Windows.Forms.Label shelfLabel;
        private System.Windows.Forms.TextBox caseTB;
        private System.Windows.Forms.Label caseLabel;
        private System.Windows.Forms.TextBox levelTB;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox numberOfBooksBorrowedTB;
        private System.Windows.Forms.TextBox totalStockTB;
        private System.Windows.Forms.TextBox genreTB;
        private System.Windows.Forms.TextBox bookTypeTB;
        private System.Windows.Forms.TextBox languageTB;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.TextBox publisherTB;
        private System.Windows.Forms.TextBox bookNameTB;
        private System.Windows.Forms.TextBox bookIDTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalStockLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label bookTypeLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label yearOfPublicationLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label bookIDLabel;
        private System.Windows.Forms.Label bookNameLabel;
    }
}
