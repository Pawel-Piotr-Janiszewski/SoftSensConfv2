namespace SoftSensConfv2
{
    partial class EditDAU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDAU));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdcid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Locationid = new System.Windows.Forms.ComboBox();
            this.DAUID = new System.Windows.Forms.ComboBox();
            this.UpdateDAU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change DAU\'s Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "RDC_ID:";
            // 
            // rdcid
            // 
            this.rdcid.AutoSize = true;
            this.rdcid.Location = new System.Drawing.Point(82, 59);
            this.rdcid.Name = "rdcid";
            this.rdcid.Size = new System.Drawing.Size(13, 17);
            this.rdcid.TabIndex = 2;
            this.rdcid.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location_ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "DAU_ID:";
            // 
            // Locationid
            // 
            this.Locationid.FormattingEnabled = true;
            this.Locationid.Location = new System.Drawing.Point(106, 92);
            this.Locationid.Name = "Locationid";
            this.Locationid.Size = new System.Drawing.Size(121, 25);
            this.Locationid.TabIndex = 5;
            // 
            // DAUID
            // 
            this.DAUID.FormattingEnabled = true;
            this.DAUID.Location = new System.Drawing.Point(106, 128);
            this.DAUID.Name = "DAUID";
            this.DAUID.Size = new System.Drawing.Size(121, 25);
            this.DAUID.TabIndex = 6;
            // 
            // UpdateDAU
            // 
            this.UpdateDAU.Location = new System.Drawing.Point(106, 184);
            this.UpdateDAU.Name = "UpdateDAU";
            this.UpdateDAU.Size = new System.Drawing.Size(121, 34);
            this.UpdateDAU.TabIndex = 7;
            this.UpdateDAU.Text = "Update Location";
            this.UpdateDAU.UseVisualStyleBackColor = true;
            this.UpdateDAU.Click += new System.EventHandler(this.UpdateDAU_Click);
            // 
            // EditDAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 275);
            this.Controls.Add(this.UpdateDAU);
            this.Controls.Add(this.DAUID);
            this.Controls.Add(this.Locationid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdcid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDAU";
            this.Text = "USN SoftSensConf v2.0 Edit Existing DAU";
            this.Load += new System.EventHandler(this.EditDAU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rdcid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Locationid;
        private System.Windows.Forms.ComboBox DAUID;
        private System.Windows.Forms.Button UpdateDAU;
    }
}