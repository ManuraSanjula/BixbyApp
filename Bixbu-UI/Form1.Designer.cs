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
        metroButton2 = new MetroFramework.Controls.MetroButton();
        metroLabel1 = new MetroFramework.Controls.MetroLabel();
        metroLabel4 = new MetroFramework.Controls.MetroLabel();
        materialButton3 = new MaterialSkin.Controls.MaterialButton();
        materialButton2 = new MaterialSkin.Controls.MaterialButton();
        materialButton1 = new MaterialSkin.Controls.MaterialButton();
        Address = new MaterialSkin.Controls.MaterialTextBox2();
        Email = new MaterialSkin.Controls.MaterialTextBox2();
        metroLabel3 = new MetroFramework.Controls.MetroLabel();
        LastName = new MaterialSkin.Controls.MaterialTextBox2();
        metroLabel2 = new MetroFramework.Controls.MetroLabel();
        FirstName_txt = new MaterialSkin.Controls.MaterialTextBox2();
        FirstName = new MetroFramework.Controls.MetroLabel();
        pictureBox4 = new PictureBox();
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
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
        materialTabControl1.Location = new Point(3, 64);
        materialTabControl1.Margin = new Padding(3, 2, 3, 2);
        materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
        materialTabControl1.Multiline = true;
        materialTabControl1.Name = "materialTabControl1";
        materialTabControl1.SelectedIndex = 0;
        materialTabControl1.Size = new Size(1260, 692);
        materialTabControl1.SizeMode = TabSizeMode.Fixed;
        materialTabControl1.TabIndex = 0;
        // 
        // Home
        // 
        Home.Controls.Add(panel2);
        Home.Location = new Point(4, 24);
        Home.Margin = new Padding(3, 2, 3, 2);
        Home.Name = "Home";
        Home.Size = new Size(1252, 664);
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
        panel2.Size = new Size(1252, 664);
        panel2.TabIndex = 0;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.White;
        pictureBox2.Dock = DockStyle.Fill;
        pictureBox2.Image = Properties.Resources.ezgif_com_webp_to_jpg;
        pictureBox2.Location = new Point(0, 0);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(1252, 664);
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
        Account.Size = new Size(1252, 664);
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
        panel1.Size = new Size(1246, 660);
        panel1.TabIndex = 2;
        // 
        // panel3
        // 
        panel3.Controls.Add(metroButton2);
        panel3.Controls.Add(metroLabel1);
        panel3.Controls.Add(metroLabel4);
        panel3.Controls.Add(materialButton3);
        panel3.Controls.Add(materialButton2);
        panel3.Controls.Add(materialButton1);
        panel3.Controls.Add(Address);
        panel3.Controls.Add(Email);
        panel3.Controls.Add(metroLabel3);
        panel3.Controls.Add(LastName);
        panel3.Controls.Add(metroLabel2);
        panel3.Controls.Add(FirstName_txt);
        panel3.Controls.Add(FirstName);
        panel3.Controls.Add(pictureBox4);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(1246, 660);
        panel3.TabIndex = 4;
        // 
        // metroButton2
        // 
        metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
        metroButton2.Highlight = true;
        metroButton2.Location = new Point(200, 488);
        metroButton2.Name = "metroButton2";
        metroButton2.Size = new Size(190, 36);
        metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
        metroButton2.TabIndex = 23;
        metroButton2.Text = "LogOut";
        metroButton2.UseCustomBackColor = true;
        metroButton2.UseCustomForeColor = true;
        metroButton2.UseSelectable = true;
        metroButton2.UseStyleColors = true;
        metroButton2.Click += metroButton2_Click_1;
        // 
        // metroLabel1
        // 
        metroLabel1.AutoSize = true;
        metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
        metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
        metroLabel1.Location = new Point(453, 505);
        metroLabel1.Name = "metroLabel1";
        metroLabel1.Size = new Size(80, 25);
        metroLabel1.TabIndex = 15;
        metroLabel1.Text = "Address";
        // 
        // metroLabel4
        // 
        metroLabel4.AutoSize = true;
        metroLabel4.Location = new Point(39, 444);
        metroLabel4.Name = "metroLabel4";
        metroLabel4.Size = new Size(83, 19);
        metroLabel4.TabIndex = 13;
        metroLabel4.Text = "metroLabel4";
        // 
        // materialButton3
        // 
        materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        materialButton3.Depth = 0;
        materialButton3.HighEmphasis = true;
        materialButton3.Icon = null;
        materialButton3.Location = new Point(39, 488);
        materialButton3.Margin = new Padding(4, 6, 4, 6);
        materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
        materialButton3.Name = "materialButton3";
        materialButton3.NoAccentTextColor = Color.Empty;
        materialButton3.Size = new Size(110, 36);
        materialButton3.TabIndex = 12;
        materialButton3.Text = "Selet a file";
        materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        materialButton3.UseAccentColor = false;
        materialButton3.UseVisualStyleBackColor = true;
        materialButton3.Click += materialButton3_Click_1;
        // 
        // materialButton2
        // 
        materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        materialButton2.Depth = 0;
        materialButton2.HighEmphasis = true;
        materialButton2.Icon = null;
        materialButton2.Location = new Point(200, 565);
        materialButton2.Margin = new Padding(4, 6, 4, 6);
        materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
        materialButton2.Name = "materialButton2";
        materialButton2.NoAccentTextColor = Color.Empty;
        materialButton2.Size = new Size(190, 36);
        materialButton2.TabIndex = 10;
        materialButton2.Text = "Update Your Account";
        materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        materialButton2.UseAccentColor = false;
        materialButton2.UseVisualStyleBackColor = true;
        materialButton2.Click += materialButton2_Click;
        // 
        // materialButton1
        // 
        materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        materialButton1.Depth = 0;
        materialButton1.HighEmphasis = true;
        materialButton1.Icon = null;
        materialButton1.Location = new Point(39, 565);
        materialButton1.Margin = new Padding(4, 6, 4, 6);
        materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
        materialButton1.Name = "materialButton1";
        materialButton1.NoAccentTextColor = Color.Empty;
        materialButton1.Size = new Size(105, 36);
        materialButton1.TabIndex = 9;
        materialButton1.Text = "Upload Pic";
        materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        materialButton1.UseAccentColor = false;
        materialButton1.UseVisualStyleBackColor = true;
        materialButton1.Click += materialButton1_Click_2;
        // 
        // Address
        // 
        Address.AnimateReadOnly = true;
        Address.BackgroundImageLayout = ImageLayout.None;
        Address.CharacterCasing = CharacterCasing.Normal;
        Address.Depth = 0;
        Address.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        Address.HideSelection = true;
        Address.LeadingIcon = null;
        Address.Location = new Point(453, 565);
        Address.MaxLength = 32767;
        Address.MouseState = MaterialSkin.MouseState.OUT;
        Address.Name = "Address";
        Address.PasswordChar = '\0';
        Address.PrefixSuffixText = null;
        Address.ReadOnly = false;
        Address.RightToLeft = RightToLeft.No;
        Address.SelectedText = "";
        Address.SelectionLength = 0;
        Address.SelectionStart = 0;
        Address.ShortcutsEnabled = true;
        Address.Size = new Size(684, 36);
        Address.TabIndex = 8;
        Address.TabStop = false;
        Address.Text = "Address";
        Address.TextAlign = HorizontalAlignment.Left;
        Address.TrailingIcon = null;
        Address.UseAccent = false;
        Address.UseSystemPasswordChar = false;
        Address.UseTallSize = false;
        // 
        // Email
        // 
        Email.AnimateReadOnly = true;
        Email.BackgroundImageLayout = ImageLayout.None;
        Email.CharacterCasing = CharacterCasing.Normal;
        Email.Depth = 0;
        Email.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        Email.HideSelection = true;
        Email.LeadingIcon = null;
        Email.Location = new Point(453, 407);
        Email.MaxLength = 32767;
        Email.MouseState = MaterialSkin.MouseState.OUT;
        Email.Name = "Email";
        Email.PasswordChar = '\0';
        Email.PrefixSuffixText = null;
        Email.ReadOnly = false;
        Email.RightToLeft = RightToLeft.No;
        Email.SelectedText = "";
        Email.SelectionLength = 0;
        Email.SelectionStart = 0;
        Email.ShortcutsEnabled = true;
        Email.Size = new Size(684, 36);
        Email.TabIndex = 6;
        Email.TabStop = false;
        Email.Text = "Email";
        Email.TextAlign = HorizontalAlignment.Left;
        Email.TrailingIcon = null;
        Email.UseAccent = false;
        Email.UseSystemPasswordChar = false;
        Email.UseTallSize = false;
        // 
        // metroLabel3
        // 
        metroLabel3.AutoSize = true;
        metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
        metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
        metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
        metroLabel3.Location = new Point(453, 353);
        metroLabel3.Name = "metroLabel3";
        metroLabel3.Size = new Size(58, 25);
        metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
        metroLabel3.TabIndex = 5;
        metroLabel3.Text = "Email";
        // 
        // LastName
        // 
        LastName.AnimateReadOnly = true;
        LastName.BackgroundImageLayout = ImageLayout.None;
        LastName.CharacterCasing = CharacterCasing.Normal;
        LastName.Depth = 0;
        LastName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        LastName.HideSelection = true;
        LastName.LeadingIcon = null;
        LastName.Location = new Point(453, 254);
        LastName.MaxLength = 32767;
        LastName.MouseState = MaterialSkin.MouseState.OUT;
        LastName.Name = "LastName";
        LastName.PasswordChar = '\0';
        LastName.PrefixSuffixText = null;
        LastName.ReadOnly = false;
        LastName.RightToLeft = RightToLeft.No;
        LastName.SelectedText = "";
        LastName.SelectionLength = 0;
        LastName.SelectionStart = 0;
        LastName.ShortcutsEnabled = true;
        LastName.Size = new Size(684, 36);
        LastName.TabIndex = 4;
        LastName.TabStop = false;
        LastName.Text = "Last Name";
        LastName.TextAlign = HorizontalAlignment.Left;
        LastName.TrailingIcon = null;
        LastName.UseAccent = false;
        LastName.UseSystemPasswordChar = false;
        LastName.UseTallSize = false;
        // 
        // metroLabel2
        // 
        metroLabel2.AutoSize = true;
        metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
        metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
        metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
        metroLabel2.Location = new Point(453, 202);
        metroLabel2.Name = "metroLabel2";
        metroLabel2.Size = new Size(101, 25);
        metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
        metroLabel2.TabIndex = 3;
        metroLabel2.Text = "Last Name";
        // 
        // FirstName_txt
        // 
        FirstName_txt.AnimateReadOnly = true;
        FirstName_txt.BackgroundImageLayout = ImageLayout.None;
        FirstName_txt.CharacterCasing = CharacterCasing.Normal;
        FirstName_txt.Depth = 0;
        FirstName_txt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        FirstName_txt.HideSelection = true;
        FirstName_txt.LeadingIcon = null;
        FirstName_txt.Location = new Point(453, 101);
        FirstName_txt.MaxLength = 32767;
        FirstName_txt.MouseState = MaterialSkin.MouseState.OUT;
        FirstName_txt.Name = "FirstName_txt";
        FirstName_txt.PasswordChar = '\0';
        FirstName_txt.PrefixSuffixText = null;
        FirstName_txt.ReadOnly = false;
        FirstName_txt.RightToLeft = RightToLeft.No;
        FirstName_txt.SelectedText = "";
        FirstName_txt.SelectionLength = 0;
        FirstName_txt.SelectionStart = 0;
        FirstName_txt.ShortcutsEnabled = true;
        FirstName_txt.Size = new Size(684, 36);
        FirstName_txt.TabIndex = 2;
        FirstName_txt.TabStop = false;
        FirstName_txt.Text = "FirstName";
        FirstName_txt.TextAlign = HorizontalAlignment.Left;
        FirstName_txt.TrailingIcon = null;
        FirstName_txt.UseAccent = false;
        FirstName_txt.UseSystemPasswordChar = false;
        FirstName_txt.UseTallSize = false;
        // 
        // FirstName
        // 
        FirstName.AutoSize = true;
        FirstName.FontSize = MetroFramework.MetroLabelSize.Tall;
        FirstName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
        FirstName.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
        FirstName.Location = new Point(453, 60);
        FirstName.Name = "FirstName";
        FirstName.Size = new Size(103, 25);
        FirstName.Style = MetroFramework.MetroColorStyle.Blue;
        FirstName.TabIndex = 1;
        FirstName.Text = "First Name";
        // 
        // pictureBox4
        // 
        pictureBox4.Image = Properties.Resources.user_icon_in_trendy_flat_style_isolated_on_grey_background_user_symbol_for_your_web_site_design_logo_app_ui_illustration_eps10_free_vector;
        pictureBox4.Location = new Point(39, 45);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new Size(351, 363);
        pictureBox4.TabIndex = 0;
        pictureBox4.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImageLayout = ImageLayout.Center;
        pictureBox1.Image = Properties.Resources.ezgif_com_webp_to_png;
        pictureBox1.Location = new Point(396, 180);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(449, 362);
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // button1
        // 
        button1.Location = new Point(862, 28);
        button1.Name = "button1";
        button1.Size = new Size(173, 67);
        button1.TabIndex = 0;
        button1.Text = "Sign In";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // button2
        // 
        button2.Location = new Point(1065, 28);
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
        Settings.Size = new Size(1252, 664);
        Settings.TabIndex = 2;
        Settings.Text = "Settings";
        Settings.UseVisualStyleBackColor = true;
        // 
        // BixbyApp
        // 
        AutoScaleMode = AutoScaleMode.None;
        AutoSize = true;
        ClientSize = new Size(1266, 758);
        Controls.Add(materialTabControl1);
        DrawerTabControl = materialTabControl1;
        Margin = new Padding(3, 2, 3, 2);
        Name = "BixbyApp";
        Padding = new Padding(3, 64, 3, 2);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "BixbyApp";
        Load += Form1_Load;
        materialTabControl1.ResumeLayout(false);
        Home.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        Account.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
    private MetroFramework.Controls.MetroButton metroButton2;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroLabel metroLabel4;
    private MaterialSkin.Controls.MaterialButton materialButton3;
    private MaterialSkin.Controls.MaterialButton materialButton2;
    private MaterialSkin.Controls.MaterialButton materialButton1;
    private MaterialSkin.Controls.MaterialTextBox2 Address;
    private MaterialSkin.Controls.MaterialTextBox2 Email;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MaterialSkin.Controls.MaterialTextBox2 LastName;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MaterialSkin.Controls.MaterialTextBox2 FirstName_txt;
    private MetroFramework.Controls.MetroLabel FirstName;
    private PictureBox pictureBox4;
}