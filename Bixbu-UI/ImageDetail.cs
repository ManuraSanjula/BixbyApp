using System.Windows.Forms;

namespace Bixbu_UI;

public partial class ImageDetail : UserControl
{
    public string path { get; }
    public string original { get; }
    private bool aws { get; set; }
    public ImageDetail(string url, string original, bool aws, bool full)
    {
        InitializeComponent();
        this.original = original;
        this.path = url;
        this.original = original;
        this.aws = aws;
        if (aws)
        {
            BixbyApp.RetrieveImageFromS3(url, pictureBox1, full);
        }
        else
        {
            pictureBox1.Image = Image.FromFile(url);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }

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



public partial class SecondForm : Form
{
    public SecondForm(String image)
    {
        // Set the properties of the second form
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MinimizeBox = false;
        MaximizeBox = false;

        // Create a PictureBox control and set its size and image
        var pictureBox = new PictureBox();
        // Add the PictureBox to the second form
        Controls.Add(pictureBox);
        BixbyApp.RetrieveImageFromS3(image, pictureBox, true);
    }
}