using Newtonsoft.Json.Linq;

namespace Bixbu_UI.UI;

public partial class CartItemuserControl : UserControl, IEquatable<CartItemuserControl>
{
    private bool isFormLocked;
    public string item;
    private string price;
    private string Quantity;
    private string user;
    public string id;

    private sealed class CartItemuserControlEqualityComparer : IEqualityComparer<CartItemuserControl>
    {
        public bool Equals(CartItemuserControl x, CartItemuserControl y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.isFormLocked == y.isFormLocked && x.item == y.item && x.price == y.price && x.Quantity == y.Quantity && x.user == y.user && x.id == y.id && x.bixby.Equals(y.bixby) && x.flowLayoutPanel.Equals(y.flowLayoutPanel) && x.home.Equals(y.home) && Equals(x.components, y.components) && Equals(x.metroLabel1, y.metroLabel1) && Equals(x.metroLabel2, y.metroLabel2) && Equals(x.metroLabel3, y.metroLabel3) && Equals(x.metroLabel4, y.metroLabel4) && Equals(x.metroLabel6, y.metroLabel6) && Equals(x.metroLabel7, y.metroLabel7) && Equals(x.metroLabel8, y.metroLabel8) && Equals(x.metroButton1, y.metroButton1) && Equals(x.linkLabel1, y.linkLabel1);
        }

        public int GetHashCode(CartItemuserControl obj)
        {
            var hashCode = new HashCode();
            hashCode.Add(obj.isFormLocked);
            hashCode.Add(obj.item);
            hashCode.Add(obj.price);
            hashCode.Add(obj.Quantity);
            hashCode.Add(obj.user);
            hashCode.Add(obj.id);
            hashCode.Add(obj.bixby);
            hashCode.Add(obj.flowLayoutPanel);
            hashCode.Add(obj.home);
            hashCode.Add(obj.components);
            hashCode.Add(obj.metroLabel1);
            hashCode.Add(obj.metroLabel2);
            hashCode.Add(obj.metroLabel3);
            hashCode.Add(obj.metroLabel4);
            hashCode.Add(obj.metroLabel6);
            hashCode.Add(obj.metroLabel7);
            hashCode.Add(obj.metroLabel8);
            hashCode.Add(obj.metroButton1);
            hashCode.Add(obj.linkLabel1);
            return hashCode.ToHashCode();
        }
    }

    public static IEqualityComparer<CartItemuserControl> CartItemuserControlComparer { get; } = new CartItemuserControlEqualityComparer();

    public bool Equals(CartItemuserControl? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return isFormLocked == other.isFormLocked && item == other.item && price == other.price && Quantity == other.Quantity && user == other.user && id == other.id && bixby.Equals(other.bixby) && flowLayoutPanel.Equals(other.flowLayoutPanel) && home.Equals(other.home) && Equals(components, other.components) && Equals(metroLabel1, other.metroLabel1) && Equals(metroLabel2, other.metroLabel2) && Equals(metroLabel3, other.metroLabel3) && Equals(metroLabel4, other.metroLabel4) && Equals(metroLabel6, other.metroLabel6) && Equals(metroLabel7, other.metroLabel7) && Equals(metroLabel8, other.metroLabel8) && Equals(metroButton1, other.metroButton1) && Equals(linkLabel1, other.linkLabel1);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((CartItemuserControl)obj);
    }

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(isFormLocked);
        hashCode.Add(item);
        hashCode.Add(price);
        hashCode.Add(Quantity);
        hashCode.Add(user);
        hashCode.Add(id);
        hashCode.Add(bixby);
        hashCode.Add(flowLayoutPanel);
        hashCode.Add(home);
        hashCode.Add(components);
        hashCode.Add(metroLabel1);
        hashCode.Add(metroLabel2);
        hashCode.Add(metroLabel3);
        hashCode.Add(metroLabel4);
        hashCode.Add(metroLabel6);
        hashCode.Add(metroLabel7);
        hashCode.Add(metroLabel8);
        hashCode.Add(metroButton1);
        hashCode.Add(linkLabel1);
        return hashCode.ToHashCode();
    }

    public static bool operator ==(CartItemuserControl? left, CartItemuserControl? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(CartItemuserControl? left, CartItemuserControl? right)
    {
        return !Equals(left, right);
    }

    private BixbyApp bixby;
    private FlowLayoutPanel flowLayoutPanel, home;
    public CartItemuserControl(BixbyApp bixbyApp, FlowLayoutPanel flowLayoutPanel, FlowLayoutPanel home ,string id, string item, string user, string Quantity, string price)
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
        this.home = home;
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
                            flowLayoutPanel.Controls.Remove(this);
                            
                            await bixby.CartUI();
                            await bixby.httpDataFetcher.RefreshDataAsync(email, token, true);
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