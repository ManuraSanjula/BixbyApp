namespace Bixbu_UI;

partial class BixbyApp
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
        Home = new TabPage();
        panel2 = new Panel();
        pictureBox2 = new PictureBox();
        Account = new TabPage();
        panel1 = new Panel();
        panel3 = new Panel();
        pictureBox1 = new PictureBox();
        button1 = new Button();
        button2 = new Button();
        Settings = new TabPage();
        materialTabControl1.SuspendLayout();
        Home.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        Account.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // materialTabControl1
        // 
        materialTabControl1.Controls.Add(Home);
        materialTabControl1.Controls.Add(Account);
        materialTabControl1.Controls.Add(Settings);
        materialTabControl1.Depth = 0;
        materialTabControl1.Dock = DockStyle.Fill;
        materialTabControl1.Location = new Point(3, 48);
        materialTabControl1.Margin = new Padding(3, 2, 3, 2);
        materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
        materialTabControl1.Multiline = true;
        materialTabControl1.Name = "materialTabControl1";
        materialTabControl1.SelectedIndex = 0;
        materialTabControl1.Size = new Size(1520, 764);
        materialTabControl1.SizeMode = TabSizeMode.Fixed;
        materialTabControl1.TabIndex = 0;
        // 
        // Home
        // 
        Home.Controls.Add(panel2);
        Home.Location = new Point(4, 24);
        Home.Margin = new Padding(3, 2, 3, 2);
        Home.Name = "Home";
        Home.Size = new Size(1534, 971);
        Home.TabIndex = 3;
        Home.Text = "Home";
        Home.UseVisualStyleBackColor = true;
        // 
        // panel2
        // 
        panel2.Controls.Add(pictureBox2);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(1534, 971);
        panel2.TabIndex = 0;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.White;
        pictureBox2.Dock = DockStyle.Fill;
        pictureBox2.Image = Properties.Resources.ezgif_com_webp_to_jpg;
        pictureBox2.Location = new Point(0, 0);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(1534, 971);
        pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
        pictureBox2.TabIndex = 0;
        pictureBox2.TabStop = false;
        pictureBox2.Click += pictureBox2_Click;
        // 
        // Account
        // 
        Account.Controls.Add(panel1);
        Account.Location = new Point(4, 24);
        Account.Margin = new Padding(3, 2, 3, 2);
        Account.Name = "Account";
        Account.Padding = new Padding(3, 2, 3, 2);
        Account.Size = new Size(1512, 736);
        Account.TabIndex = 1;
        Account.Text = "Account";
        Account.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.BackColor = Color.White;
        panel1.Controls.Add(panel3);
        panel1.Controls.Add(pictureBox1);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(button2);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 2);
        panel1.Name = "panel1";
        panel1.Size = new Size(1506, 732);
        panel1.TabIndex = 2;
        // 
        // panel3
        // 
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(1506, 732);
        panel3.TabIndex = 3;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImageLayout = ImageLayout.Center;
        pictureBox1.Image = Properties.Resources.ezgif_com_webp_to_png;
        pictureBox1.Location = new Point(481, 230);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(449, 362);
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // button1
        // 
        button1.Location = new Point(1015, 28);
        button1.Name = "button1";
        button1.Size = new Size(173, 67);
        button1.TabIndex = 0;
        button1.Text = "Sign In";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // button2
        // 
        button2.Location = new Point(1241, 28);
        button2.Name = "button2";
        button2.Size = new Size(173, 67);
        button2.TabIndex = 1;
        button2.Text = "Sign Up";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // Settings
        // 
        Settings.Location = new Point(4, 24);
        Settings.Margin = new Padding(3, 2, 3, 2);
        Settings.Name = "Settings";
        Settings.Size = new Size(1518, 932);
        Settings.TabIndex = 2;
        Settings.Text = "Settings";
        Settings.UseVisualStyleBackColor = true;
        // 
        // BixbyApp
        // 
        AutoScaleMode = AutoScaleMode.None;
        AutoSize = true;
        ClientSize = new Size(1526, 814);
        Controls.Add(materialTabControl1);
        DrawerTabControl = materialTabControl1;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 2, 3, 2);
        Name = "BixbyApp";
        Padding = new Padding(3, 48, 3, 2);
        Sizable = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "BixbyApp";
        Load += Form1_Load;
        materialTabControl1.ResumeLayout(false);
        Home.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        Account.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
    private TabPage Account;
    private TabPage Settings;
    private TabPage Home;
    private Button button2;
    private Button button1;
    private Panel panel1;
    private PictureBox pictureBox1;
    private Panel panel2;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private Panel panel3;
}