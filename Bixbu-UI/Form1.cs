using System.Drawing.Imaging;
using System.Text.Json;
using Bixbu_UI.User;
using Bixby_web_server.Models;
using MaterialSkin.Controls;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace Bixbu_UI;

public partial class BixbyApp : MaterialForm
{
    public UserInformation userData;
    private static readonly HttpClient client = new();
    private PictureBox pb;

    private readonly List<ShopAllShopItem> shopAllShopItems = new();

    public BixbyApp()
    {
        InitializeComponent();
    }

    private async Task<string> SendGetRequestAsync(string url)
    {
        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }

    public bool DictionaryHasNullOrEmpty(Dictionary<string, object> dictionary)
    {
        foreach (var kvp in dictionary)
        {
            if (string.IsNullOrEmpty(kvp.Key) || kvp.Value == null || string.IsNullOrEmpty(kvp.Value.ToString()))
            {
                return true;
            }
        }

        return false;
    }


    private async void UserAccount(string email, string token)
    {
        try
        {
            if (email != null && token != null)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/user/{email}");
                request.Headers.Add("Authorization", $"Bearer {token}");
                var response = await client.SendAsync(request);
                HttpResponseMessage httpResponseMessage = response.EnsureSuccessStatusCode();

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic json = JsonConvert.DeserializeObject(responseBody);
                    string bodyKey = json["body"].ToString(); // Replace "key" with the actual key you want to extract
                    Dictionary<string, object> userDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(bodyKey);

                    bool hasNullOrEmpty = DictionaryHasNullOrEmpty(userDict);
                    if (!hasNullOrEmpty)
                    {
                        Email.Text = userDict["Email"].ToString();
                        FirstName_txt.Text = userDict["FirstName"].ToString();
                        LastName.Text = userDict["LastName"].ToString();
                        Address.Text = userDict["Address"].ToString();
                    }

                }
                else
                {
                    MessageBox.Show(response.ToString());
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }


    private void Blur()
    {
        var bmp = Screenshot.TakeSnapshot(panel1);
        BitmapFilter.GaussianBlur(bmp, 4);

        pb.Image = bmp;
        pb.BringToFront();
    }

    private void UnBlur()
    {
        pb.Image = null;
        pb.SendToBack();
    }

    private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
    {
        // Check if the selected tab is the "Account" tab
        if (e.TabPage == Account)
        {
            // Add your custom refresh logic here
            RefreshAccountTab();
        }
    }

    private void RefreshAccountTab()
    {

    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        AutoSizeMode = AutoSizeMode.GrowOnly;
        FormBorderStyle = FormBorderStyle.FixedSingle;

        materialTabControl1.Selecting += tabControl1_Selecting;
        materialTabControl1.SelectedIndexChanged += tabControl1_Selecting;

        pb = new PictureBox();
        panel1.Controls.Add(pb);
        pb.Dock = DockStyle.Fill;

        //===========================================================================================

        String token = Properties.Settings.Default.TokenValue;
        String email = Properties.Settings.Default.Email;

        if (!token.IsNullOrEmpty() || !email.IsNullOrEmpty())
        {
            UserAccount(email, token);
        }
        else
        {
            panel1.Visible = true;
            panel3.Visible = false;
        }

        //-------------------------------------------------------------------------------------------
        var url = "http://localhost:8080/home";
        var response = await SendGetRequestAsync(url);

        var jsonDocument = JsonDocument.Parse(response);
        var rootElement = jsonDocument.RootElement;

        if (rootElement.GetProperty("body").ValueKind == JsonValueKind.Array)
            foreach (var element in rootElement.GetProperty("body").EnumerateArray())
            {
                var customObject = System.Text.Json.JsonSerializer.Deserialize<ShopAllShopItem>(element.GetRawText());
                shopAllShopItems.Add(customObject);
            }

        if (shopAllShopItems.Count > 0)
        {
            shopAllShopItems.ForEach(item =>
            {
                //flowLayoutPanel1.Controls.Add(new WellComeItem());
            });
        }
    }

    private void tabControl1_Selecting(object? sender, EventArgs e)
    {
        TabControl tab = (TabControl)sender;
        if (tab.SelectedTab == Account)
        {
            RefreshAccountTab();
        }
    }

    private void materialFloatingActionButton1_Click(object sender, EventArgs e)
    {
    }

    private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void materialButton1_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        var loginForm = new UserLogin();
        loginForm.MinimizeBox = false;
        loginForm.MaximizeBox = false;
        Blur();
        loginForm.Show();
        UnBlur();
    }


    private void button2_Click(object sender, EventArgs e)
    {
        var SingUp = new SingUp();
        SingUp.MinimizeBox = false;
        SingUp.MaximizeBox = false;
        Blur();
        SingUp.Show();
        UnBlur();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
    }
}

public class BitmapFilter
{
    private static bool Conv3x3(Bitmap b, ConvMatrix m)
    {
        // Avoid divide by zero errors
        if (0 == m.Factor) return false;

        var bSrc = (Bitmap)b.Clone();

        // GDI+ still lies to us - the return format is BGR, NOT RGB.
        var bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite,
            PixelFormat.Format24bppRgb);
        var bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite,
            PixelFormat.Format24bppRgb);

        var stride = bmData.Stride;
        var stride2 = stride * 2;
        var Scan0 = bmData.Scan0;
        var SrcScan0 = bmSrc.Scan0;

        unsafe
        {
            var p = (byte*)(void*)Scan0;
            var pSrc = (byte*)(void*)SrcScan0;

            var nOffset = stride + 6 - b.Width * 3;
            var nWidth = b.Width - 2;
            var nHeight = b.Height - 2;

            int nPixel;

            for (var y = 0; y < nHeight; ++y)
            {
                for (var x = 0; x < nWidth; ++x)
                {
                    nPixel = (pSrc[2] * m.TopLeft + pSrc[5] * m.TopMid + pSrc[8] * m.TopRight +
                              pSrc[2 + stride] * m.MidLeft + pSrc[5 + stride] * m.Pixel +
                              pSrc[8 + stride] * m.MidRight +
                              pSrc[2 + stride2] * m.BottomLeft + pSrc[5 + stride2] * m.BottomMid +
                              pSrc[8 + stride2] * m.BottomRight) / m.Factor + m.Offset;

                    if (nPixel < 0) nPixel = 0;
                    if (nPixel > 255) nPixel = 255;

                    p[5 + stride] = (byte)nPixel;

                    nPixel = (pSrc[1] * m.TopLeft + pSrc[4] * m.TopMid + pSrc[7] * m.TopRight +
                              pSrc[1 + stride] * m.MidLeft + pSrc[4 + stride] * m.Pixel +
                              pSrc[7 + stride] * m.MidRight +
                              pSrc[1 + stride2] * m.BottomLeft + pSrc[4 + stride2] * m.BottomMid +
                              pSrc[7 + stride2] * m.BottomRight) / m.Factor + m.Offset;

                    if (nPixel < 0) nPixel = 0;
                    if (nPixel > 255) nPixel = 255;

                    p[4 + stride] = (byte)nPixel;

                    nPixel = (pSrc[0] * m.TopLeft + pSrc[3] * m.TopMid + pSrc[6] * m.TopRight +
                              pSrc[0 + stride] * m.MidLeft + pSrc[3 + stride] * m.Pixel +
                              pSrc[6 + stride] * m.MidRight +
                              pSrc[0 + stride2] * m.BottomLeft + pSrc[3 + stride2] * m.BottomMid +
                              pSrc[6 + stride2] * m.BottomRight) / m.Factor + m.Offset;

                    if (nPixel < 0) nPixel = 0;
                    if (nPixel > 255) nPixel = 255;

                    p[3 + stride] = (byte)nPixel;

                    p += 3;
                    pSrc += 3;
                }

                p += nOffset;
                pSrc += nOffset;
            }
        }

        b.UnlockBits(bmData);
        bSrc.UnlockBits(bmSrc);

        return true;
    }

    public static bool GaussianBlur(Bitmap b, int nWeight /* default to 4*/)
    {
        var m = new ConvMatrix();
        m.SetAll(1);
        m.Pixel = nWeight;
        m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 2;
        m.Factor = nWeight + 12;

        return Conv3x3(b, m);
    }

    public class ConvMatrix
    {
        public int BottomLeft, BottomMid, BottomRight;
        public int Factor = 1;
        public int MidLeft, Pixel = 1, MidRight;
        public int Offset = 0;
        public int TopLeft, TopMid, TopRight;

        public void SetAll(int nVal)
        {
            TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight = nVal;
        }
    }
}

public class UserInformation
{
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String Address { get; set; }
    public String EmailVerify { get; set; }
    public String Email { get; set; }
}


internal class Screenshot
{
    public static Bitmap TakeSnapshot(Control ctl)
    {
        var bmp = new Bitmap(ctl.Size.Width, ctl.Size.Height);
        var g = Graphics.FromImage(bmp);
        g.CopyFromScreen(ctl.PointToScreen(ctl.ClientRectangle.Location), new Point(0, 0), ctl.ClientRectangle.Size);
        return bmp;
    }
}