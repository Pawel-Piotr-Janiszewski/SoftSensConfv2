namespace SoftSensConfv2
{
    partial class newdau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newdau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdcid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LocationID = new System.Windows.Forms.ComboBox();
            this.dauid = new System.Windows.Forms.TextBox();
            this.adddau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new DAU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "RDC_ID: ";
            // 
            // rdcid
            // 
            this.rdcid.AutoSize = true;
            this.rdcid.Location = new System.Drawing.Point(86, 68);
            this.rdcid.Name = "rdcid";
            this.rdcid.Size = new System.Drawing.Size(13, 17);
            this.rdcid.TabIndex = 2;
            this.rdcid.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location_id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "DAU_ID:";
            // 
            // LocationID
            // 
            this.LocationID.FormattingEnabled = true;
            this.LocationID.Location = new System.Drawing.Point(108, 100);
            this.LocationID.Name = "LocationID";
            this.LocationID.Size = new System.Drawing.Size(121, 25);
            this.LocationID.TabIndex = 5;
            // 
            // dauid
            // 
            this.dauid.Location = new System.Drawing.Point(108, 132);
            this.dauid.Name = "dauid";
            this.dauid.Size = new System.Drawing.Size(100, 23);
            this.dauid.TabIndex = 6;
            // 
            // adddau
            // 
            this.adddau.Location = new System.Drawing.Point(108, 174);
            this.adddau.Name = "adddau";
            this.adddau.Size = new System.Drawing.Size(121, 32);
            this.adddau.TabIndex = 7;
            this.adddau.Text = "Add new DAU";
            this.adddau.UseVisualStyleBackColor = true;
            this.adddau.Click += new System.EventHandler(this.adddau_Click);
            // 
            // newdau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 254);
            this.Controls.Add(this.adddau);
            this.Controls.Add(this.dauid);
            this.Controls.Add(this.LocationID);
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
            this.Name = "newdau";
            this.Text = "USN SoftSensConf v. 2.0 - Add new DAU";
            this.Load += new System.EventHandler(this.newdau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rdcid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox LocationID;
        private System.Windows.Forms.TextBox dauid;
        private System.Windows.Forms.Button adddau;
    }
}