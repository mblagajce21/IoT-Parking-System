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
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblCarLocation = new System.Windows.Forms.Label();
            this.lblSpaceId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearchRegistration
            // 
            this.txtSearchRegistration.Location = new System.Drawing.Point(17, 30);
            this.txtSearchRegistration.Name = "txtSearchRegistration";
            this.txtSearchRegistration.Size = new System.Drawing.Size(161, 20);
            this.txtSearchRegistration.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(210, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Pretraži vozilo";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Location = new System.Drawing.Point(14, 9);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(111, 13);
            this.lblRegistration.TabIndex = 2;
            this.lblRegistration.Text = "Registracijska oznaka";
            // 
            // lblCarLocation
            // 
            this.lblCarLocation.AutoSize = true;
            this.lblCarLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarLocation.Location = new System.Drawing.Point(213, 74);
            this.lblCarLocation.Name = "lblCarLocation";
            this.lblCarLocation.Size = new System.Drawing.Size(63, 31);
            this.lblCarLocation.TabIndex = 3;
            this.lblCarLocation.Text = "N/A";
            // 
            // lblSpaceId
            // 
            this.lblSpaceId.AutoSize = true;
            this.lblSpaceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceId.Location = new System.Drawing.Point(54, 80);
            this.lblSpaceId.Name = "lblSpaceId";
            this.lblSpaceId.Size = new System.Drawing.Size(162, 20);
            this.lblSpaceId.TabIndex = 4;
            this.lblSpaceId.Text = "Broj parkirnog mjesta:";
            // 
            // frmSearchSpaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 129);
            this.Controls.Add(this.lblSpaceId);
            this.Controls.Add(this.lblCarLocation);
            this.Controls.Add(this.lblRegistration);
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
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblCarLocation;
        private System.Windows.Forms.Label lblSpaceId;
    }
}