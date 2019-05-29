namespace hactonUI
{
    partial class importControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uplode = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uplode
            // 
            this.uplode.Location = new System.Drawing.Point(347, 233);
            this.uplode.Name = "uplode";
            this.uplode.Size = new System.Drawing.Size(121, 57);
            this.uplode.TabIndex = 0;
            this.uplode.Text = "uplode";
            this.uplode.UseVisualStyleBackColor = true;
            this.uplode.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(149, 233);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(121, 57);
            this.save.TabIndex = 0;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // importControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.save);
            this.Controls.Add(this.uplode);
            this.Name = "importControl";
            this.Size = new System.Drawing.Size(639, 345);
            this.Load += new System.EventHandler(this.importControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uplode;
        private System.Windows.Forms.Button save;
    }
}
