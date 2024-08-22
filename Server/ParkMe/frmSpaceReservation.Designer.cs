namespace ParkMe
{
    partial class frmSpaceReservation
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
            this.cbParkingSpaces = new System.Windows.Forms.ComboBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbParkingSpaces
            // 
            this.cbParkingSpaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParkingSpaces.FormattingEnabled = true;
            this.cbParkingSpaces.Location = new System.Drawing.Point(12, 12);
            this.cbParkingSpaces.Name = "cbParkingSpaces";
            this.cbParkingSpaces.Size = new System.Drawing.Size(200, 21);
            this.cbParkingSpaces.TabIndex = 0;
            this.cbParkingSpaces.SelectedIndexChanged += new System.EventHandler(this.cbParkingSpaces_SelectedIndexChanged);
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(12, 50);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(200, 20);
            this.txtLicensePlate.TabIndex = 1;
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Location = new System.Drawing.Point(12, 90);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(95, 23);
            this.btnAddOrUpdate.TabIndex = 2;
            this.btnAddOrUpdate.Text = "Dodaj/Ažuriraj";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(117, 90);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Obriši";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmSpaceReservation
            // 
            this.ClientSize = new System.Drawing.Size(224, 131);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.cbParkingSpaces);
            this.Name = "frmSpaceReservation";
            this.Text = "Space Reservation";
            this.Load += new System.EventHandler(this.frmSpaceReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbParkingSpaces;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}