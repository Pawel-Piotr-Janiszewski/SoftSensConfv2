namespace SoftSensConfv2
{
    partial class NewLoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLoc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddLoc = new System.Windows.Forms.Button();
            this.LocationID = new System.Windows.Forms.TextBox();
            this.Desc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(66, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location_ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location Description:";
            // 
            // AddLoc
            // 
            this.AddLoc.Location = new System.Drawing.Point(24, 135);
            this.AddLoc.Name = "AddLoc";
            this.AddLoc.Size = new System.Drawing.Size(130, 33);
            this.AddLoc.TabIndex = 3;
            this.AddLoc.Text = "Add new Location";
            this.AddLoc.UseVisualStyleBackColor = true;
            this.AddLoc.Click += new System.EventHandler(this.AddLoc_Click);
            // 
            // LocationID
            // 
            this.LocationID.Location = new System.Drawing.Point(168, 62);
            this.LocationID.Name = "LocationID";
            this.LocationID.Size = new System.Drawing.Size(100, 23);
            this.LocationID.TabIndex = 4;
            // 
            // Desc
            // 
            this.Desc.Location = new System.Drawing.Point(168, 99);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(100, 23);
            this.Desc.TabIndex = 5;
            // 
            // NewLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 223);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.LocationID);
            this.Controls.Add(this.AddLoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewLoc";
            this.Text = "UNS SoftSensConf v2.0 - Add New Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddLoc;
        private System.Windows.Forms.TextBox LocationID;
        private System.Windows.Forms.TextBox Desc;
    }
}