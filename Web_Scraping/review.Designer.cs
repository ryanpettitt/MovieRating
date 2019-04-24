namespace Web_Scraping
{
    partial class review
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
            this.Movienamelabel = new System.Windows.Forms.Label();
            this.discriptionlabel = new System.Windows.Forms.Label();
            this.reviewtextBox = new System.Windows.Forms.TextBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Movienamelabel
            // 
            this.Movienamelabel.AutoSize = true;
            this.Movienamelabel.Location = new System.Drawing.Point(43, 35);
            this.Movienamelabel.Name = "Movienamelabel";
            this.Movienamelabel.Size = new System.Drawing.Size(42, 25);
            this.Movienamelabel.TabIndex = 0;
            this.Movienamelabel.Text = "null";
            // 
            // discriptionlabel
            // 
            this.discriptionlabel.AutoSize = true;
            this.discriptionlabel.Location = new System.Drawing.Point(43, 74);
            this.discriptionlabel.Name = "discriptionlabel";
            this.discriptionlabel.Size = new System.Drawing.Size(221, 25);
            this.discriptionlabel.TabIndex = 1;
            this.discriptionlabel.Text = "Please write your review";
            // 
            // reviewtextBox
            // 
            this.reviewtextBox.Location = new System.Drawing.Point(48, 128);
            this.reviewtextBox.Multiline = true;
            this.reviewtextBox.Name = "reviewtextBox";
            this.reviewtextBox.Size = new System.Drawing.Size(1083, 351);
            this.reviewtextBox.TabIndex = 2;
            // 
            // submitbutton
            // 
            this.submitbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.submitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbutton.Location = new System.Drawing.Point(700, 571);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(163, 56);
            this.submitbutton.TabIndex = 3;
            this.submitbutton.Text = "submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Location = new System.Drawing.Point(385, 571);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(163, 56);
            this.cancelbutton.TabIndex = 4;
            this.cancelbutton.Text = "Go Back";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.reviewtextBox);
            this.Controls.Add(this.discriptionlabel);
            this.Controls.Add(this.Movienamelabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "review";
            this.Text = "review";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Movienamelabel;
        private System.Windows.Forms.Label discriptionlabel;
        private System.Windows.Forms.TextBox reviewtextBox;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Button cancelbutton;
    }
}