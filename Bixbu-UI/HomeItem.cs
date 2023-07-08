using System.Windows.Forms;

namespace Bixbu_UI
{
    public partial class HomeItem : UserControl
    {
        private bool isFormLocked = false;
        public string path { get; }
        public string namae { get; }
        public string id { get; }
        public FlowLayoutPanel flowLayoutPanel;
        public HomeItem(string url, string name, string id, FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            this.path = url;
            this.Name = name;
            this.namae = name;
            metroLabel1.Text = name;
            this.id = id;
            BixbyApp.RetrieveImageFromS3(url, pictureBox1, false);
            this.flowLayoutPanel = flowLayoutPanel;
        }

        private void HomeItem_Load(object sender, EventArgs e)
        {

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
                var fullItemDetails = new FullItemDetails(id);
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
            {
                if (control != this)
                {
                    control.Enabled = false;
                }
            }
        }

        private void LockControls(Control excludeControl)
        {
            foreach (Control control in Controls)
            {
                if (control != excludeControl)
                {
                    control.Enabled = false;
                }
            }
        }

        private void UnlockControls(Form form)
        {
            foreach (Control control in form.Controls)
            {
                control.Enabled = true;
            }
        }

        private void UnlockControls()
        {
            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            click();
        }
    }
}
