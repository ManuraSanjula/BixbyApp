namespace Bixbu_UI.UI
{
    public partial class UserProductModel : UserControl
    {
        String user, item, TotalSuccessfulOrders, TotalRefunds, TotalViews;

        public UserProductModel(String user, String item, String TotalSuccessfulOrders, String TotalRefunds, String TotalViews)
        {
            InitializeComponent();
            this.user = user;
            this.item = item;
            this.TotalSuccessfulOrders = TotalSuccessfulOrders;
            this.TotalRefunds = TotalRefunds;
            this.TotalViews = TotalViews;


            metroLabel6.Text = user;
            metroLabel7.Text = item;
            metroLabel8.Text = TotalSuccessfulOrders;
            metroLabel9.Text = TotalRefunds;
            metroLabel10.Text = TotalViews;
        }

        private void UserProductModel_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
        }
    }
}
