namespace SoftSensConfv2
{
    partial class Loadfromdb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loadfromdb));
            this.label1 = new System.Windows.Forms.Label();
            this.InstTagfromDB = new System.Windows.Forms.ComboBox();
            this.ConfInstTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your Instrument_Tag:";
            // 
            // InstTagfromDB
            // 
            this.InstTagfromDB.FormattingEnabled = true;
            this.InstTagfromDB.Location = new System.Drawing.Point(323, 97);
            this.InstTagfromDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InstTagfromDB.Name = "InstTagfromDB";
            this.InstTagfromDB.Size = new System.Drawing.Size(160, 25);
            this.InstTagfromDB.TabIndex = 1;
            // 
            // ConfInstTag
            // 
            this.ConfInstTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ConfInstTag.Location = new System.Drawing.Point(517, 88);
            this.ConfInstTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfInstTag.Name = "ConfInstTag";
            this.ConfInstTag.Size = new System.Drawing.Size(109, 41);
            this.ConfInstTag.TabIndex = 2;
            this.ConfInstTag.Text = "Confirm";
            this.ConfInstTag.UseVisualStyleBackColor = true;
            this.ConfInstTag.Click += new System.EventHandler(this.ConfInstTag_Click);
            // 
            // Loadfromdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 201);
            this.Controls.Add(this.ConfInstTag);
            this.Controls.Add(this.InstTagfromDB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loadfromdb";
            this.Text = "USN SoftSensConf v2.0 - Choose your Instrument_Tag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox InstTagfromDB;
        private System.Windows.Forms.Button ConfInstTag;
    }
}