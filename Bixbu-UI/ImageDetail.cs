namespace Bixbu_UI;

public partial class ImageDetail : UserControl
{
    public ImageDetail(string url, bool aws, bool full)
    {
        InitializeComponent();
        path = url;
        if (aws)
        {
            BixbyApp.RetrieveImageFromS3(url, pictureBox1, 404, 251);
        }
        else
        {
            pictureBox1.Image = Image.FromFile(url);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }

    public string path { get; }

    protected override void OnHandleDestroyed(EventArgs e)
    {
        // Call the base implementation first
        base.OnHandleDestroyed(e);
        // Your code here
        // This function will be triggered when the user control is closing
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }
}

public class SecondForm : Form
{
    public SecondForm(string image)
    {
        // Set the properties of the second form
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MinimizeBox = false;
        MaximizeBox = false;

        // Create a PictureBox control and set its size and image
        var pictureBox = new PictureBox();
        // Add the PictureBox to the second form
        Controls.Add(pictureBox);
        //BixbyApp.RetrieveImageFromS3(image, pictureBox, true);
    }
}