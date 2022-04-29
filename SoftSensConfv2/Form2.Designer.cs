namespace SoftSensConfv2
{
    partial class Menu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Open_DAU = new System.Windows.Forms.Button();
            this.Open_Inst_conf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.curr_RDCval = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditMan = new System.Windows.Forms.Button();
            this.EditLoc = new System.Windows.Forms.Button();
            this.DataHandling = new System.Windows.Forms.Label();
            this.ViewData = new System.Windows.Forms.Button();
            this.LiveAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(296, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(567, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Configuration";
            // 
            // Open_DAU
            // 
            this.Open_DAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_DAU.Location = new System.Drawing.Point(536, 91);
            this.Open_DAU.Name = "Open_DAU";
            this.Open_DAU.Size = new System.Drawing.Size(186, 33);
            this.Open_DAU.TabIndex = 2;
            this.Open_DAU.Text = "Open DAU Configuration";
            this.Open_DAU.UseVisualStyleBackColor = true;
            this.Open_DAU.Click += new System.EventHandler(this.Open_DAU_Click);
            // 
            // Open_Inst_conf
            // 
            this.Open_Inst_conf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Open_Inst_conf.Location = new System.Drawing.Point(516, 145);
            this.Open_Inst_conf.Name = "Open_Inst_conf";
            this.Open_Inst_conf.Size = new System.Drawing.Size(216, 36);
            this.Open_Inst_conf.TabIndex = 3;
            this.Open_Inst_conf.Text = "Open Instrument Configuration";
            this.Open_Inst_conf.UseVisualStyleBackColor = true;
            this.Open_Inst_conf.Click += new System.EventHandler(this.Open_Inst_conf_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(654, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your RDC_ID:";
            // 
            // curr_RDCval
            // 
            this.curr_RDCval.AutoSize = true;
            this.curr_RDCval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.curr_RDCval.Location = new System.Drawing.Point(756, 270);
            this.curr_RDCval.Name = "curr_RDCval";
            this.curr_RDCval.Size = new System.Drawing.Size(16, 17);
            this.curr_RDCval.TabIndex = 5;
            this.curr_RDCval.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(66, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Administration";
            // 
            // EditMan
            // 
            this.EditMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.EditMan.Location = new System.Drawing.Point(27, 91);
            this.EditMan.Name = "EditMan";
            this.EditMan.Size = new System.Drawing.Size(181, 33);
            this.EditMan.TabIndex = 7;
            this.EditMan.Text = "View/Add Manufacturers";
            this.EditMan.UseVisualStyleBackColor = true;
            this.EditMan.Click += new System.EventHandler(this.EditMan_Click);
            // 
            // EditLoc
            // 
            this.EditLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.EditLoc.Location = new System.Drawing.Point(27, 145);
            this.EditLoc.Name = "EditLoc";
            this.EditLoc.Size = new System.Drawing.Size(181, 36);
            this.EditLoc.TabIndex = 8;
            this.EditLoc.Text = "View/Add Locations";
            this.EditLoc.UseVisualStyleBackColor = true;
            this.EditLoc.Click += new System.EventHandler(this.EditLoc_Click);
            // 
            // DataHandling
            // 
            this.DataHandling.AutoSize = true;
            this.DataHandling.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataHandling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.DataHandling.Location = new System.Drawing.Point(304, 55);
            this.DataHandling.Name = "DataHandling";
            this.DataHandling.Size = new System.Drawing.Size(106, 17);
            this.DataHandling.TabIndex = 9;
            this.DataHandling.Text = "DataHandling";
            // 
            // ViewData
            // 
            this.ViewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ViewData.Location = new System.Drawing.Point(268, 91);
            this.ViewData.Name = "ViewData";
            this.ViewData.Size = new System.Drawing.Size(195, 46);
            this.ViewData.TabIndex = 10;
            this.ViewData.Text = "View Data from DAU/Instrument";
            this.ViewData.UseVisualStyleBackColor = true;
            this.ViewData.Click += new System.EventHandler(this.ViewData_Click);
            // 
            // LiveAlarm
            // 
            this.LiveAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LiveAlarm.Location = new System.Drawing.Point(268, 145);
            this.LiveAlarm.Name = "LiveAlarm";
            this.LiveAlarm.Size = new System.Drawing.Size(195, 50);
            this.LiveAlarm.TabIndex = 11;
            this.LiveAlarm.Text = "Alarm Status of the DAU/Instrument";
            this.LiveAlarm.UseVisualStyleBackColor = true;
            this.LiveAlarm.Click += new System.EventHandler(this.LiveAlarm_Click);
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.LiveAlarm);
            this.Controls.Add(this.ViewData);
            this.Controls.Add(this.DataHandling);
            this.Controls.Add(this.EditLoc);
            this.Controls.Add(this.EditMan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.curr_RDCval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Open_Inst_conf);
            this.Controls.Add(this.Open_DAU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu1";
            this.Text = "USN SoftSensConf - Main Menu v 2.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu1_FormClosed);
            this.Load += new System.EventHandler(this.Menu1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Open_DAU;
        private System.Windows.Forms.Button Open_Inst_conf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label curr_RDCval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditMan;
        private System.Windows.Forms.Button EditLoc;
        private System.Windows.Forms.Label DataHandling;
        private System.Windows.Forms.Button ViewData;
        private System.Windows.Forms.Button LiveAlarm;
    }
}