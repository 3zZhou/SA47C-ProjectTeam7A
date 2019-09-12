namespace SA47Team07AProject
{
    partial class BookIDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookIDForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CancelBorrow = new System.Windows.Forms.Button();
            this.SubmitBorrow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(125, 23);
            this.Header.Text = "Search Book";
            // 
            // CancelBorrow
            // 
            this.CancelBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBorrow.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBorrow.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CancelBorrow.Image = ((System.Drawing.Image)(resources.GetObject("CancelBorrow.Image")));
            this.CancelBorrow.Location = new System.Drawing.Point(337, 531);
            this.CancelBorrow.Name = "CancelBorrow";
            this.CancelBorrow.Size = new System.Drawing.Size(77, 34);
            this.CancelBorrow.TabIndex = 62;
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
            this.SubmitBorrow.Location = new System.Drawing.Point(151, 531);
            this.SubmitBorrow.Name = "SubmitBorrow";
            this.SubmitBorrow.Size = new System.Drawing.Size(82, 34);
            this.SubmitBorrow.TabIndex = 61;
            this.SubmitBorrow.Text = "Submit";
            this.SubmitBorrow.UseVisualStyleBackColor = true;
            this.SubmitBorrow.Click += new System.EventHandler(this.SubmitBorrow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView1.Location = new System.Drawing.Point(135, 161);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(309, 332);
            this.dataGridView1.TabIndex = 60;
            // 
            // BookIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(686, 607);
            this.Controls.Add(this.CancelBorrow);
            this.Controls.Add(this.SubmitBorrow);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookIDForm";
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.SubmitBorrow, 0);
            this.Controls.SetChildIndex(this.CancelBorrow, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBorrow;
        private System.Windows.Forms.Button SubmitBorrow;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
