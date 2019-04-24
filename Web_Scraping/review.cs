using System;
using System.Windows.Forms;

namespace Web_Scraping
{
    public partial class review : Form
    {
        public review()
        {
            InitializeComponent();
            Movienamelabel.Text = Mainview.movie;
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            var review = reviewtextBox.Text;
            string user = LogIn.Currentuser;
            Data info = new Data();
            info.savejson(info.data(user, review, Mainview.movie));
            Console.WriteLine(Mainview.movie);
            Console.WriteLine(review);
            //TODO - add the review to the json data
            Form.ActiveForm.Close();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
