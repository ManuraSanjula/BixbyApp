using System.Drawing.Imaging;
using System.Text.Json;
using Amazon.S3.Transfer;
using Amazon.S3;
using Bixbu_UI.User;
using Bixby_web_server.Models;
using MaterialSkin.Controls;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Drawing.Drawing2D;
using Amazon.S3.Model;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Bixbu_UI;

public partial class BixbyApp : MaterialForm
{

    private const string AccessKey = "AKIASULOPD3USE5RVZCQ";
    private const string SecretKey = "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";
    private const string BucketName = "bixby-app-nibm";

    private OpenFileDialog openFileDialog = new OpenFileDialog();

    public UserInformation userData;
    private static readonly HttpClient client = new();
    private PictureBox pb;

    private readonly List<ShopAllShopItem> shopAllShopItems = new();

    public BixbyApp()
    {
        InitializeComponent();

        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;

        // Disable form minimizing
        this.ShowIcon = false;
    }

    private async Task<string> SendGetRequestAsync(string url)
    {
        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }

    private void InitializeUI()
    {
        openFileDialog = new OpenFileDialog();
        // Set up the OpenFileDialog
        openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
        openFileDialog.Title = "Select an image";
        openFileDialog.Multiselect = false;
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

                        string url = userDict["Pic"].ToString();
                        if (!url.Equals("default"))
                        {
                            string filename = Path.GetFileName(url);
                            RetrieveImageFromS3(filename);
                            return;
                        }

                    }

                }
            }
        }
        catch (Exception ex)
        {
            panel1.Visible = true;
            panel3.Visible = false;
        }
    }


    private void Blur()
    {
        var bmp = Screenshot.TakeSnapshot(panel1);
        BitmapFilter.GaussianBlur(bmp, 10);

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


    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Size = new System.Drawing.Size(1268, 758);
    }

    private async void Form1_Load(object sender, EventArgs e)
    {

        this.metroLabel4.Visible = false;
        this.metroLabel4.Enabled = false;
        this.Size = new System.Drawing.Size(1268, 758);
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

        try
        {
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
        catch (Exception ex)
        {
            panel1.Visible = true;
            panel3.Visible = false;
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


    private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Restart();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        var loginForm = new UserLogin();
        loginForm.MinimizeBox = false;
        loginForm.MaximizeBox = false;
        loginForm.FormClosed += ChildForm_FormClosed;
        Blur();
        loginForm.Show();
        UnBlur();
    }


    private void button2_Click(object sender, EventArgs e)
    {
        var SingUp = new SingUp();
        SingUp.MinimizeBox = false;
        SingUp.MaximizeBox = false;
        SingUp.FormClosed += ChildForm_FormClosed;
        Blur();
        SingUp.Show();
        UnBlur();
    }

    private async void RetrieveImageFromS3(string key)
    {
        var s3Client = new AmazonS3Client(AccessKey, SecretKey, Amazon.RegionEndpoint.APSouth1);

        var request = new GetObjectRequest
        {
            BucketName = BucketName,
            Key = key
        };

        try
        {
            using (GetObjectResponse response = await s3Client.GetObjectAsync(request))
            {
                using (Stream responseStream = response.ResponseStream)
                {
                    // Create a temporary file path to save the retrieved image
                    string tempFilePath = Path.GetTempFileName();

                    using (FileStream fileStream = File.Create(tempFilePath))
                    {
                        responseStream.CopyTo(fileStream);
                    }

                    // Update the PictureBox with the retrieved image
                    UpdatePictureBox(tempFilePath);
                }
            }

            MessageBox.Show($"Image retrieved successfully.");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error retrieving image: {ex.Message}");
        }
    }

    private void UpdatePictureBox(string imagePath)
    {
        Image image = Image.FromFile(imagePath);
        pictureBox4.Image = image;
        pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;


    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
    }

    private async void UploadToS3(string filePath)
    {
        var s3Client = new AmazonS3Client(AccessKey, SecretKey, Amazon.RegionEndpoint.APSouth1);

        // Generate a unique key for the uploaded image
        string key = Guid.NewGuid().ToString() + Path.GetExtension(filePath);

        // Set up the transfer utility
        var transferUtility = new TransferUtility(s3Client);
        var transferUtilityRequest = new TransferUtilityUploadRequest
        {
            BucketName = BucketName,
            FilePath = filePath,
            Key = key
        };

        try
        {
            // Upload the image to S3
            transferUtility.Upload(transferUtilityRequest);

            // Get the URL of the uploaded image
            string imageUrl = $"https://{BucketName}.s3.amazonaws.com/{key}";

            var client = new HttpClient();
            String email = Properties.Settings.Default.Email;
            var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/user/{email}/add/image");
            request.Headers.Add("img", $"{imageUrl}");
            var response = await client.SendAsync(request);
            HttpResponseMessage httpResponseMessage = response.EnsureSuccessStatusCode();
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Okay");
                materialTabControl1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Not Okay");
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error uploading image: {ex.Message}");
        }
    }

    private void ResizeImage(string sourceFilePath, string destFilePath, int maxWidth, int maxHeight)
    {
        using (Image sourceImage = Image.FromFile(sourceFilePath))
        {
            int width = sourceImage.Width;
            int height = sourceImage.Height;

            // Calculate the new dimensions while preserving the aspect ratio
            if (width > maxWidth || height > maxHeight)
            {
                double aspectRatio = (double)width / height;
                if (width > height)
                {
                    width = maxWidth;
                    height = (int)(width / aspectRatio);
                }
                else
                {
                    height = maxHeight;
                    width = (int)(height * aspectRatio);
                }
            }

            using (Bitmap resizedImage = new Bitmap(width, height))
            {
                using (Graphics graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    graphics.DrawImage(sourceImage, 0, 0, width, height);
                }

                // Save the resized image to the specified file path
                resizedImage.Save(destFilePath, ImageFormat.Jpeg);
            }
        }
    }

    private void ProcessAndUploadImage(string filePath)
    {
        // Create a temporary file path for the processed image
        string processedFilePath = Path.Combine(Path.GetDirectoryName(filePath), "processed_" + Path.GetFileName(filePath));

        try
        {
            // Apply low-quality blur effect to the image
            using (Image originalImage = Image.FromFile(filePath))
            {
                using (Bitmap processedImage = new Bitmap(originalImage.Width, originalImage.Height))
                {
                    using (Graphics graphics = Graphics.FromImage(processedImage))
                    {
                        graphics.SmoothingMode = SmoothingMode.HighSpeed;
                        graphics.InterpolationMode = InterpolationMode.Low;
                        graphics.DrawImage(originalImage, new Rectangle(0, 0, processedImage.Width, processedImage.Height));
                    }

                    // Save the processed image to the temporary file path
                    processedImage.Save(processedFilePath, ImageFormat.Jpeg);
                }
            }

            // Upload the processed image to AWS S3
            UploadToS3(processedFilePath);

            // Clean up the processed image file
            File.Delete(processedFilePath);
        }
        catch (Exception ex)
        {

        }
    }

    private void metroButton2_Click(object sender, EventArgs e)
    {

    }

    private void materialButton3_Click_1(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog.FileName;
            Image selectedImage = Image.FromFile(filePath);
            metroLabel4.Visible = selectedImage != null;
            metroLabel4.Enabled = selectedImage != null;
            metroLabel4.Text = filePath;
        }
    }

    private void materialButton1_Click_2(object sender, EventArgs e)
    {
        string filePath = openFileDialog.FileName;
        if (filePath == null)
        {
            MessageBox.Show("Pick a image");
            return;
        }
        string resizedFilePath = Path.Combine(Path.GetDirectoryName(filePath), "resized_" + Path.GetFileName(filePath));

        // Resize the image
        ResizeImage(filePath, resizedFilePath, 800, 600);

        // Upload the resized image to S3
        UploadToS3(resizedFilePath);

        // Clean up
        File.Delete(resizedFilePath);
    }

    private void metroButton2_Click_1(object sender, EventArgs e)
    {
        Properties.Settings.Default.TokenValue = null;
        Properties.Settings.Default.Email = null;
        Properties.Settings.Default.Save();
        MessageBox.Show("Success");
        materialTabControl1.SelectedIndex = 0;
        Form1_Load(this, EventArgs.Empty);
    }

    private async void materialButton2_Click(object sender, EventArgs e)
    {
        string token = Properties.Settings.Default.TokenValue;
        string email = Properties.Settings.Default.Email;

        string firstName = FirstName_txt.Text;
        string lastName = LastName.Text;
        string userEmail = Email.Text;
        string address = Address.Text;

        if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(email))
        {
            Invoke(new Action(() =>
            {
                MessageBox.Show("Invalid Input: Passwords do not match");
            })); // Invoke on UI thread
            return;
        }

        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Put, $"http://localhost:8080/updateUser/{email}");
        request.Headers.Add("Authorization", $"Bearer {token}");

        var content = new
        {
            firstName = firstName,
            lastName = lastName,
            email = userEmail,
            address = address
        };

        var json = JsonConvert.SerializeObject(content);
        var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
        request.Content = stringContent;

        var response = await client.SendAsync(request);
        HttpResponseMessage httpResponseMessage = response.EnsureSuccessStatusCode();

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            var jsonResult = await response.Content.ReadAsStringAsync();
            var jObject = JObject.Parse(jsonResult);
            var status = jObject["status"]?.Value<string>();

            if (status != null)
                switch (status)
                {
                    case "Success":
                        Invoke(() =>
                        {
                            MessageBox.Show("Success");
                            materialTabControl1.SelectedIndex = 0;
                        });
                        break;
                    case "An error occurred.":
                        Invoke(new Action(() => MessageBox.Show("Try Again"))); // Invoke on UI thread
                        break;
                }
            else
                Invoke(new Action(() => MessageBox.Show("Try Again")));
            return;
        }
        else
        {
            Invoke(new Action(() => MessageBox.Show("Try Again")));
            return;
        }
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