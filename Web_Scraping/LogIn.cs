using System;
using System.Windows.Forms;


namespace Web_Scraping
{
    public partial class LogIn : Form
    {
        public static string Currentuser = "";
        public LogIn()
        {
            InitializeComponent();
        }
        private void Submitbutton_Click(object sender, EventArgs e)
        {
            string username = UserNametextBox.Text;
            string password = PasswordtextBox.Text;
            Currentuser = username;
            // TODO - Make the password hidden when they type it in.
            var user = new UserHandler(username, password);
            if (user.validate())
            {
                Form.ActiveForm.Hide();
                Mainview newwindow = new Mainview();
                newwindow.Show();
            }
            else
            {
                unknownuserlabel.Visible = true;
                unknownuserlabel.Refresh();
            }
        }

        private void NewUserbutton_Click(object sender, EventArgs e)
        {
            Adduser testDialog = new Adduser();
            testDialog.Show();
        }
    }
}
