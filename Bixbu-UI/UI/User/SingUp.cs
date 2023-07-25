using Bixbu_UI.Properties;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

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
    bool IsValidEmail(string email)
    {
        // Regular expression for email validation
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        // Create a Regex object with the pattern
        Regex regex = new Regex(pattern);

        // Use the IsMatch method to check if the email matches the pattern
        return regex.IsMatch(email);
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

                if(firstName == null || lastName == null || address == null)
                {
                    Invoke(new Action(() =>
                                           MetroFramework.MetroMessageBox.Show(this, "Missing Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error))); // Invoke on UI thread
                    return;
                }

                if (pass != con_pass)
                {
                    Invoke(new Action(() =>
                        MetroFramework.MetroMessageBox.Show(this,"Invalid Input: Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error))); // Invoke on UI thread
                    return;
                }
                if (!IsValidEmail(email))
                {
                    Invoke(new Action(() =>
                        MetroFramework.MetroMessageBox.Show(this, "Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error))); // Invoke on UI thread
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
                                    Settings.Default.TokenValue = token;
                                    Settings.Default.Save();

                                    Settings.Default.Email = email;
                                    Settings.Default.Save();
                                    MessageBox.Show("Success");
                                    Close();
                                });
                                break;
                            case "An error occurred.":
                                Invoke(new Action(() => MessageBox.Show("Try Again"))); // Invoke on UI thread
                                break;
                        }
                    else
                        Invoke(new Action(() => MessageBox.Show("Try Again"))); // Invoke on UI thread
                }
                else
                {
                    Invoke(new Action(() => MessageBox.Show("Try Again"))); // Invoke on UI thread
                }
            }
        }
        catch (Exception ex)
        {
            Invoke(new Action(() => MessageBox.Show("Try Again"))); // Invoke on UI thread
        }
    }

    private void materialButton2_Click(object sender, EventArgs e)
    {
        Close();
    }
}