using System.Windows.Forms;

namespace Web_Scraping
{
    public partial class Mainview : Form
    {
        public static string movie = "";
        public Mainview()
        {
            InitializeComponent();
            var data = new Data();
            MovieslistBox.DataSource = data.Gethtml();
        }

        public void Selectmoviebutton_Click(object sender, System.EventArgs e)
        {
            movie = MovieslistBox.SelectedItem.ToString();
            review review = new review();
            review.Show();
        }
    }
}
