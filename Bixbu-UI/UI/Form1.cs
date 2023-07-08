using System.Collections.Concurrent;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Bixbu_UI.HTTP;
using Bixbu_UI.LoadingScreen;
using Bixbu_UI.Threads;
using Bixbu_UI.User;
using MailKit.Search;
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
    private readonly HttpClient client = new();
    private readonly List<string> images = new();

    private OpenFileDialog openFileDialog = new();
    private PictureBox pb;

    private HttpDataFetcher httpDataFetcher = new HttpDataFetcher();
    private ConcurrentHashSet<string> addedItems_v2 = new ConcurrentHashSet<string>();

    private bool isHomeUIExecuted = true;
    private object lockObject = new object();


    public BixbyApp()
    {
        InitializeComponent();

        var token = Properties.Settings.Default.TokenValue;
        var email = Properties.Settings.Default.Email;
        httpDataFetcher.FetchDataAsync(email, token).ContinueWith(task => {

            if (task.Exception != null)
            {
                MessageBox.Show($"An error occurred: {task.Exception.InnerException.Message}");
            }
            else
            {
                MessageBox.Show("Separate thread completed successfully!");
            }
        }, TaskScheduler.FromCurrentSynchronizationContext());


        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;

        // Disable form minimizing
        ShowIcon = false;

        TextBox textBox = new TextBox();
        textBox.Multiline = true;
        textBox.Height = 40;
        textBox.Width = home_panel.Width; 
        textBox.Font = new Font(textBox.Font.FontFamily, 14); 
        textBox.Text = "Enter your item to Search And If you done enter Press";
        textBox.KeyDown += TextBox_KeyDown;
        textBox.TextChanged += TextBox_TextChanged;


        home_panel.Controls.Add(textBox);

        AccountUI();
        HomeUI();
        CartUI();
        OrderUI();

    }


    private void search_logic(string searchQuery)
    {
        // Filter the HomeItem controls based on the search query
        var filteredItems = home_panel.Controls.OfType<HomeItem>().Where(item =>
            item.name.ToLower().Contains(searchQuery) ||
            item.url.ToLower().Contains(searchQuery) ||
            item.itemId.ToLower().Contains(searchQuery)
        ).ToList();

        // Show/hide the filtered HomeItem controls
        foreach (Control control in home_panel.Controls)
        {
            if (control is HomeItem homeItem)
            {
                homeItem.Visible = filteredItems.Contains(homeItem);
            }
        }
    }

    private void TextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            TextBox textBox = (TextBox)sender;
            string enteredText = textBox.Text;

            string searchQuery = textBox.Text.Trim().ToLower();
            search_logic(searchQuery);
        }
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        string searchQuery = textBox.Text.Trim().ToLower();

        search_logic(searchQuery);
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
    private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
    {
        // Check if the selected tab is the "Account" tab
        if (e.TabPage == Account)
            AccountUI();
        if (e.TabPage == Home)
            HomeUI();
    }

    private async void AccountUI()
    {
        await Task.Run(async () =>
        {
            Dictionary<string, object> userdata = await HttpDataFetcher.fetchUserTask;
            if (userdata != null)
            {
                // Update the UI based on the userDict data
                Email.Invoke((MethodInvoker)(() => Email.Text = userdata["Email"].ToString()));
                FirstName_txt.Invoke((MethodInvoker)(() => FirstName_txt.Text = userdata["FirstName"].ToString()));
                LastName.Invoke((MethodInvoker)(() => LastName.Text = userdata["LastName"].ToString()));
                Address.Invoke((MethodInvoker)(() => Address.Text = userdata["Address"].ToString()));

                var url = userdata["Pic"].ToString();
                if (!url.Equals("default"))
                {
                    var filename = Path.GetFileName(url);
                    RetrieveImageFromS3(url);
                }
            }
            else
            {
                panel1.Invoke((MethodInvoker)(() => panel1.Visible = true));
                panel4.Invoke((MethodInvoker)(() => panel4.Visible = true));
                panel3.Invoke((MethodInvoker)(() => panel3.Visible = false));
                panel5.Invoke((MethodInvoker)(() => panel5.Visible = false));
            }
        });
    }


    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Size = new Size(1268, 758);
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
        flowLayoutPanel1.Padding = new Padding(10); 

        home_panel.AutoScroll = true;
    }
    private async void OrderUI()
    {
       
    }

    private async void CartUI()
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

    private async void HomeUI()
    {
        await Task.Run(async () =>
        {
            HashSet<Item> items = await HttpDataFetcher.fetchItemsTask;
            if (items.Count > 0)
            {
                foreach (var item in items)
                {
                    if (item != null)
                    {
                        if (!addedItems_v2.Contains(item._id)) // Check if item is already added
                        {
                            home_panel.Invoke((MethodInvoker)(() =>
                            {
                                var home_item = new HomeItem(item.PicLowRes, item.Name, item._id, home_panel);
                                home_panel.Controls.Add(home_item);
                                addedItems_v2.Add(item._id); // Add item ID to the list
                            }));
                        }
                    }
                }
            }
            else
            {
               
            }
        });
    }


    private void tabControl1_Selecting(object? sender, EventArgs e)
    {
        var tab = (TabControl)sender;
        if (tab.SelectedTab == Account) AccountUI();
        if (tab.SelectedTab == Home) HomeUI();
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
        loginForm.Show();
    }


    private void button2_Click(object sender, EventArgs e)
    {
        var SingUp = new SingUp();
        SingUp.MinimizeBox = false;
        SingUp.MaximizeBox = false;
        SingUp.FormClosed += ChildForm_FormClosed;
        SingUp.Show();
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

    public static async Task RetrieveImageFromS3(string key, PictureBox pictureBox, int width, int height)
    {
        await Task.Run(async () =>
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
        });
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

    private async Task<string> UploadToS3Normal(string filePath, string type, List<string> images)
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

    private async Task<string> UploadToS3(string filePath, string type, ConcurrentBag<string> images)
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
        UploadToS3Normal(resizedFilePath, "user", null);

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
        loginForm.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        var SingUp = new SingUp();
        SingUp.MinimizeBox = false;
        SingUp.MaximizeBox = false;
        SingUp.FormClosed += ChildForm_FormClosed;
        SingUp.Show();
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

    private ConcurrentBag<string> img = new ConcurrentBag<string>();

    private async void Save_Click(object sender, EventArgs e)
    {
        if (images.IsNullOrEmpty())
            return;

        var loadingForm = new LoadingForm("https://cdn.dribbble.com/users/295241/screenshots/4496315/loading-animation.gif");
        loadingForm.Show();

        await Task.Run(() =>
        {
            images.ForEach(async image =>
            {
               await UploadToS3(image, "food-images", img);
            });
        });

        var token = Properties.Settings.Default.TokenValue;
        var email = Properties.Settings.Default.Email;
        if (token == null || email == null)
        {
            Invoke((MethodInvoker)(() =>
            {
                MessageBox.Show("Authentication Need");
            }));
            return;
        }

        await Task.Run(() =>
        {
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

                var response = client.SendAsync(request).GetAwaiter().GetResult();
                var httpResponseMessage = response.EnsureSuccessStatusCode();

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    var jsonResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var jObject = JObject.Parse(jsonResult);
                    var status = jObject["status"]?.Value<string>();

                    if (status != null)
                    {
                        switch (status)
                        {
                            case "Success":
                                Invoke((MethodInvoker)(async () =>
                                {
                                    loadingForm.Close();
                                    MessageBox.Show("Success");
                                    var token = Properties.Settings.Default.TokenValue;
                                    var email = Properties.Settings.Default.Email;
                                    materialTabControl1.Refresh();
                                    Home.Refresh();
                                    materialTabControl1.SelectedIndex = 0;
                                    await httpDataFetcher.RefreshDataAsync(email, token);
                                    HomeUI();

                                }));
                                break;
                            case "An error occurred.":
                                Invoke((MethodInvoker)(() =>
                                {
                                    MessageBox.Show("Try Again");
                                }));
                                break;
                        }
                    }
                    else
                    {
                        Invoke((MethodInvoker)(() =>
                        {
                            MessageBox.Show("Try Again");
                        }));
                    }

                    return;
                }

                Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Try Again");
                }));
            }
            catch (Exception ex)
            {
                Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show(ex.Message);
                }));
            }
        });
    }

    private void pictureBox2_Click_1(object sender, EventArgs e)
    {
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