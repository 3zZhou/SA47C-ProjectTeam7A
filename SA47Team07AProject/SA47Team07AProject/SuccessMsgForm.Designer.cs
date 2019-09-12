namespace SA47Team07AProject
{
    partial class SuccessMsgForm
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
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(162, 23);
            this.Header.Text = "Success Message";
            // 
            // ErrorTextBox
            // 
            this.ErrorTextBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.ErrorTextBox.Text = "Success Page";
            // 
            // SuccessMsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.ClientSize = new System.Drawing.Size(463, 337);
            this.Name = "SuccessMsgForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
