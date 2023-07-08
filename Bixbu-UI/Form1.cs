using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Bixbu_UI.LoadingScreen;
using Bixbu_UI.User;
using Bixby_web_server.Models;
using MaterialSkin.Controls;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Bixbu_UI;

public partial class BixbyApp : MaterialForm
{
    private const string AccessKey = "AKIASULOPD3USE5RVZCQ";
    private const string SecretKey = "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";
    private const string BucketName = "bixby-app-nibm";
    private static readonly HttpClient client = new();
    private readonly List<string> images = new();

    private readonly List<ShopAllShopItem> shopAllShopItems = new();
    private readonly List<string> addedItems = new(); // Track added item IDs
    private HashSet<Item> items = new();

    private OpenFileDialog openFileDialog = new();
    private PictureBox pb;
    public UserInformation userData;

    public BixbyApp()
    {
        InitializeComponent();

        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;

        // Disable form minimizing
        ShowIcon = false;
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
            if (string.IsNullOrEmpty(kvp.Key) || kvp.Value == null || string.IsNullOrEmpty(kvp.Value.ToString()))
                return true;

        return false;
    }


    private async Task UserAccount(string email, string token)
    {
        try
        {
            if (email != null && token != null)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/user/{email}");
                request.Headers.Add("Authorization", $"Bearer {token}");
                var response = await client.SendAsync(request);
                var httpResponseMessage = response.EnsureSuccessStatusCode();

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    dynamic json = JsonConvert.DeserializeObject(responseBody);
                    string bodyKey = json["body"].ToString(); // Replace "key" with the actual key you want to extract
                    var userDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(bodyKey);

                    var hasNullOrEmpty = DictionaryHasNullOrEmpty(userDict);
                    if (!hasNullOrEmpty)
                    {
                        // Update the UI based on the userDict data
                        Email.Text = userDict["Email"].ToString();
                        FirstName_txt.Text = userDict["FirstName"].ToString();
                        LastName.Text = userDict["LastName"].ToString();
                        Address.Text = userDict["Address"].ToString();

                        var url = userDict["Pic"].ToString();
                        if (!url.Equals("default"))
                        {
                            var filename = Path.GetFileName(url);
                            RetrieveImageFromS3(url);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            panel1.Visible = true;
            panel4.Visible = true;
            panel3.Visible = false;
            panel5.Visible = false;
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
            RefreshAccountTab();
        if (e.TabPage == Home)
            home(null);
    }

    private void RefreshAccountTab()
    {
    }


    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Size = new Size(1268, 758);
    }

    private void MenuItem_Click(object sender, EventArgs e)
    {
        // Handle the menu item click event
        var menuItem = (ToolStripMenuItem)sender;
        MessageBox.Show("Clicked: " + menuItem.Text);
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        metroLabel4.Visible = false;
        metroLabel4.Enabled = false;
        Size = new Size(1268, 758);


        materialTabControl1.Selecting += tabControl1_Selecting;
        materialTabControl1.SelectedIndexChanged += tabControl1_Selecting;

        pb = new PictureBox();
        panel1.Controls.Add(pb);
        pb.Dock = DockStyle.Fill;

        var token = Properties.Settings.Default.TokenValue;
        var email = Properties.Settings.Default.Email;

        flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.WrapContents = false;
        flowLayoutPanel1.Padding = new Padding(10); // Adjust the padding as per your requirement

        home_panel.AutoScroll = true;


        var loadingForm =
            new LoadingForm("https://cdn.dribbble.com/users/295241/screenshots/4496315/loading-animation.gif");
        loadingForm.Show();

        foreach (Control control in Controls) control.Enabled = false;

        try
        {
            if (!token.IsNullOrEmpty() || !email.IsNullOrEmpty())
            {
                await UserAccount(email, token); // Wait for the UserAccount method to complete
            }
            else
            {
                panel1.Visible = true;
                panel4.Visible = true;
                panel3.Visible = false;
                panel5.Visible = false;
            }
        }
        catch (Exception ex)
        {
            panel1.Visible = true;
            panel3.Visible = false;
            loadingForm.Close(); // Close the loading form in case of an exception
        }


        home(loadingForm);

        loadingForm.Close(); // Close the loading form once both requests are completed

        foreach (Control control in Controls) control.Enabled = true;
    }

    private void homeError()
    {
    }

    private void PictureBox_Load(object sender, EventArgs e)
    {
        var pictureBox = (PictureBox)sender;

        // Load the image from the online source
        var imageUrl = "https://example.com/image.jpg";
        pictureBox.ImageLocation = imageUrl;

        // Adjust the size of the PictureBox based on the loaded image
        if (pictureBox.Image != null)
        {
            // Calculate the aspect ratio of the image
            var aspectRatio = (float)pictureBox.Image.Width / pictureBox.Image.Height;

            // Set the size of the PictureBox based on the aspect ratio and desired width
            var desiredWidth = 200; // Adjust as needed
            var desiredHeight = (int)(desiredWidth / aspectRatio);
            pictureBox.Size = new Size(desiredWidth, desiredHeight);
        }
    }

    private void home(LoadingForm loadingForm)
    {
        try
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:8080/home");

            var response = client.SendAsync(request).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var responseObject = JsonConvert.DeserializeObject<Response>(json);
                items = responseObject.body;

                if (items.Count > 0)
                {
                    foreach (var item in items)
                        if (item != null)
                            if (!addedItems.Contains(item._id)) // Check if item is already added
                            {
                                var home_item = new HomeItem(item.PicLowRes, item.Name, item._id, home_panel);
                                home_panel.Controls.Add(home_item);
                                addedItems.Add(item._id); // Add item ID to the list
                                if (loadingForm != null)
                                    loadingForm.Close();
                            }
                }
                else
                {
                    if (loadingForm != null)
                        loadingForm.Close();
                }

                if (loadingForm != null)
                    loadingForm.Close();
            }
        }
        catch (Exception ex)
        {
            if (loadingForm != null)
                loadingForm.Close();
            // Handle exception
        }
    }


    private void tabControl1_Selecting(object? sender, EventArgs e)
    {
        var tab = (TabControl)sender;
        if (tab.SelectedTab == Account) RefreshAccountTab();
        if (tab.SelectedTab == Home) home(null);
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
        var s3Client = new AmazonS3Client(AccessKey, SecretKey, RegionEndpoint.APSouth1);

        var request = new GetObjectRequest
        {
            BucketName = BucketName,
            Key = key
        };

        try
        {
            using (var response = await s3Client.GetObjectAsync(request))
            {
                using (var responseStream = response.ResponseStream)
                {
                    // Create a temporary file path to save the retrieved image
                    var tempFilePath = Path.GetTempFileName();

                    using (var fileStream = File.Create(tempFilePath))
                    {
                        responseStream.CopyTo(fileStream);
                    }

                    // Update the PictureBox with the retrieved image
                    UpdatePictureBox(tempFilePath);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error retrieving image: {ex.Message}");
        }
    }

    public static async void RetrieveImageFromS3(string key, PictureBox pictureBox, int width, int height)
    {
        var s3Client = new AmazonS3Client(AccessKey, SecretKey, RegionEndpoint.APSouth1);

        var request = new GetObjectRequest
        {
            BucketName = BucketName,
            Key = key
        };

        try
        {
            using (var response = await s3Client.GetObjectAsync(request))
            {
                // Create a temporary in-memory stream to store the retrieved image
                using (var imageStream = new MemoryStream())
                {
                    await response.ResponseStream.CopyToAsync(imageStream);

                    // Resize the image using the in-memory stream
                    var resizedImage = ResizeImage(Image.FromStream(imageStream), width, height);

                    // Update the PictureBox with the resized image
                    pictureBox.Image = resizedImage;
                    pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error retrieving image: {ex.Message}");
        }
    }

    public static Image ResizeImage(Image image, int width, int height)
    {
        // Create a new bitmap with the desired width and height
        var resizedImage = new Bitmap(width, height);

        // Set the resolution of the resized image to match the source image
        resizedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

        // Create a Graphics object from the resized image
        using (var graphics = Graphics.FromImage(resizedImage))
        {
            // Set the interpolation mode and pixel offset mode for high-quality resizing
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            // Draw the original image onto the resized image
            graphics.DrawImage(image, 0, 0, width, height);
        }

        return resizedImage;
    }


    private void UpdatePictureBox(string imagePath)
    {
        var image = Image.FromFile(imagePath);
        pictureBox4.Image = image;
        pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
    }

    private async Task<string> UploadToS3(string filePath, string type, List<string> images)
    {
        var s3Client = new AmazonS3Client(AccessKey, SecretKey, RegionEndpoint.APSouth1);

        // Generate a unique key for the uploaded image
        var key = Guid.NewGuid() + Path.GetExtension(filePath);

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

            if (type == "user")
            {
                var client = new HttpClient();
                var email = Properties.Settings.Default.Email;
                var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/user/{email}/add/image");
                request.Headers.Add("img", $"{key}");
                var response = await client.SendAsync(request);
                var httpResponseMessage = response.EnsureSuccessStatusCode();
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Okay");
                    materialTabControl1.SelectedIndex = 0;
                    return null;
                }

                MessageBox.Show("Not Okay");
                return null;
            }

            if (type == "food-images")
            {
                images.Add(key);
                return key;
            }

            return null;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error uploading image: {ex.Message}");
            return null;
        }
    }

    public void ResizeImage(string sourceFilePath, string destFilePath, int maxWidth, int maxHeight)
    {
        using (var sourceImage = Image.FromFile(sourceFilePath))
        {
            var width = sourceImage.Width;
            var height = sourceImage.Height;

            // Calculate the new dimensions while preserving the aspect ratio
            if (width > maxWidth || height > maxHeight)
            {
                var aspectRatio = (double)width / height;
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

            using (var resizedImage = new Bitmap(width, height))
            {
                using (var graphics = Graphics.FromImage(resizedImage))
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
        var processedFilePath =
            Path.Combine(Path.GetDirectoryName(filePath), "processed_" + Path.GetFileName(filePath));

        try
        {
            // Apply low-quality blur effect to the image
            using (var originalImage = Image.FromFile(filePath))
            {
                using (var processedImage = new Bitmap(originalImage.Width, originalImage.Height))
                {
                    using (var graphics = Graphics.FromImage(processedImage))
                    {
                        graphics.SmoothingMode = SmoothingMode.HighSpeed;
                        graphics.InterpolationMode = InterpolationMode.Low;
                        graphics.DrawImage(originalImage,
                            new Rectangle(0, 0, processedImage.Width, processedImage.Height));
                    }

                    // Save the processed image to the temporary file path
                    processedImage.Save(processedFilePath, ImageFormat.Jpeg);
                }
            }

            // Upload the processed image to AWS S3
            UploadToS3(processedFilePath, "user", null);

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
            var filePath = openFileDialog.FileName;
            var selectedImage = Image.FromFile(filePath);
            metroLabel4.Visible = selectedImage != null;
            metroLabel4.Enabled = selectedImage != null;
            metroLabel4.Text = filePath;
        }
    }

    private void materialButton1_Click_2(object sender, EventArgs e)
    {
        var filePath = openFileDialog.FileName;
        if (filePath == null)
        {
            MessageBox.Show("Pick a image");
            return;
        }

        var resizedFilePath = Path.Combine(Path.GetDirectoryName(filePath), "resized_" + Path.GetFileName(filePath));

        // Resize the image
        ResizeImage(filePath, resizedFilePath, 800, 600);

        // Upload the resized image to S3
        UploadToS3(resizedFilePath, "user", null);

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
        var token = Properties.Settings.Default.TokenValue;
        var email = Properties.Settings.Default.Email;

        var firstName = FirstName_txt.Text;
        var lastName = LastName.Text;
        var userEmail = Email.Text;
        var address = Address.Text;

        if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(email))
        {
            Invoke(() => { MessageBox.Show("Invalid Input: Passwords do not match"); }); // Invoke on UI thread
            return;
        }

        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Put, $"http://localhost:8080/updateUser/{email}");
        request.Headers.Add("Authorization", $"Bearer {token}");

        var content = new
        {
            firstName,
            lastName,
            email = userEmail,
            address
        };

        var json = JsonConvert.SerializeObject(content);
        var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
        request.Content = stringContent;

        var response = await client.SendAsync(request);
        var httpResponseMessage = response.EnsureSuccessStatusCode();

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

        Invoke(new Action(() => MessageBox.Show("Try Again")));
    }

    private void button3_Click(object sender, EventArgs e)
    {
        var loginForm = new UserLogin();
        loginForm.MinimizeBox = false;
        loginForm.MaximizeBox = false;
        loginForm.FormClosed += ChildForm_FormClosed;
        Blur();
        loginForm.Show();
        UnBlur();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        var SingUp = new SingUp();
        SingUp.MinimizeBox = false;
        SingUp.MaximizeBox = false;
        SingUp.FormClosed += ChildForm_FormClosed;
        Blur();
        SingUp.Show();
        UnBlur();
    }

    private void UploadImages_Click(object sender, EventArgs e)
    {
        openFileDialog.Multiselect = true;
        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string[] imagePaths = openFileDialog.FileNames;

            DisplayImages(imagePaths);
        }
    }

    private void DisplayImages(string[] imagePaths)
    {
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.WrapContents = false;
        flowLayoutPanel1.Padding = new Padding(10);
        flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;

        foreach (var imagePath in imagePaths)
        {
            flowLayoutPanel1.Controls.Add(new ImageDetail(imagePath, false, false));
            images.Add(imagePath);
        }
    }

    private async void Save_Click(object sender, EventArgs e)
    {
        if (images.IsNullOrEmpty()) return;
        var img = new List<string>();

        var loadingForm =
            new LoadingForm("https://cdn.dribbble.com/users/295241/screenshots/4496315/loading-animation.gif");
        loadingForm.Show();
        images.ForEach(image => { UploadToS3(image, "food-images", img); });


        var token = Properties.Settings.Default.TokenValue;
        var email = Properties.Settings.Default.Email;
        if (token == null || email == null)
        {
            MessageBox.Show("Authentication Need");
            return;
        }

        try
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, $"http://localhost:8080/{email}/add-shop-item");
            request.Headers.Add("Authorization", $"Bearer {token}");

            var item_name = ItemName.Text;
            var description = Description.Text;
            var price = int.Parse(Price.Text);

            var content = new
            {
                name = item_name,
                description,
                price,
                pics = img.ToArray()
            };

            var json = JsonConvert.SerializeObject(content);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            request.Content = stringContent;

            var response = await client.SendAsync(request);
            var httpResponseMessage = response.EnsureSuccessStatusCode();

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
                                loadingForm.Close();
                                MessageBox.Show("Success");
                                materialTabControl1.Refresh();
                                Home.Refresh();
                                materialTabControl1.SelectedIndex = 0;
                                home(null);
                            });
                            break;
                        case "An error occurred.":
                            Invoke(() => { MessageBox.Show("Try Again"); }); // Invoke on UI thread
                            break;
                    }
                else
                    Invoke(() => { MessageBox.Show("Try Again"); });

                return;
            }

            Invoke(new Action(() => MessageBox.Show("Try Again")));
        }
        catch (Exception ex)
        {
            Invoke(new Action(() => MessageBox.Show(ex.Message)));
        }
    }

    private void pictureBox2_Click_1(object sender, EventArgs e)
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
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string EmailVerify { get; set; }
    public string Email { get; set; }
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

public class Item : IEquatable<Item>
{
    public static IEqualityComparer<Item> IdNamePicLowResComparer { get; } = new IdNamePicLowResEqualityComparer();

    public string _id { get; set; }
    public string Name { get; set; }
    public string PicLowRes { get; set; }

    public bool Equals(Item? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _id == other._id && Name == other.Name && PicLowRes == other.PicLowRes;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Item)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_id, Name, PicLowRes);
    }

    public static bool operator ==(Item? left, Item? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Item? left, Item? right)
    {
        return !Equals(left, right);
    }

    private sealed class IdNamePicLowResEqualityComparer : IEqualityComparer<Item>
    {
        public bool Equals(Item x, Item y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x._id == y._id && x.Name == y.Name && x.PicLowRes == y.PicLowRes;
        }

        public int GetHashCode(Item obj)
        {
            return HashCode.Combine(obj._id, obj.Name, obj.PicLowRes);
        }
    }
}

public class Response : IEquatable<Response>
{
    public static IEqualityComparer<Response> StatusBodyComparer { get; } = new StatusBodyEqualityComparer();

    public string status { get; set; }
    public HashSet<Item> body { get; set; }

    public bool Equals(Response? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return status == other.status && body.Equals(other.body);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Response)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(status, body);
    }

    public static bool operator ==(Response? left, Response? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Response? left, Response? right)
    {
        return !Equals(left, right);
    }

    private sealed class StatusBodyEqualityComparer : IEqualityComparer<Response>
    {
        public bool Equals(Response x, Response y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.status == y.status && x.body.Equals(y.body);
        }

        public int GetHashCode(Response obj)
        {
            return HashCode.Combine(obj.status, obj.body);
        }
    }
}