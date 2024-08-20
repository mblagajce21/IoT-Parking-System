namespace ParkMe
{
    partial class frmSearchSpaces
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
            this.txtSearchRegistration = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearchRegistration
            // 
            this.txtSearchRegistration.Location = new System.Drawing.Point(99, 39);
            this.txtSearchRegistration.Name = "txtSearchRegistration";
            this.txtSearchRegistration.Size = new System.Drawing.Size(161, 20);
            this.txtSearchRegistration.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(120, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Pretraži vozilo";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmSearchSpaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 135);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchRegistration);
            this.Name = "frmSearchSpaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pretraživanje mjesta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchRegistration;
        private System.Windows.Forms.Button btnSearch;
    }
}