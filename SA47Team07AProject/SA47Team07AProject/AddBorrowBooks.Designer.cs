namespace SA47Team07AProject
{
    partial class AddBorrowBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBorrowBooks));
            this.WrongDueDate = new System.Windows.Forms.Label();
            this.wrongBookID = new System.Windows.Forms.Label();
            this.BookNameT = new System.Windows.Forms.Label();
            this.DueDateD = new System.Windows.Forms.DateTimePicker();
            this.BorrowDateD = new System.Windows.Forms.DateTimePicker();
            this.CancelBorrow = new System.Windows.Forms.Button();
            this.SubmitBorrow = new System.Windows.Forms.Button();
            this.RemarkT = new System.Windows.Forms.TextBox();
            this.remarkL = new System.Windows.Forms.Label();
            this.DueDateL = new System.Windows.Forms.Label();
            this.borrowDateL = new System.Windows.Forms.Label();
            this.MemberName = new System.Windows.Forms.Label();
            this.BrowseBookID = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.bookIDL = new System.Windows.Forms.Label();
            this.bookIDT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(202, 23);
            this.Header.Text = "Adding Borrow Book";
            // 
            // WrongDueDate
            // 
            this.WrongDueDate.AutoSize = true;
            this.WrongDueDate.BackColor = System.Drawing.Color.Transparent;
            this.WrongDueDate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongDueDate.ForeColor = System.Drawing.Color.Red;
            this.WrongDueDate.Location = new System.Drawing.Point(194, 358);
            this.WrongDueDate.Name = "WrongDueDate";
            this.WrongDueDate.Size = new System.Drawing.Size(13, 18);
            this.WrongDueDate.TabIndex = 63;
            this.WrongDueDate.Text = ".";
            // 
            // wrongBookID
            // 
            this.wrongBookID.AutoSize = true;
            this.wrongBookID.BackColor = System.Drawing.Color.Transparent;
            this.wrongBookID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongBookID.ForeColor = System.Drawing.Color.Red;
            this.wrongBookID.Location = new System.Drawing.Point(195, 188);
            this.wrongBookID.Name = "wrongBookID";
            this.wrongBookID.Size = new System.Drawing.Size(13, 18);
            this.wrongBookID.TabIndex = 62;
            this.wrongBookID.Text = ".";
            // 
            // BookNameT
            // 
            this.BookNameT.AutoSize = true;
            this.BookNameT.BackColor = System.Drawing.Color.Transparent;
            this.BookNameT.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameT.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BookNameT.Location = new System.Drawing.Point(209, 211);
            this.BookNameT.Name = "BookNameT";
            this.BookNameT.Size = new System.Drawing.Size(13, 18);
            this.BookNameT.TabIndex = 61;
            this.BookNameT.Text = ".";
            // 
            // DueDateD
            // 
            this.DueDateD.CalendarForeColor = System.Drawing.Color.LavenderBlush;
            this.DueDateD.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.DueDateD.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DueDateD.Location = new System.Drawing.Point(193, 327);
            this.DueDateD.Name = "DueDateD";
            this.DueDateD.Size = new System.Drawing.Size(127, 22);
            this.DueDateD.TabIndex = 60;
            this.DueDateD.ValueChanged += new System.EventHandler(this.DueDateD_ValueChanged);
            // 
            // BorrowDateD
            // 
            this.BorrowDateD.CalendarForeColor = System.Drawing.Color.LavenderBlush;
            this.BorrowDateD.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.BorrowDateD.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.BorrowDateD.Enabled = false;
            this.BorrowDateD.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowDateD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BorrowDateD.Location = new System.Drawing.Point(193, 266);
            this.BorrowDateD.Name = "BorrowDateD";
            this.BorrowDateD.Size = new System.Drawing.Size(127, 22);
            this.BorrowDateD.TabIndex = 59;
            // 
            // CancelBorrow
            // 
            this.CancelBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBorrow.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBorrow.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CancelBorrow.Image = ((System.Drawing.Image)(resources.GetObject("CancelBorrow.Image")));
            this.CancelBorrow.Location = new System.Drawing.Point(387, 513);
            this.CancelBorrow.Name = "CancelBorrow";
            this.CancelBorrow.Size = new System.Drawing.Size(77, 34);
            this.CancelBorrow.TabIndex = 58;
            this.CancelBorrow.Text = "Cancel";
            this.CancelBorrow.UseVisualStyleBackColor = true;
            this.CancelBorrow.Click += new System.EventHandler(this.CancelBorrow_Click);
            // 
            // SubmitBorrow
            // 
            this.SubmitBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitBorrow.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBorrow.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SubmitBorrow.Image = ((System.Drawing.Image)(resources.GetObject("SubmitBorrow.Image")));
            this.SubmitBorrow.Location = new System.Drawing.Point(241, 513);
            this.SubmitBorrow.Name = "SubmitBorrow";
            this.SubmitBorrow.Size = new System.Drawing.Size(82, 34);
            this.SubmitBorrow.TabIndex = 57;
            this.SubmitBorrow.Text = "Submit";
            this.SubmitBorrow.UseVisualStyleBackColor = true;
            this.SubmitBorrow.Click += new System.EventHandler(this.SubmitBorrow_Click);
            // 
            // RemarkT
            // 
            this.RemarkT.BackColor = System.Drawing.Color.LavenderBlush;
            this.RemarkT.Location = new System.Drawing.Point(193, 391);
            this.RemarkT.Multiline = true;
            this.RemarkT.Name = "RemarkT";
            this.RemarkT.Size = new System.Drawing.Size(338, 93);
            this.RemarkT.TabIndex = 56;
            // 
            // remarkL
            // 
            this.remarkL.AutoSize = true;
            this.remarkL.BackColor = System.Drawing.Color.Transparent;
            this.remarkL.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarkL.ForeColor = System.Drawing.Color.SaddleBrown;
            this.remarkL.Location = new System.Drawing.Point(97, 391);
            this.remarkL.Name = "remarkL";
            this.remarkL.Size = new System.Drawing.Size(83, 18);
            this.remarkL.TabIndex = 55;
            this.remarkL.Text = "Remark :";
            // 
            // DueDateL
            // 
            this.DueDateL.AutoSize = true;
            this.DueDateL.BackColor = System.Drawing.Color.Transparent;
            this.DueDateL.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateL.ForeColor = System.Drawing.Color.SaddleBrown;
            this.DueDateL.Location = new System.Drawing.Point(88, 330);
            this.DueDateL.Name = "DueDateL";
            this.DueDateL.Size = new System.Drawing.Size(92, 18);
            this.DueDateL.TabIndex = 54;
            this.DueDateL.Text = "Due Date :";
            // 
            // borrowDateL
            // 
            this.borrowDateL.AutoSize = true;
            this.borrowDateL.BackColor = System.Drawing.Color.Transparent;
            this.borrowDateL.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDateL.ForeColor = System.Drawing.Color.SaddleBrown;
            this.borrowDateL.Location = new System.Drawing.Point(60, 269);
            this.borrowDateL.Name = "borrowDateL";
            this.borrowDateL.Size = new System.Drawing.Size(120, 18);
            this.borrowDateL.TabIndex = 53;
            this.borrowDateL.Text = "Borrow Date :";
            // 
            // MemberName
            // 
            this.MemberName.AutoSize = true;
            this.MemberName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.MemberName.Location = new System.Drawing.Point(181, 283);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(0, 18);
            this.MemberName.TabIndex = 52;
            // 
            // BrowseBookID
            // 
            this.BrowseBookID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrowseBookID.BackgroundImage")));
            this.BrowseBookID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BrowseBookID.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBookID.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BrowseBookID.Location = new System.Drawing.Point(359, 147);
            this.BrowseBookID.Name = "BrowseBookID";
            this.BrowseBookID.Size = new System.Drawing.Size(46, 34);
            this.BrowseBookID.TabIndex = 51;
            this.BrowseBookID.Text = ". . .";
            this.BrowseBookID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BrowseBookID.UseVisualStyleBackColor = true;
            this.BrowseBookID.Click += new System.EventHandler(this.BrowseBookID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(181, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 50;
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.BackColor = System.Drawing.Color.Transparent;
            this.bookName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bookName.Location = new System.Drawing.Point(70, 211);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(111, 18);
            this.bookName.TabIndex = 49;
            this.bookName.Text = "Book Name :";
            // 
            // bookIDL
            // 
            this.bookIDL.AutoSize = true;
            this.bookIDL.BackColor = System.Drawing.Color.Transparent;
            this.bookIDL.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIDL.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bookIDL.Location = new System.Drawing.Point(101, 157);
            this.bookIDL.Name = "bookIDL";
            this.bookIDL.Size = new System.Drawing.Size(79, 18);
            this.bookIDL.TabIndex = 48;
            this.bookIDL.Text = "BookID :";
            // 
            // bookIDT
            // 
            this.bookIDT.BackColor = System.Drawing.Color.LavenderBlush;
            this.bookIDT.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIDT.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bookIDT.Location = new System.Drawing.Point(193, 154);
            this.bookIDT.MaximumSize = new System.Drawing.Size(50, 34);
            this.bookIDT.MinimumSize = new System.Drawing.Size(150, 25);
            this.bookIDT.Name = "bookIDT";
            this.bookIDT.Size = new System.Drawing.Size(150, 25);
            this.bookIDT.TabIndex = 47;
            this.bookIDT.TextChanged += new System.EventHandler(this.bookIDT_TextChanged);
            // 
            // AddBorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(685, 607);
            this.Controls.Add(this.WrongDueDate);
            this.Controls.Add(this.wrongBookID);
            this.Controls.Add(this.BookNameT);
            this.Controls.Add(this.DueDateD);
            this.Controls.Add(this.BorrowDateD);
            this.Controls.Add(this.CancelBorrow);
            this.Controls.Add(this.SubmitBorrow);
            this.Controls.Add(this.RemarkT);
            this.Controls.Add(this.remarkL);
            this.Controls.Add(this.DueDateL);
            this.Controls.Add(this.borrowDateL);
            this.Controls.Add(this.MemberName);
            this.Controls.Add(this.BrowseBookID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.bookIDL);
            this.Controls.Add(this.bookIDT);
            this.Name = "AddBorrowBooks";
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.bookIDT, 0);
            this.Controls.SetChildIndex(this.bookIDL, 0);
            this.Controls.SetChildIndex(this.bookName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.BrowseBookID, 0);
            this.Controls.SetChildIndex(this.MemberName, 0);
            this.Controls.SetChildIndex(this.borrowDateL, 0);
            this.Controls.SetChildIndex(this.DueDateL, 0);
            this.Controls.SetChildIndex(this.remarkL, 0);
            this.Controls.SetChildIndex(this.RemarkT, 0);
            this.Controls.SetChildIndex(this.SubmitBorrow, 0);
            this.Controls.SetChildIndex(this.CancelBorrow, 0);
            this.Controls.SetChildIndex(this.BorrowDateD, 0);
            this.Controls.SetChildIndex(this.DueDateD, 0);
            this.Controls.SetChildIndex(this.BookNameT, 0);
            this.Controls.SetChildIndex(this.wrongBookID, 0);
            this.Controls.SetChildIndex(this.WrongDueDate, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WrongDueDate;
        private System.Windows.Forms.Label wrongBookID;
        private System.Windows.Forms.Label BookNameT;
        private System.Windows.Forms.DateTimePicker DueDateD;
        private System.Windows.Forms.DateTimePicker BorrowDateD;
        private System.Windows.Forms.Button CancelBorrow;
        private System.Windows.Forms.Button SubmitBorrow;
        private System.Windows.Forms.TextBox RemarkT;
        private System.Windows.Forms.Label remarkL;
        private System.Windows.Forms.Label DueDateL;
        private System.Windows.Forms.Label borrowDateL;
        private System.Windows.Forms.Label MemberName;
        private System.Windows.Forms.Button BrowseBookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.Label bookIDL;
        private System.Windows.Forms.TextBox bookIDT;
    }
}
