namespace Web_Scraping
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Submitbutton = new System.Windows.Forms.Button();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.NewUserbutton = new System.Windows.Forms.Button();
            this.unknownuserlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submitbutton
            // 
            this.Submitbutton.BackColor = System.Drawing.Color.White;
            this.Submitbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Submitbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Submitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Submitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submitbutton.Location = new System.Drawing.Point(163, 240);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(127, 39);
            this.Submitbutton.TabIndex = 0;
            this.Submitbutton.Text = "Submit";
            this.Submitbutton.UseVisualStyleBackColor = false;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.Location = new System.Drawing.Point(36, 96);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(116, 25);
            this.UserNamelabel.TabIndex = 1;
            this.UserNamelabel.Text = "User Name:";
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(163, 93);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(298, 30);
            this.UserNametextBox.TabIndex = 2;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(163, 158);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(298, 30);
            this.PasswordtextBox.TabIndex = 4;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Location = new System.Drawing.Point(36, 161);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(104, 25);
            this.Passwordlabel.TabIndex = 3;
            this.Passwordlabel.Text = "Password:";
            // 
            // NewUserbutton
            // 
            this.NewUserbutton.BackColor = System.Drawing.Color.White;
            this.NewUserbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NewUserbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewUserbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.NewUserbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewUserbutton.Location = new System.Drawing.Point(319, 240);
            this.NewUserbutton.Name = "NewUserbutton";
            this.NewUserbutton.Size = new System.Drawing.Size(127, 39);
            this.NewUserbutton.TabIndex = 5;
            this.NewUserbutton.Text = "New User";
            this.NewUserbutton.UseVisualStyleBackColor = false;
            this.NewUserbutton.Click += new System.EventHandler(this.NewUserbutton_Click);
            // 
            // unknownuserlabel
            // 
            this.unknownuserlabel.AutoSize = true;
            this.unknownuserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unknownuserlabel.ForeColor = System.Drawing.Color.Red;
            this.unknownuserlabel.Location = new System.Drawing.Point(163, 53);
            this.unknownuserlabel.Name = "unknownuserlabel";
            this.unknownuserlabel.Size = new System.Drawing.Size(210, 25);
            this.unknownuserlabel.TabIndex = 6;
            this.unknownuserlabel.Text = "Please create a user";
            this.unknownuserlabel.Visible = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 477);
            this.Controls.Add(this.unknownuserlabel);
            this.Controls.Add(this.NewUserbutton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.UserNametextBox);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.Submitbutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Button NewUserbutton;
        private System.Windows.Forms.Label unknownuserlabel;
    }
}