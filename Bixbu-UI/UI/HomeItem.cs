using Bixbu_UI.HTTP;
using Bixbu_UI.Properties;
using Bixbu_UI.UI;
using DevExpress.XtraReports.UI;
using ImageResizer.ExtensionMethods;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bixbu_UI;

public partial class HomeItem : UserControl
{
    private readonly Func<Task> cartAsyncFunc;
    private readonly HttpDataFetcher httpDataFetcher = new();
    private bool isFormLocked;
    private readonly Func<Task> orderAsyncFunc;
    private bool notLogedIn;
    private FlowLayoutPanel order, cart, home = null;
    public HomeItem(string url, string name, string id, Func<Task> cartAsyncFunc, Func<Task> orderAsyncFunc, bool notLogedIn, FlowLayoutPanel order, FlowLayoutPanel cart, FlowLayoutPanel home)
    {
        InitializeComponent();
        this.url = url;
        Name = name;
        this.name = name;
        metroLabel1.Text = name;
        itemId = id;
        BixbyApp.RetrieveImageFromS3(url, pictureBox1, 404, 251).ContinueWith(data => { });
        this.cartAsyncFunc = cartAsyncFunc;
        this.orderAsyncFunc = orderAsyncFunc;
        this.notLogedIn = notLogedIn;
        this.cart = cart;
        this.home = home;
    }

    public string url { get; }
    public string name { get; }
    public string itemId { get; }

    private void HomeItem_Load(object sender, EventArgs e)
    {
    }

    public async void HomeFunCall(string type)
    {
        var token = Settings.Default.TokenValue;
        var email = Settings.Default.Email;
        if (type == "c")
        {
            cart.Invoke((MethodInvoker)(() =>
            {
                cart.Controls.Clear();
            }));

            await httpDataFetcher.FetchDataAsync(email, token, notLogedIn);
            await orderAsyncFunc();
        }
        else
            await orderAsyncFunc();


        /*        await httpDataFetcher.RefreshDataAsync(email, token, notLogedIn);
        */

    }
    private void pictureBox1_Click(object sender, EventArgs e)
    {
        click();
    }

    private void click()
    {
        if (!isFormLocked)
        {
            isFormLocked = true;
            LockControls(ParentForm); // Disable other controls on the form
            var fullItemDetails = new FullItemDetails(itemId);
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

    private void LockControls(Control excludeControl)
    {
        foreach (Control control in Controls)
            if (control != excludeControl)
                control.Enabled = false;
    }

    private void UnlockControls(Form form)
    {
        foreach (Control control in form.Controls) control.Enabled = true;
    }

    private void UnlockControls()
    {
        foreach (Control control in Controls) control.Enabled = true;
    }

    private void metroLabel1_Click(object sender, EventArgs e)
    {
        click();
    }

    private void Cart_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            try
            {
                var token = Settings.Default.TokenValue;
                var email = Settings.Default.Email;
                MessageBox.Show(email);
                if (token == null || (email == null))
                {
                    MessageBox.Show("Missing adata");
                    return;
                }

                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get,
                    $"http://localhost:8080/cart/{email}/{itemId}/add?Quantity={1}");
                request.Headers.Add("Authorization", $"Bearer {token}");
                var response = await client.SendAsync(request);
                if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                {
                    var jsonResult = await response.Content.ReadAsStringAsync();
                    var jObject = JObject.Parse(jsonResult);
                    var status = jObject["status"]?.Value<string>();
                    if (status == "Success")
                    {
                        MessageBox.Show("Success");
                        HomeFunCall("c");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        });
    }
}