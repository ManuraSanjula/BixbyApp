using Bixbu_UI.HTTP;
using Bixby_web_server.Controllers;
using MetroFramework.Controls;
using Newtonsoft.Json.Linq;

namespace Bixbu_UI.UI;

public partial class OrderItemUserControll : UserControl
{
    private Func<Task> asyncFunc;
    private bool confirm;
    private HttpDataFetcher httpDataFetcher = new();

    public string id;
    private bool isFormLocked;
    private List<string> itemIds;
    private int price;
    private string user;
    private BixbyApp bixby;

    public OrderItemUserControll(BixbyApp bixbyApp, string id, string user, bool confirm, int price, List<string> itemIds,
        Func<Task> asyncFunc)
    {
        this.id = id;
        this.user = user;
        this.confirm = confirm;
        this.price = price;
        this.itemIds = itemIds;
        this.asyncFunc = asyncFunc;
        this.bixby = bixbyApp;
        InitializeComponent();

        metroLabel5.Text = id;
        metroLabel6.Text = user;
        metroLabel7.Text = confirm.ToString();
        metroLabel8.Text = price.ToString();

        itemIds.ForEach(id =>
        {
            var linkLabel = new LinkLabel();
            linkLabel.Text = id;
            linkLabel.LinkClicked += LinkLabel_LinkClicked; // Optional event handler for when the link is clicked
            flowLayoutPanel1.Controls.Add(linkLabel);
        });
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

    private void OrderItem_Load(object sender, EventArgs e)
    {
        if (confirm)
        {
            materialButton1.Enabled = false;
        }
    }

    private void UnlockControls(Form form)
    {
        foreach (Control control in form.Controls) control.Enabled = true;
    }

    private async void materialButton1_Click(object sender, EventArgs e)
    {
        Thread threadStart = new Thread(confirmFun);
        threadStart.Start();
    }

    private async void confirmFun()
    {
        var token = Properties.Settings.Default.TokenValue;
        var email = Properties.Settings.Default.Email;

        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/order/{email}/{id}/confirm");
        request.Headers.Add("Authorization", $"Bearer {token}");
        var response = await client.SendAsync(request);
        materialButton1.Enabled = false;
        confirm = true;
        metroLabel7.Text = confirm.ToString();
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
                        await bixby.OrderUI();
                    }));
                    break;
                case "An error occurred.":
                    Invoke((MethodInvoker)(() => { MessageBox.Show("Try Again"); }));
                    break;
            }
        else
            Invoke((MethodInvoker)(() => { MessageBox.Show("Try Again"); }));
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