namespace OscarsTest
{
    partial class oscarform
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
            this.OscarButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OscarButon
            // 
            this.OscarButon.Location = new System.Drawing.Point(191, 70);
            this.OscarButon.Name = "OscarButon";
            this.OscarButon.Size = new System.Drawing.Size(75, 23);
            this.OscarButon.TabIndex = 0;
            this.OscarButon.Text = "Oscar";
            this.OscarButon.UseVisualStyleBackColor = true;
            // 
            // oscarform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OscarButon);
            this.Name = "oscarform";
            this.Text = "Oscar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OscarButon;
    }
}

