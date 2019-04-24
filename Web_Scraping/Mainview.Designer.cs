namespace Web_Scraping
{
    partial class Mainview
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
            this.MovieslistBox = new System.Windows.Forms.ListBox();
            this.Movieslabel = new System.Windows.Forms.Label();
            this.Selectmoviebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MovieslistBox
            // 
            this.MovieslistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieslistBox.FormattingEnabled = true;
            this.MovieslistBox.ItemHeight = 25;
            this.MovieslistBox.Location = new System.Drawing.Point(127, 12);
            this.MovieslistBox.Name = "MovieslistBox";
            this.MovieslistBox.Size = new System.Drawing.Size(412, 404);
            this.MovieslistBox.TabIndex = 0;
            // 
            // Movieslabel
            // 
            this.Movieslabel.AutoSize = true;
            this.Movieslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movieslabel.Location = new System.Drawing.Point(13, 54);
            this.Movieslabel.Name = "Movieslabel";
            this.Movieslabel.Size = new System.Drawing.Size(75, 25);
            this.Movieslabel.TabIndex = 1;
            this.Movieslabel.Text = "Movies";
            // 
            // Selectmoviebutton
            // 
            this.Selectmoviebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectmoviebutton.Location = new System.Drawing.Point(556, 54);
            this.Selectmoviebutton.Name = "Selectmoviebutton";
            this.Selectmoviebutton.Size = new System.Drawing.Size(153, 60);
            this.Selectmoviebutton.TabIndex = 2;
            this.Selectmoviebutton.Text = "Select";
            this.Selectmoviebutton.UseVisualStyleBackColor = true;
            this.Selectmoviebutton.Click += new System.EventHandler(this.Selectmoviebutton_Click);
            // 
            // Mainview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 501);
            this.Controls.Add(this.Selectmoviebutton);
            this.Controls.Add(this.Movieslabel);
            this.Controls.Add(this.MovieslistBox);
            this.Name = "Mainview";
            this.Text = "Main View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MovieslistBox;
        private System.Windows.Forms.Label Movieslabel;
        private System.Windows.Forms.Button Selectmoviebutton;
    }
}