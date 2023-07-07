namespace Bixbu_UI;

public partial class ImageDetail : UserControl
{
    private string resizedFilePath;

    public ImageDetail(string url)
    {
        InitializeComponent();
        pictureBox1.Image = Image.FromFile(url);
        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
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