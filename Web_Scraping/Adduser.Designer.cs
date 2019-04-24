namespace Web_Scraping
{
    partial class Adduser
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
            this.NewPasswordtextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordlabel = new System.Windows.Forms.Label();
            this.NewUserNametextBox = new System.Windows.Forms.TextBox();
            this.NewUserNamelabel = new System.Windows.Forms.Label();
            this.newSubmitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPasswordtextBox
            // 
            this.NewPasswordtextBox.Location = new System.Drawing.Point(168, 114);
            this.NewPasswordtextBox.Name = "NewPasswordtextBox";
            this.NewPasswordtextBox.Size = new System.Drawing.Size(298, 30);
            this.NewPasswordtextBox.TabIndex = 10;
            // 
            // NewPasswordlabel
            // 
            this.NewPasswordlabel.AutoSize = true;
            this.NewPasswordlabel.Location = new System.Drawing.Point(41, 117);
            this.NewPasswordlabel.Name = "NewPasswordlabel";
            this.NewPasswordlabel.Size = new System.Drawing.Size(104, 25);
            this.NewPasswordlabel.TabIndex = 9;
            this.NewPasswordlabel.Text = "Password:";
            // 
            // NewUserNametextBox
            // 
            this.NewUserNametextBox.Location = new System.Drawing.Point(168, 49);
            this.NewUserNametextBox.Name = "NewUserNametextBox";
            this.NewUserNametextBox.Size = new System.Drawing.Size(298, 30);
            this.NewUserNametextBox.TabIndex = 8;
            // 
            // NewUserNamelabel
            // 
            this.NewUserNamelabel.AutoSize = true;
            this.NewUserNamelabel.Location = new System.Drawing.Point(41, 52);
            this.NewUserNamelabel.Name = "NewUserNamelabel";
            this.NewUserNamelabel.Size = new System.Drawing.Size(116, 25);
            this.NewUserNamelabel.TabIndex = 7;
            this.NewUserNamelabel.Text = "User Name:";
            // 
            // newSubmitbutton
            // 
            this.newSubmitbutton.BackColor = System.Drawing.Color.White;
            this.newSubmitbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newSubmitbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newSubmitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.newSubmitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newSubmitbutton.Location = new System.Drawing.Point(168, 196);
            this.newSubmitbutton.Name = "newSubmitbutton";
            this.newSubmitbutton.Size = new System.Drawing.Size(298, 53);
            this.newSubmitbutton.TabIndex = 6;
            this.newSubmitbutton.Text = "Submit";
            this.newSubmitbutton.UseVisualStyleBackColor = false;
            this.newSubmitbutton.Click += new System.EventHandler(this.NewSubmitbutton_Click);
            // 
            // Adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 416);
            this.Controls.Add(this.NewPasswordtextBox);
            this.Controls.Add(this.NewPasswordlabel);
            this.Controls.Add(this.NewUserNametextBox);
            this.Controls.Add(this.NewUserNamelabel);
            this.Controls.Add(this.newSubmitbutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Adduser";
            this.Text = "Adduser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewPasswordtextBox;
        private System.Windows.Forms.Label NewPasswordlabel;
        private System.Windows.Forms.TextBox NewUserNametextBox;
        private System.Windows.Forms.Label NewUserNamelabel;
        private System.Windows.Forms.Button newSubmitbutton;
    }
}