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
                    Label label = new Label();
                    label.Size = new Size(200, 50); // Set the desired width and height of the label
                    label.Text = "No items were found";
                    label.Font = new Font(label.Font, FontStyle.Bold);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Anchor = AnchorStyles.None; // Center the label within the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(label);
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