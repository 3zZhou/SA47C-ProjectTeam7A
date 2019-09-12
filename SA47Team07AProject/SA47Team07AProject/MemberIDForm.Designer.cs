namespace SA47Team07AProject
{
    partial class MemberIDForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberIDForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SubmitBorrow = new System.Windows.Forms.Button();
            this.CancelBorrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(154, 23);
            this.Header.Text = "Search Member";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView1.Location = new System.Drawing.Point(150, 165);
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(359, 332);
            this.dataGridView1.TabIndex = 49;
            // 
            // SubmitBorrow
            // 
            this.SubmitBorrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubmitBorrow.BackgroundImage")));
            this.SubmitBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitBorrow.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBorrow.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SubmitBorrow.Location = new System.Drawing.Point(161, 532);
            this.SubmitBorrow.Name = "SubmitBorrow";
            this.SubmitBorrow.Size = new System.Drawing.Size(131, 34);
            this.SubmitBorrow.TabIndex = 58;
            this.SubmitBorrow.Text = "Submit";
            this.SubmitBorrow.UseVisualStyleBackColor = true;
            this.SubmitBorrow.Click += new System.EventHandler(this.SubmitBorrow_Click);
            // 
            // CancelBorrow
            // 
            this.CancelBorrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBorrow.BackgroundImage")));
            this.CancelBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBorrow.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBorrow.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CancelBorrow.Location = new System.Drawing.Point(379, 532);
            this.CancelBorrow.Name = "CancelBorrow";
            this.CancelBorrow.Size = new System.Drawing.Size(130, 34);
            this.CancelBorrow.TabIndex = 59;
            this.CancelBorrow.Text = "Cancel";
            this.CancelBorrow.UseVisualStyleBackColor = true;
            this.CancelBorrow.Click += new System.EventHandler(this.CancelBorrow_Click);
            // 
            // MemberIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 607);
            this.Controls.Add(this.CancelBorrow);
            this.Controls.Add(this.SubmitBorrow);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MemberIDForm";
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.SubmitBorrow, 0);
            this.Controls.SetChildIndex(this.CancelBorrow, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SubmitBorrow;
        private System.Windows.Forms.Button CancelBorrow;
    }
}
