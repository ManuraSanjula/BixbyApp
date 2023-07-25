using Bixbu_UI.Properties;
using MetroFramework.Forms;
using Newtonsoft.Json.Linq;

namespace Bixbu_UI.User;

public partial class UserLogin : MetroForm
{
    public UserLogin()
    {
        InitializeComponent();
    }

    private void UserLogin_Load(object sender, EventArgs e)
    {
    }

    private void metroButton1_Click(object sender, EventArgs e)
    {
        try
        {
            var email = textBox1.Text;
            var password = Password.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                Invoke(new Action(() => MessageBox.Show("Try Again"))); // Invoke on UI thread
                return;
            }

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:8080/login");

            var json = $"{{\r\n    \"email\": \"{email}\",\r\n    \"password\": \"{password}\"\r\n}}";
            var content = new StringContent(json, null, "application/json");
            request.Content = content;

            var responseTask = client.SendAsync(request);
            responseTask.ContinueWith(responseTask =>
            {
                var response = responseTask.Result;
                var jsonResultTask = response.Content.ReadAsStringAsync();
                jsonResultTask.ContinueWith(jsonResultTask =>
                {
                    var jsonResult = jsonResultTask.Result;
                    var jObject = JObject.Parse(jsonResult);
                    var status = jObject["status"]?.Value<string>();
                    var token = jObject["token"]?.Value<string>();

                    if (status == "Success")
                    {
                        try
                        {
                            Invoke(() =>
                            {
                                Settings.Default.TokenValue = token;
                                Settings.Default.Email = email;
                                Settings.Default.Save();
                                MessageBox.Show("Success");
                                Close();
                            });
                        }
                        catch (Exception ex)
                        {
                        }

                        MessageBox.Show(Settings.Default.Email);
                    }
                    else
                    {
                        Invoke(new Action(() => MessageBox.Show("Try Again"))); // Invoke on UI thread
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        catch (Exception ex)
        {
            Invoke(new Action(() => MessageBox.Show("An error occurred. Try Again"))); // Invoke on UI thread
        }
        finally
        {
            Invoke(() => { });
        }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
    }
}