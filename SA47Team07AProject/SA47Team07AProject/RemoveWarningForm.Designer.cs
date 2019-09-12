namespace SA47Team07AProject
{
    partial class RemoveWarningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveWarningForm));
            this.noBtn = new System.Windows.Forms.Button();
            this.yesBtn = new System.Windows.Forms.Button();
            this.removalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(229, 23);
            this.Header.Text = "Remove Warning Form";
            // 
            // noBtn
            // 
            this.noBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("noBtn.BackgroundImage")));
            this.noBtn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.noBtn.Location = new System.Drawing.Point(404, 342);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(114, 34);
            this.noBtn.TabIndex = 50;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // yesBtn
            // 
            this.yesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yesBtn.BackgroundImage")));
            this.yesBtn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.yesBtn.Location = new System.Drawing.Point(194, 342);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(114, 34);
            this.yesBtn.TabIndex = 49;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // removalLabel
            // 
            this.removalLabel.BackColor = System.Drawing.Color.Transparent;
            this.removalLabel.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removalLabel.ForeColor = System.Drawing.Color.Red;
            this.removalLabel.Location = new System.Drawing.Point(50, 236);
            this.removalLabel.Name = "removalLabel";
            this.removalLabel.Size = new System.Drawing.Size(566, 87);
            this.removalLabel.TabIndex = 48;
            this.removalLabel.Text = "Do you confirm to execute the removal?";
            // 
            // RemoveWarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 607);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.removalLabel);
            this.Name = "RemoveWarningForm";
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.removalLabel, 0);
            this.Controls.SetChildIndex(this.yesBtn, 0);
            this.Controls.SetChildIndex(this.noBtn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Label removalLabel;
    }
}
