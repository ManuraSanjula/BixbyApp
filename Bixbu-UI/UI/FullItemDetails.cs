using System.Text;
using Bixbu_UI.Properties;
using Bixbu_UI.UI;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Bixbu_UI;

public partial class FullItemDetails : Form
{
    private readonly List<string> addedComments = new(); // Track added comments

    private readonly List<string> addedImages = new(); // Track added images
    private Product product;
    private int price;
    public FullItemDetails(string id)
    {
        InitializeComponent();
        this.id = id;

        flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.WrapContents = false;
        flowLayoutPanel1.Padding = new Padding(10); // Adjust the padding as per your requirement

        flowLayoutPanel2.AutoScroll = true;
        flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
        flowLayoutPanel2.WrapContents = false;

        Task.Run(async () =>
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/shopItem/{id}/view");
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();

                    var json = JObject.Parse(jsonData);
                    var body = json["body"];
                    // Deserialize the modified JSON to the Product class
                    product = body.ToObject<Product>();

                    // Update the UI controls using Control.Invoke
                    Invoke((MethodInvoker)(() =>
                    {
                        foreach (var key in product.Pics)
                            if (!addedImages.Contains(key)) // Check if image is already added
                                if (!ControlPropertiesForImage(flowLayoutPanel1.Controls, key))
                                {
                                    flowLayoutPanel1.Controls.Add(new ImageDetail(key, true, false));
                                    addedImages.Add(key); // Add image to the list
                                }

                        metroLabel1.Text = product.Name;
                        metroLabel2.Text = product.Description;
                        metroLabel4.Text = product.Price.ToString();
                        price = product.Price;
                    }));

                    fetchingComments();
                }
                // Handle the error case
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        });
    }

    private string id { get; }

    private bool ControlPropertiesForImage(Control.ControlCollection controls, string key)
    {
        foreach (Control control in controls)
            if (control is ImageDetail myUserControl)
                if (myUserControl.path == key)
                    return true;
        return false;
    }

    private bool ControlPropertiesForComment(Control.ControlCollection controls, string commentText, string user,
        string item)
    {
        foreach (Control control in controls)
            if (control is Comment myUserControl)
                if (myUserControl.commentText == commentText && myUserControl.user == user &&
                    myUserControl.item == item)
                    return true;
        return false;
    }

    private void FullItemDetails_Load(object sender, EventArgs e)
    {
    }

    private void fetchingComments()
    {
        Task.Run(async () =>
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get,
                    $"http://localhost:8080/shopItem/{product._id}/comment");
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();

                var parsedResponse = JsonConvert.DeserializeObject<ResponseModel>(jsonResponse);

                var body = parsedResponse.Body;

                var comments = new List<CommentModel>(parsedResponse.Body);
                comments.ForEach(comment =>
                {
                    if (!addedComments.Contains(comment.UserComment)) // Check if comment is already added
                        if (!ControlPropertiesForComment(flowLayoutPanel2.Controls, comment.UserComment, comment.User,
                                comment.ShopItem))
                            // Update the UI controls using Control.Invoke
                            Invoke((MethodInvoker)(() =>
                            {
                                flowLayoutPanel2.Controls.Add(new Comment(comment.UserComment, comment.User,
                                    comment.ShopItem));
                                addedComments.Add(comment.UserComment); // Add comment to the list
                            }));
                });
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        });
    }


    private async void Comment_Click(object sender, EventArgs e)
    {
        try
        {
            var token = Settings.Default.TokenValue;
            var email = Settings.Default.Email;

            if (token == null || email == null)
            {
                MessageBox.Show("Authentication Need");
                Close();
            }

            var content = new
            {
                UserComment = CommetBox.Text
            };
            var client = new HttpClient();
            var request =
                new HttpRequestMessage(HttpMethod.Post, $"http://localhost:8080/shopItem/{product._id}/comment");

            var json = JsonConvert.SerializeObject(content);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            request.Content = stringContent;

            request.Headers.Add("Authorization", $"Bearer {token}");
            var response = await client.SendAsync(request);
            var httpResponseMessage = response.EnsureSuccessStatusCode();

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(jsonResult);
                var status = jObject["status"]?.Value<string>();
                if (status == "Success")
                {
                    MessageBox.Show("Success");
                    fetchingComments();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error");
        }
    }

    private void flowLayoutPanel1_Click(object sender, PaintEventArgs e)
    {
        MessageBox.Show("Error");
    }

    private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Task.Run(async () =>
        {
            try
            {
                var token = Settings.Default.TokenValue;
                var email = Settings.Default.Email;

                if (token == null || email == null) MessageBox.Show("Authentication Need");
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get,
                    $"http://localhost:8080/shopItem/{id}/buy/{email}");
                request.Headers.Add("Authorization", $"Bearer {token}");

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                {
                    var jsonResult = await response.Content.ReadAsStringAsync();
                    var jObject = JObject.Parse(jsonResult);
                    var status = jObject["status"]?.Value<string>();
                    if (status == "Success")
                    {
                        MessageBox.Show("Success");

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


    private void materialButton1_Click(object sender, EventArgs e)
    {
        var form = new Payment(price);
        form.ShowDialog();
        form.FormClosed += ChildForm_FormClosed;
    }
}

public class Product
{
    public string _id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public long TotalComments { get; set; }
    public int Price { get; set; }
    public string[] Pics { get; set; }
    public Publish publish { get; set; }
    public int loveThisProduct { get; set; }
}

public class Publish
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Pic { get; set; }
}

public class ResponseModel
{
    public string Status { get; set; }
    public CommentModel[] Body { get; set; }
}

public class CommentModel
{
    public string _id { get; set; }
    public string UserComment { get; set; }
    public string User { get; set; }
    public string ShopItem { get; set; }
}