using Newtonsoft.Json.Linq;

namespace Bixbu_UI.UI;

public partial class CartItemuserControl : UserControl
{
    private bool isFormLocked;
    public string item;
    private string price;
    private string Quantity;
    private string user;
    private string id;
    private BixbyApp bixby;
    private FlowLayoutPanel flowLayoutPanel;
    public CartItemuserControl(BixbyApp bixbyApp, FlowLayoutPanel flowLayoutPanel ,string id, string item, string user, string Quantity, string price)
    {
        this.item = item;
        this.Quantity = Quantity;
        this.price = price;
        this.user = user;
        this.id = id;
        this.bixby = bixbyApp;
        InitializeComponent(); // Call InitializeComponent() before setting control properties.

        linkLabel1.Text = item;
        metroLabel6.Text = user;
        metroLabel7.Text = Quantity;
        metroLabel8.Text = price;
        this.flowLayoutPanel = flowLayoutPanel;
        linkLabel1.LinkClicked += LinkLabel_LinkClicked;
    }

    private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var linkLabel = (LinkLabel)sender;
        var url = linkLabel.Text;
        if (!isFormLocked)
        {
            isFormLocked = true;
            LockControls(ParentForm); // Disable other controls on the form
            var fullItemDetails = new FullItemDetails(url);
            fullItemDetails.Show();
            fullItemDetails.FormClosed += (s, args) =>
            {
                UnlockControls(ParentForm); // Enable other controls on the form
                isFormLocked = false;
            };
        }
    }

    private void LockControls(Form form)
    {
        foreach (Control control in form.Controls)
            if (control != this)
                control.Enabled = false;
    }

    private void CartItem_Load(object sender, EventArgs e)
    {
    }

    private void UnlockControls(Form form)
    {
        foreach (Control control in form.Controls) control.Enabled = true;
    }

    private void metroLabel7_Click(object sender, EventArgs e)
    {
    }

    private async void metroButton1_Click(object sender, EventArgs e)
    {
        await Task.Run(async () =>
        {
            var token = Properties.Settings.Default.TokenValue;
            var email = Properties.Settings.Default.Email;

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/cart/{email}/{id}/delete");
            request.Headers.Add("Authorization", $"Bearer {token}");
            var response = await client.SendAsync(request);

            var jsonResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var jObject = JObject.Parse(jsonResult);
            var status = jObject["status"]?.Value<string>();

            if (status != null)
                switch (status)
                {
                    case "Success":
                        Invoke((MethodInvoker)(async () =>
                        {
                            MessageBox.Show("Success");
                            var token = Properties.Settings.Default.TokenValue;
                            var email = Properties.Settings.Default.Email;
                            await bixby.httpDataFetcher.RefreshDataAsync(email, token, true);
                            await bixby.CartUI();
                            flowLayoutPanel.Controls.Remove(this);
                            Dispose();
                        }));
                        break;
                    case "An error occurred.":
                        Invoke((MethodInvoker)(() => { MessageBox.Show("Try Again"); }));
                        break;
                }
            else
                Invoke((MethodInvoker)(() => { MessageBox.Show("Try Again"); }));

        });

    }

    private void metroLabel2_Click(object sender, EventArgs e)
    {

    }

    private void metroLabel6_Click(object sender, EventArgs e)
    {
        this.Invoke((MethodInvoker)(() => {
            if (!isFormLocked)
            {
                isFormLocked = true;
                LockControls(ParentForm); // Disable other controls on the form
                var fullItemDetails = new UserProducts(user);
                fullItemDetails.Show();
                fullItemDetails.FormClosed += (s, args) =>
                {
                    UnlockControls(ParentForm); // Enable other controls on the form
                    isFormLocked = false;
                };
            }
        }));
    }
}