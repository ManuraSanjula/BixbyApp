using Braintree;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Bixbu_UI
{
    public partial class FullItemDetails : Form
    {
        private String id { get; set; }
        private Product product;
        public FullItemDetails(string id)
        {
            InitializeComponent();
            this.id = id;

            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Padding = new Padding(10); // Adjust the padding as per your requirement
        }

        private bool ControlPropertiesForImage(Control.ControlCollection controls, String key)
        {
            foreach (Control control in controls)
            {
                if (control is ImageDetail myUserControl)
                {
                    if (myUserControl.path == key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool ControlPropertiesForComment(Control.ControlCollection controls, String commentText, String user, string item)
        {
            foreach (Control control in controls)
            {
                if (control is Comment myUserControl)
                {
                    if (myUserControl.commentText == commentText && myUserControl.user == user && myUserControl.item == item)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private async void FullItemDetails_Load(object sender, EventArgs e)
        {
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel2.WrapContents = false;
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/shopItem/{id}/view");
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(jsonData);
                    JToken body = json["body"];
                    // Deserialize the modified JSON to the Product class
                    product = body.ToObject<Product>();
                    foreach (string key in product.PicsLowRes)
                    {
                        if (!ControlPropertiesForImage(flowLayoutPanel1.Controls, key))
                            flowLayoutPanel1.Controls.Add(new ImageDetail(key, null, true, false));
                    }
                    metroLabel1.Text = product.Name;
                    metroLabel2.Text = product.Description;
                    metroLabel4.Text = product.Price.ToString();

                    fetchingComments();

                }
                else
                {
                    // Handle the error case

                }
            }
            catch (Exception ex)
            {

            }
        }

        private async void fetchingComments()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/shopItem/{product._id}/comment");
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();

                var parsedResponse = JsonConvert.DeserializeObject<ResponseModel>(jsonResponse);

                var body = parsedResponse.Body;

                List<CommentModel> comments = new List<CommentModel>(parsedResponse.Body);
                comments.ForEach(comment =>
                {
                    if(!ControlPropertiesForComment(flowLayoutPanel2.Controls, comment.UserComment, comment.User, comment.ShopItem))
                        flowLayoutPanel2.Controls.Add(new Comment(comment.UserComment, comment.User, comment.ShopItem));
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private async void Comment_Click(object sender, EventArgs e)
        {
            try
            {
                var token = Properties.Settings.Default.TokenValue;
                var email = Properties.Settings.Default.Email;

                if (token == null || email == null)
                {
                    MessageBox.Show("Authentication Need");
                    this.Close();
                }

                var content = new
                {
                    UserComment = CommetBox.Text
                };
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, $"http://localhost:8080/shopItem/{product._id}/comment");

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
    }
    public class Product
    {
        public string _id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long TotalComments { get; set; }
        public int Price { get; set; }
        public string[] PicsLowRes { get; set; }
        public string[] PicsHighRes { get; set; }
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

}
