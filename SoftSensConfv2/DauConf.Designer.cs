namespace SoftSensConfv2
{
    partial class DauConf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DauConf));
            this.label1 = new System.Windows.Forms.Label();
            this.EditDAU = new System.Windows.Forms.Button();
            this.AddNewDau = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Currrdcid = new System.Windows.Forms.Label();
            this.avaiabledau = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.avaiabledau)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAU Configuration";
            // 
            // EditDAU
            // 
            this.EditDAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.EditDAU.Location = new System.Drawing.Point(13, 61);
            this.EditDAU.Name = "EditDAU";
            this.EditDAU.Size = new System.Drawing.Size(139, 47);
            this.EditDAU.TabIndex = 1;
            this.EditDAU.Text = "Change location of the existing DAU";
            this.EditDAU.UseVisualStyleBackColor = true;
            this.EditDAU.Click += new System.EventHandler(this.EditDAU_Click);
            // 
            // AddNewDau
            // 
            this.AddNewDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.AddNewDau.Location = new System.Drawing.Point(13, 123);
            this.AddNewDau.Name = "AddNewDau";
            this.AddNewDau.Size = new System.Drawing.Size(139, 34);
            this.AddNewDau.TabIndex = 2;
            this.AddNewDau.Text = "Add new DAU";
            this.AddNewDau.UseVisualStyleBackColor = true;
            this.AddNewDau.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(216, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Avaiable DAUs for your RDC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(469, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your RDC_ID :";
            // 
            // Currrdcid
            // 
            this.Currrdcid.AutoSize = true;
            this.Currrdcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Currrdcid.Location = new System.Drawing.Point(576, 371);
            this.Currrdcid.Name = "Currrdcid";
            this.Currrdcid.Size = new System.Drawing.Size(13, 17);
            this.Currrdcid.TabIndex = 6;
            this.Currrdcid.Text = "-";
            // 
            // avaiabledau
            // 
            this.avaiabledau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avaiabledau.Location = new System.Drawing.Point(219, 63);
            this.avaiabledau.Name = "avaiabledau";
            this.avaiabledau.Size = new System.Drawing.Size(461, 234);
            this.avaiabledau.TabIndex = 7;
            // 
            // DauConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 397);
            this.Controls.Add(this.avaiabledau);
            this.Controls.Add(this.Currrdcid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddNewDau);
            this.Controls.Add(this.EditDAU);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DauConf";
            this.Text = "USN SoftSensConf v2.0 - Dau Configuration";
            this.Load += new System.EventHandler(this.DauConf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avaiabledau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditDAU;
        private System.Windows.Forms.Button AddNewDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Currrdcid;
        private System.Windows.Forms.DataGridView avaiabledau;
    }
}