using Bixbu_UI.Properties;
using Bixbu_UI.SQL;
using MaterialSkin.Controls;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bixbu_UI;

public partial class SingUp : MaterialForm
{
    public SingUp()
    {
        InitializeComponent();
    }


    private void SingUp_Load(object sender, EventArgs e)
    {
    }

    private async void materialButton1_Click(object sender, EventArgs e)
    {
        try
        {
            using (var client = new HttpClient())
            {
                var firstName = materialTextBox21.Text;
                var lastName = materialTextBox22.Text;
                var email = materialTextBox23.Text;
                var address = materialTextBox24.Text;
                var pass = materialTextBox25.Text;
                var con_pass = materialTextBox26.Text;

                if (pass != con_pass)
                {
                    Invoke(new Action(() =>
                        MessageBox.Show("Invalid Input: Passwords do not match"))); // Invoke on UI thread
                    return;
                }

                var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:8080/addUser");

                var json = $"{{\r\n    \"firstName\":\"{firstName}\",\r\n    " +
                           $"\"lastName\":\"{lastName}\",\r\n    " +
                           $"\"email\":\"{email}\",\r\n    " +
                           $"\"address\":\"{address}\",\r\n    " +
                           $"\"password\":\"{pass}\",\r\n    " +
                           $"\"confirmNewPassword\":\"{con_pass}\"\r\n}}";

                var content = new StringContent(json, null, "application/json");

                request.Content = content;
                var response = await client.SendAsync(request);
                var httpResponseMessage = response.EnsureSuccessStatusCode();
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    var jsonResult = await response.Content.ReadAsStringAsync();
                    var jObject = JObject.Parse(jsonResult);
                    var status = jObject["status"]?.Value<string>();
                    var token = jObject["token"]?.Value<string>();
                    if (status != null)
                        switch (status)
                        {
                            case "Success":
                                Invoke(() =>
                                {
                                    Properties.Settings.Default.TokenValue = token;
                                    Properties.Settings.Default.Save();

                                    Properties.Settings.Default.Email = email;
                                    Properties.Settings.Default.Save();
                                    MessageBox.Show("Success");
                                    Close();
                                    return;
                                });
                                break;
                            case "An error occurred.":
                                Invoke(new Action(() => MessageBox.Show("Try Again"))); // Invoke on UI thread
                                break;
                        }
                    else
                    {
                        Invoke(new Action(() => MessageBox.Show("Try Again"))); // Invoke on UI thread
                        return;
                    }
                }
                else
                {
                    Invoke(new Action(() => MessageBox.Show("Try Again"))); // Invoke on UI thread
                    return;
                }
            }
        }
        catch (Exception ex)
        {
            Invoke(new Action(() => MessageBox.Show("Try Again"))); // Invoke on UI thread
            return;
        }
        return;
    }

    private void materialButton2_Click(object sender, EventArgs e)
    {
        Close();
    }
}