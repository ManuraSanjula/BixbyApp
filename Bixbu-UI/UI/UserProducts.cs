using Bixbu_UI.HTTP;
using Bixbu_UI.Threads;
using Bixby_web_server.Models;

namespace Bixbu_UI.UI
{
    public partial class UserProducts : Form
    {
        String userEmail;
        String userId;
        HttpDataFetcher dataFetcher = new HttpDataFetcher();
        private readonly ConcurrentHashSet<string> addedItems_v2 = new();

        public UserProducts(String email, String id = null)
        {
            InitializeComponent();
            this.userEmail = email;
            this.userId = id;
            dataFetcher.FetchProductsAsync(email).ContinueWith(product =>
            {
                if (product != null)
                {
                    product.Result.allTheProducts.ForEach(p =>
                    {
                        if (!addedItems_v2.Contains(p._id)) // Check if item is already added
                            flowLayoutPanel1.Invoke((MethodInvoker)(() =>
                            {
                                UserProductModel userProductModel = new UserProductModel(p.User, p.Item, p.TotalSuccessfulOrders.ToString(), p.TotalRefunds.ToString(), p.TotalViews.ToString());
                                flowLayoutPanel1.Controls.Add(userProductModel);
                                addedItems_v2.Add(p._id);
                            }));
                    });
                }
                else
                {
                    return;
                }
            });
        }

        private void UserProducts_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}