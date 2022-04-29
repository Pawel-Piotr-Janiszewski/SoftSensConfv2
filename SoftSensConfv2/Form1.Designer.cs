namespace SoftSensConfv2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartscreenCheckbox = new System.Windows.Forms.ComboBox();
            this.Continue_to_main = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOFTSENSCONF v2.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(83, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose your RDC_ID:";
            // 
            // StartscreenCheckbox
            // 
            this.StartscreenCheckbox.FormattingEnabled = true;
            this.StartscreenCheckbox.Location = new System.Drawing.Point(246, 87);
            this.StartscreenCheckbox.Name = "StartscreenCheckbox";
            this.StartscreenCheckbox.Size = new System.Drawing.Size(121, 21);
            this.StartscreenCheckbox.TabIndex = 2;
            // 
            // Continue_to_main
            // 
            this.Continue_to_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Continue_to_main.Location = new System.Drawing.Point(399, 87);
            this.Continue_to_main.Name = "Continue_to_main";
            this.Continue_to_main.Size = new System.Drawing.Size(194, 23);
            this.Continue_to_main.TabIndex = 3;
            this.Continue_to_main.Text = "Continue to the main menu";
            this.Continue_to_main.UseVisualStyleBackColor = true;
            this.Continue_to_main.Click += new System.EventHandler(this.Continue_to_main_Click);
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.About.Location = new System.Drawing.Point(399, 132);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(75, 23);
            this.About.TabIndex = 4;
            this.About.Text = "About ";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 225);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Continue_to_main);
            this.Controls.Add(this.StartscreenCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "USNSoftSensConf v2.0";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StartscreenCheckbox;
        private System.Windows.Forms.Button Continue_to_main;
        private System.Windows.Forms.Button About;
    }
}

