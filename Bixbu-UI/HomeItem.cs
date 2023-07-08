using Bixbu_UI.Properties;
using Newtonsoft.Json.Linq;

namespace Bixbu_UI;

public partial class HomeItem : UserControl
{
    public FlowLayoutPanel flowLayoutPanel;
    private bool isFormLocked;

    public HomeItem(string url, string name, string id, FlowLayoutPanel flowLayoutPanel)
    {
        InitializeComponent();
        path = url;
        Name = name;
        this.name = name;
        metroLabel1.Text = name;
        itemId = id;
        BixbyApp.RetrieveImageFromS3(url, pictureBox1, 404, 251);
        this.flowLayoutPanel = flowLayoutPanel;
    }

    public string path { get; }
    public string name { get; }
    public string itemId { get; }

    private void HomeItem_Load(object sender, EventArgs e)
    {
        /* Task.Run(async() =>
         {
             var client = new HttpClient();
             var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:8080/order/w.m.manurasanjula12345@gmail.com/view");
             request.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJzdWJqZWN0IiwianRpIjoiNGY3M2I2MzMtMDA3MS00NjQxLWFhMWUtZDVlYWE3ZjMxNjIxIiwiaWF0IjoxNjg4NDY3OTc2LCJlbWFpbCI6IncubS5tYW51cmFzYW5qdWxhMTIzNDVAZ21haWwuY29tIiwicGFzc3dvcmQiOiIkMmEkMTEkcGxPRXEudUVhTHpGcG94NVZ3TU1pLlNrcUU5NUtqcFp0d2Q2a2M1VXhWRHVWNzBMLlhrYzYiLCJleHAiOjE2ODkwNjc5NzYsImlzcyI6Ik1hbnVyYSBTYW5qdWxhIiwiYXVkIjoiTWFudXJhIFNhbmp1bGEifQ.cqDDM9D0aD_Xvfyosx8ie3zKnw8oehdTrRFsZcv943c");
             var response = await client.SendAsync(request);
             response.EnsureSuccessStatusCode();
             Console.WriteLine(await response.Content.ReadAsStringAsync());
         });


         Task.Run(async () =>
         {
             var client = new HttpClient();
             var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:8080/cart/w.m.manurasanjula12345@gmail.com/view");
             request.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJzdWJqZWN0IiwianRpIjoiNGY3M2I2MzMtMDA3MS00NjQxLWFhMWUtZDVlYWE3ZjMxNjIxIiwiaWF0IjoxNjg4NDY3OTc2LCJlbWFpbCI6IncubS5tYW51cmFzYW5qdWxhMTIzNDVAZ21haWwuY29tIiwicGFzc3dvcmQiOiIkMmEkMTEkcGxPRXEudUVhTHpGcG94NVZ3TU1pLlNrcUU5NUtqcFp0d2Q2a2M1VXhWRHVWNzBMLlhrYzYiLCJleHAiOjE2ODkwNjc5NzYsImlzcyI6Ik1hbnVyYSBTYW5qdWxhIiwiYXVkIjoiTWFudXJhIFNhbmp1bGEifQ.cqDDM9D0aD_Xvfyosx8ie3zKnw8oehdTrRFsZcv943c");
             var response = await client.SendAsync(request);
             response.EnsureSuccessStatusCode();
             Console.WriteLine(await response.Content.ReadAsStringAsync());
         });*/
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        click();
    }

    private void click()
    {
        if (!isFormLocked)
        {
            isFormLocked = true;
            LockControls(ParentForm); // Disable other controls on the form
            var fullItemDetails = new FullItemDetails(itemId);
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

    private void LockControls(Control excludeControl)
    {
        foreach (Control control in Controls)
            if (control != excludeControl)
                control.Enabled = false;
    }

    private void UnlockControls(Form form)
    {
        foreach (Control control in form.Controls) control.Enabled = true;
    }

    private void UnlockControls()
    {
        foreach (Control control in Controls) control.Enabled = true;
    }

    private void metroLabel1_Click(object sender, EventArgs e)
    {
        click();
    }

    private void Cart_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            try
            {
                var token = Settings.Default.TokenValue;
                var email = Settings.Default.Email;
                var q = (int)numericUpDown1.Value;
                if (token == null || (email == null && q == 0))
                {
                    MessageBox.Show("Missing adata");
                    return;
                }

                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get,
                    $"http://localhost:8080/cart/{email}/{itemId}/add?Quantity={q}");
                request.Headers.Add("Authorization", $"Bearer {token}");
                var response = await client.SendAsync(request);
                if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                {
                    var jsonResult = await response.Content.ReadAsStringAsync();
                    var jObject = JObject.Parse(jsonResult);
                    var status = jObject["status"]?.Value<string>();
                    if (status == "Success")
                        MessageBox.Show("Success");
                    else
                        MessageBox.Show("Failed");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        });
    }

    private void Buy_Click(object sender, EventArgs e)
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
                    $"http://localhost:8080/shopItem/{itemId}/buy/{email}");
                request.Headers.Add("Authorization", $"Bearer {token}");
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                {
                    var jsonResult = await response.Content.ReadAsStringAsync();
                    var jObject = JObject.Parse(jsonResult);
                    var status = jObject["status"]?.Value<string>();
                    if (status == "Success")
                        MessageBox.Show("Success");
                    else
                        MessageBox.Show("Failed");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        });
    }
}