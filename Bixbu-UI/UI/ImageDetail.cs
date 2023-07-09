namespace Bixbu_UI;

public partial class ImageDetail : UserControl
{
    public ImageDetail(string url, bool aws, bool full)
    {
        InitializeComponent();
        path = url;
        if (aws)
            Task.Run(() => BixbyApp.RetrieveImageFromS3(url, pictureBox1, 404, 251));
        else
            Task.Run(() =>
            {
                pictureBox1.Image = Image.FromFile(url);
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            });
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