namespace SoftSensConfv2
{
    partial class AddMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.makerid = new System.Windows.Forms.TextBox();
            this.makername = new System.Windows.Forms.TextBox();
            this.newman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maker_ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maker_Name:";
            // 
            // makerid
            // 
            this.makerid.Location = new System.Drawing.Point(115, 44);
            this.makerid.Name = "makerid";
            this.makerid.Size = new System.Drawing.Size(100, 20);
            this.makerid.TabIndex = 3;
            // 
            // makername
            // 
            this.makername.Location = new System.Drawing.Point(115, 86);
            this.makername.Name = "makername";
            this.makername.Size = new System.Drawing.Size(100, 20);
            this.makername.TabIndex = 4;
            // 
            // newman
            // 
            this.newman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.newman.Location = new System.Drawing.Point(80, 129);
            this.newman.Name = "newman";
            this.newman.Size = new System.Drawing.Size(171, 30);
            this.newman.TabIndex = 5;
            this.newman.Text = "Add new Manufacturer";
            this.newman.UseVisualStyleBackColor = true;
            this.newman.Click += new System.EventHandler(this.newman_Click);
            // 
            // AddMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 203);
            this.Controls.Add(this.newman);
            this.Controls.Add(this.makername);
            this.Controls.Add(this.makerid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMan";
            this.Text = "USN SoftSensConf v2.0 - Add Manufacturer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox makerid;
        private System.Windows.Forms.TextBox makername;
        private System.Windows.Forms.Button newman;
    }
}