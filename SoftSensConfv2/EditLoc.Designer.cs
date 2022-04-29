namespace SoftSensConfv2
{
    partial class EditLoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLoc));
            this.label1 = new System.Windows.Forms.Label();
            this.Locationdata = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNewLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Locationdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(246, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "View/Add Locations";
            // 
            // Locationdata
            // 
            this.Locationdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Locationdata.Location = new System.Drawing.Point(62, 95);
            this.Locationdata.Name = "Locationdata";
            this.Locationdata.Size = new System.Drawing.Size(603, 286);
            this.Locationdata.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Avaiable Locations:";
            // 
            // AddNewLoc
            // 
            this.AddNewLoc.Location = new System.Drawing.Point(62, 387);
            this.AddNewLoc.Name = "AddNewLoc";
            this.AddNewLoc.Size = new System.Drawing.Size(131, 23);
            this.AddNewLoc.TabIndex = 3;
            this.AddNewLoc.Text = "Add New Location";
            this.AddNewLoc.UseVisualStyleBackColor = true;
            this.AddNewLoc.Click += new System.EventHandler(this.AddNewLoc_Click);
            // 
            // EditLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 565);
            this.Controls.Add(this.AddNewLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Locationdata);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditLoc";
            this.Text = "USN SoftSensConf v2.0 - View/Add Locations";
            this.Load += new System.EventHandler(this.EditLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Locationdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Locationdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddNewLoc;
    }
}