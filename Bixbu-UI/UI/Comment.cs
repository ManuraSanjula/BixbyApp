namespace Bixbu_UI;

public partial class Comment : UserControl
{
    public Comment(string comment, string user, string itemId)
    {
        commentText = comment;
        this.user = user;
        item = itemId;
        InitializeComponent();
    }

    public string commentText { get; }
    public string user { get; }
    public string item { get; }

    private void Comment_Load(object sender, EventArgs e)
    {
        metroLabel4.Text = commentText;
        metroLabel5.Text = user;
        metroLabel6.Text = item;
    }

    private void metroLabel1_Click(object sender, EventArgs e)
    {
    }

    private void metroLabel2_Click(object sender, EventArgs e)
    {
    }

    private void metroLabel3_Click(object sender, EventArgs e)
    {
    }

    private void metroLabel4_Click(object sender, EventArgs e)
    {
    }

    private void metroLabel5_Click(object sender, EventArgs e)
    {
    }

    private void metroLabel6_Click(object sender, EventArgs e)
    {
    }

    private void metroLabel5_Click_1(object sender, EventArgs e)
    {

    }
}