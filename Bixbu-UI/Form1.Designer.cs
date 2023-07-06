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
        metroButton1 = new MetroFramework.Controls.MetroButton();
        materialTextBox23 = new MaterialSkin.Controls.MaterialTextBox2();
        materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
        Password = new MaterialSkin.Controls.MaterialTextBox2();
        metroLabel7 = new MetroFramework.Controls.MetroLabel();
        metroLabel6 = new MetroFramework.Controls.MetroLabel();
        metroLabel5 = new MetroFramework.Controls.MetroLabel();
        metroLabel1 = new MetroFramework.Controls.MetroLabel();
        hScrollBar1 = new HScrollBar();
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
        openFileDialog1 = new OpenFileDialog();
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
        materialTabControl1.Location = new Point(3, 48);
        materialTabControl1.Margin = new Padding(3, 2, 3, 2);
        materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
        materialTabControl1.Multiline = true;
        materialTabControl1.Name = "materialTabControl1";
        materialTabControl1.SelectedIndex = 0;
        materialTabControl1.Size = new Size(1781, 1015);
        materialTabControl1.SizeMode = TabSizeMode.Fixed;
        materialTabControl1.TabIndex = 0;
        // 
        // Home
        // 
        Home.Controls.Add(panel2);
        Home.Location = new Point(4, 24);
        Home.Margin = new Padding(3, 2, 3, 2);
        Home.Name = "Home";
        Home.Size = new Size(1773, 987);
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
        panel2.Size = new Size(1773, 987);
        panel2.TabIndex = 0;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.White;
        pictureBox2.Dock = DockStyle.Fill;
        pictureBox2.Image = Properties.Resources.ezgif_com_webp_to_jpg;
        pictureBox2.Location = new Point(0, 0);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(1773, 987);
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
        Account.Size = new Size(1773, 987);
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
        panel1.Size = new Size(1767, 983);
        panel1.TabIndex = 2;
        // 
        // panel3
        // 
        panel3.Controls.Add(metroButton1);
        panel3.Controls.Add(materialTextBox23);
        panel3.Controls.Add(materialTextBox22);
        panel3.Controls.Add(Password);
        panel3.Controls.Add(metroLabel7);
        panel3.Controls.Add(metroLabel6);
        panel3.Controls.Add(metroLabel5);
        panel3.Controls.Add(metroLabel1);
        panel3.Controls.Add(hScrollBar1);
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
        panel3.Size = new Size(1767, 983);
        panel3.TabIndex = 3;
        // 
        // metroButton1
        // 
        metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
        metroButton1.Highlight = true;
        metroButton1.Location = new Point(1347, 467);
        metroButton1.Name = "metroButton1";
        metroButton1.Size = new Size(165, 43);
        metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
        metroButton1.TabIndex = 22;
        metroButton1.Text = "Update Password";
        metroButton1.UseCustomBackColor = true;
        metroButton1.UseCustomForeColor = true;
        metroButton1.UseSelectable = true;
        metroButton1.UseStyleColors = true;
        // 
        // materialTextBox23
        // 
        materialTextBox23.AnimateReadOnly = true;
        materialTextBox23.BackgroundImageLayout = ImageLayout.None;
        materialTextBox23.CharacterCasing = CharacterCasing.Normal;
        materialTextBox23.Depth = 0;
        materialTextBox23.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        materialTextBox23.HideSelection = true;
        materialTextBox23.LeadingIcon = null;
        materialTextBox23.Location = new Point(1347, 395);
        materialTextBox23.MaxLength = 32767;
        materialTextBox23.MouseState = MaterialSkin.MouseState.OUT;
        materialTextBox23.Name = "materialTextBox23";
        materialTextBox23.PasswordChar = '●';
        materialTextBox23.PrefixSuffixText = null;
        materialTextBox23.ReadOnly = false;
        materialTextBox23.RightToLeft = RightToLeft.No;
        materialTextBox23.SelectedText = "";
        materialTextBox23.SelectionLength = 0;
        materialTextBox23.SelectionStart = 0;
        materialTextBox23.ShortcutsEnabled = true;
        materialTextBox23.Size = new Size(385, 36);
        materialTextBox23.TabIndex = 21;
        materialTextBox23.TabStop = false;
        materialTextBox23.Text = "Confirm Password";
        materialTextBox23.TextAlign = HorizontalAlignment.Left;
        materialTextBox23.TrailingIcon = null;
        materialTextBox23.UseAccent = false;
        materialTextBox23.UseSystemPasswordChar = true;
        materialTextBox23.UseTallSize = false;
        // 
        // materialTextBox22
        // 
        materialTextBox22.AnimateReadOnly = true;
        materialTextBox22.BackgroundImageLayout = ImageLayout.None;
        materialTextBox22.CharacterCasing = CharacterCasing.Normal;
        materialTextBox22.Depth = 0;
        materialTextBox22.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        materialTextBox22.HideSelection = true;
        materialTextBox22.LeadingIcon = null;
        materialTextBox22.Location = new Point(1347, 254);
        materialTextBox22.MaxLength = 32767;
        materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
        materialTextBox22.Name = "materialTextBox22";
        materialTextBox22.PasswordChar = '●';
        materialTextBox22.PrefixSuffixText = null;
        materialTextBox22.ReadOnly = false;
        materialTextBox22.RightToLeft = RightToLeft.No;
        materialTextBox22.SelectedText = "";
        materialTextBox22.SelectionLength = 0;
        materialTextBox22.SelectionStart = 0;
        materialTextBox22.ShortcutsEnabled = true;
        materialTextBox22.Size = new Size(385, 36);
        materialTextBox22.TabIndex = 20;
        materialTextBox22.TabStop = false;
        materialTextBox22.Text = "New Password";
        materialTextBox22.TextAlign = HorizontalAlignment.Left;
        materialTextBox22.TrailingIcon = null;
        materialTextBox22.UseAccent = false;
        materialTextBox22.UseSystemPasswordChar = true;
        materialTextBox22.UseTallSize = false;
        // 
        // Password
        // 
        Password.AnimateReadOnly = true;
        Password.BackgroundImageLayout = ImageLayout.None;
        Password.CharacterCasing = CharacterCasing.Normal;
        Password.Depth = 0;
        Password.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        Password.HideSelection = true;
        Password.LeadingIcon = null;
        Password.Location = new Point(1347, 110);
        Password.MaxLength = 32767;
        Password.MouseState = MaterialSkin.MouseState.OUT;
        Password.Name = "Password";
        Password.PasswordChar = '●';
        Password.PrefixSuffixText = null;
        Password.ReadOnly = false;
        Password.RightToLeft = RightToLeft.No;
        Password.SelectedText = "";
        Password.SelectionLength = 0;
        Password.SelectionStart = 0;
        Password.ShortcutsEnabled = true;
        Password.Size = new Size(385, 36);
        Password.TabIndex = 19;
        Password.TabStop = false;
        Password.Text = "Current Password";
        Password.TextAlign = HorizontalAlignment.Left;
        Password.TrailingIcon = null;
        Password.UseAccent = false;
        Password.UseSystemPasswordChar = true;
        Password.UseTallSize = false;
        // 
        // metroLabel7
        // 
        metroLabel7.AutoSize = true;
        metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
        metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
        metroLabel7.Location = new Point(1347, 340);
        metroLabel7.Name = "metroLabel7";
        metroLabel7.Size = new Size(165, 25);
        metroLabel7.TabIndex = 18;
        metroLabel7.Text = "Confirm Password";
        // 
        // metroLabel6
        // 
        metroLabel6.AutoSize = true;
        metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
        metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
        metroLabel6.Location = new Point(1347, 202);
        metroLabel6.Name = "metroLabel6";
        metroLabel6.Size = new Size(135, 25);
        metroLabel6.TabIndex = 17;
        metroLabel6.Text = "New Password";
        // 
        // metroLabel5
        // 
        metroLabel5.AutoSize = true;
        metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
        metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
        metroLabel5.Location = new Point(1347, 60);
        metroLabel5.Name = "metroLabel5";
        metroLabel5.Size = new Size(161, 25);
        metroLabel5.TabIndex = 16;
        metroLabel5.Text = "Current Password";
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
        // hScrollBar1
        // 
        hScrollBar1.Location = new Point(1241, 60);
        hScrollBar1.Name = "hScrollBar1";
        hScrollBar1.Size = new Size(55, 839);
        hScrollBar1.TabIndex = 14;
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
        // 
        // materialButton2
        // 
        materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        materialButton2.Depth = 0;
        materialButton2.HighEmphasis = true;
        materialButton2.Icon = null;
        materialButton2.Location = new Point(979, 672);
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
        Settings.Size = new Size(1757, 948);
        Settings.TabIndex = 2;
        Settings.Text = "Settings";
        Settings.UseVisualStyleBackColor = true;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // BixbyApp
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(1787, 1065);
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
    private PictureBox pictureBox4;
    private MetroFramework.Controls.MetroLabel FirstName;
    private MaterialSkin.Controls.MaterialTextBox2 Address;
    private MaterialSkin.Controls.MaterialTextBox2 Email;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MaterialSkin.Controls.MaterialTextBox2 LastName;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MaterialSkin.Controls.MaterialTextBox2 FirstName_txt;
    private MaterialSkin.Controls.MaterialButton materialButton2;
    private MaterialSkin.Controls.MaterialButton materialButton1;
    private OpenFileDialog openFileDialog1;
    private MaterialSkin.Controls.MaterialButton materialButton3;
    private MetroFramework.Controls.MetroLabel metroLabel4;
    private HScrollBar hScrollBar1;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MaterialSkin.Controls.MaterialTextBox2 materialTextBox23;
    private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
    private MaterialSkin.Controls.MaterialTextBox2 Password;
    private MetroFramework.Controls.MetroLabel metroLabel7;
    private MetroFramework.Controls.MetroLabel metroLabel6;
    private MetroFramework.Controls.MetroLabel metroLabel5;
    private MetroFramework.Controls.MetroButton metroButton1;
}