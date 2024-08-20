namespace ParkMe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelSpace1 = new System.Windows.Forms.Panel();
            this.labelSpace1 = new System.Windows.Forms.Label();
            this.labelPlate1 = new System.Windows.Forms.Label();
            this.panelSpace2 = new System.Windows.Forms.Panel();
            this.labelSpace2 = new System.Windows.Forms.Label();
            this.labelPlate2 = new System.Windows.Forms.Label();
            this.panelSpace3 = new System.Windows.Forms.Panel();
            this.labelSpace3 = new System.Windows.Forms.Label();
            this.labelPlate3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNumberOfTakenSpaces = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSpace1
            // 
            this.panelSpace1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSpace1.Location = new System.Drawing.Point(25, 26);
            this.panelSpace1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSpace1.Name = "panelSpace1";
            this.panelSpace1.Size = new System.Drawing.Size(101, 66);
            this.panelSpace1.TabIndex = 0;
            // 
            // labelSpace1
            // 
            this.labelSpace1.AutoSize = true;
            this.labelSpace1.Location = new System.Drawing.Point(25, 94);
            this.labelSpace1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpace1.Name = "labelSpace1";
            this.labelSpace1.Size = new System.Drawing.Size(39, 13);
            this.labelSpace1.TabIndex = 1;
            this.labelSpace1.Text = "1: N/A";
            // 
            // labelPlate1
            // 
            this.labelPlate1.AutoSize = true;
            this.labelPlate1.Location = new System.Drawing.Point(25, 109);
            this.labelPlate1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlate1.Name = "labelPlate1";
            this.labelPlate1.Size = new System.Drawing.Size(68, 13);
            this.labelPlate1.TabIndex = 2;
            this.labelPlate1.Text = "Tablica: N/A";
            // 
            // panelSpace2
            // 
            this.panelSpace2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSpace2.Location = new System.Drawing.Point(150, 26);
            this.panelSpace2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSpace2.Name = "panelSpace2";
            this.panelSpace2.Size = new System.Drawing.Size(101, 66);
            this.panelSpace2.TabIndex = 3;
            // 
            // labelSpace2
            // 
            this.labelSpace2.AutoSize = true;
            this.labelSpace2.Location = new System.Drawing.Point(150, 94);
            this.labelSpace2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpace2.Name = "labelSpace2";
            this.labelSpace2.Size = new System.Drawing.Size(39, 13);
            this.labelSpace2.TabIndex = 4;
            this.labelSpace2.Text = "2: N/A";
            // 
            // labelPlate2
            // 
            this.labelPlate2.AutoSize = true;
            this.labelPlate2.Location = new System.Drawing.Point(150, 109);
            this.labelPlate2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlate2.Name = "labelPlate2";
            this.labelPlate2.Size = new System.Drawing.Size(68, 13);
            this.labelPlate2.TabIndex = 5;
            this.labelPlate2.Text = "Tablica: N/A";
            // 
            // panelSpace3
            // 
            this.panelSpace3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSpace3.Location = new System.Drawing.Point(275, 26);
            this.panelSpace3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSpace3.Name = "panelSpace3";
            this.panelSpace3.Size = new System.Drawing.Size(101, 66);
            this.panelSpace3.TabIndex = 6;
            // 
            // labelSpace3
            // 
            this.labelSpace3.AutoSize = true;
            this.labelSpace3.Location = new System.Drawing.Point(275, 94);
            this.labelSpace3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpace3.Name = "labelSpace3";
            this.labelSpace3.Size = new System.Drawing.Size(39, 13);
            this.labelSpace3.TabIndex = 7;
            this.labelSpace3.Text = "3: N/A";
            // 
            // labelPlate3
            // 
            this.labelPlate3.AutoSize = true;
            this.labelPlate3.Location = new System.Drawing.Point(275, 109);
            this.labelPlate3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlate3.Name = "labelPlate3";
            this.labelPlate3.Size = new System.Drawing.Size(68, 13);
            this.labelPlate3.TabIndex = 8;
            this.labelPlate3.Text = "Tablica: N/A";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumberOfTakenSpaces});
            this.statusStrip1.Location = new System.Drawing.Point(0, 160);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNumberOfTakenSpaces
            // 
            this.lblNumberOfTakenSpaces.Name = "lblNumberOfTakenSpaces";
            this.lblNumberOfTakenSpaces.Size = new System.Drawing.Size(67, 17);
            this.lblNumberOfTakenSpaces.Text = "0/3 zauzeto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 182);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelPlate3);
            this.Controls.Add(this.labelSpace3);
            this.Controls.Add(this.panelSpace3);
            this.Controls.Add(this.labelPlate2);
            this.Controls.Add(this.labelSpace2);
            this.Controls.Add(this.panelSpace2);
            this.Controls.Add(this.labelPlate1);
            this.Controls.Add(this.labelSpace1);
            this.Controls.Add(this.panelSpace1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Parkirna mjesta";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelSpace1;
        private System.Windows.Forms.Label labelSpace1;
        private System.Windows.Forms.Label labelPlate1;
        private System.Windows.Forms.Panel panelSpace2;
        private System.Windows.Forms.Label labelSpace2;
        private System.Windows.Forms.Label labelPlate2;
        private System.Windows.Forms.Panel panelSpace3;
        private System.Windows.Forms.Label labelSpace3;
        private System.Windows.Forms.Label labelPlate3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumberOfTakenSpaces;
    }
}
