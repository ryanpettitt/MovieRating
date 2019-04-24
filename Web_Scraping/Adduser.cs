using System;
using System.Windows.Forms;

namespace Web_Scraping
{
    public partial class Adduser : Form
    {
        public Adduser()
        {
            InitializeComponent();
        }

        private void NewSubmitbutton_Click(object sender, EventArgs e)
        {
            string username = NewUserNametextBox.Text;
            string password = NewPasswordtextBox.Text;
            var newuser = new UserHandler(username, password);
            newuser.adduser();
            Form.ActiveForm.Close();
        }
    }
}
