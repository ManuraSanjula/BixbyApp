namespace Bixbu_UI
{
    partial class FullItemDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            metro1 = new MetroFramework.Controls.MetroLabel();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            CommetBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            Comment = new MaterialSkin.Controls.MaterialButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(6, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1242, 304);
            flowLayoutPanel1.TabIndex = 7;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // metro1
            // 
            metro1.AutoSize = true;
            metro1.BackColor = Color.White;
            metro1.FontSize = MetroFramework.MetroLabelSize.Tall;
            metro1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metro1.Location = new Point(13, 369);
            metro1.Name = "metro1";
            metro1.Size = new Size(62, 25);
            metro1.TabIndex = 8;
            metro1.Text = "Name";
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel1.Location = new Point(136, 369);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(33, 25);
            metroLabel1.TabIndex = 9;
            metroLabel1.Text = "---";
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel2.Location = new Point(136, 418);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(40, 25);
            metroLabel2.TabIndex = 12;
            metroLabel2.Text = "----";
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.BackColor = Color.White;
            metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel3.Location = new Point(12, 418);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(109, 25);
            metroLabel3.TabIndex = 11;
            metroLabel3.Text = "Description";
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel4.Location = new Point(136, 468);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(40, 25);
            metroLabel4.TabIndex = 14;
            metroLabel4.Text = "----";
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.BackColor = Color.White;
            metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel5.Location = new Point(13, 468);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(54, 25);
            metroLabel5.TabIndex = 13;
            metroLabel5.Text = "Price";
            // 
            // CommetBox
            // 
            CommetBox.AnimateReadOnly = false;
            CommetBox.BackgroundImageLayout = ImageLayout.None;
            CommetBox.CharacterCasing = CharacterCasing.Normal;
            CommetBox.Depth = 0;
            CommetBox.HideSelection = true;
            CommetBox.Location = new Point(12, 511);
            CommetBox.MaxLength = 32767;
            CommetBox.MouseState = MaterialSkin.MouseState.OUT;
            CommetBox.Name = "CommetBox";
            CommetBox.PasswordChar = '\0';
            CommetBox.ReadOnly = false;
            CommetBox.ScrollBars = ScrollBars.None;
            CommetBox.SelectedText = "";
            CommetBox.SelectionLength = 0;
            CommetBox.SelectionStart = 0;
            CommetBox.ShortcutsEnabled = true;
            CommetBox.Size = new Size(434, 122);
            CommetBox.TabIndex = 16;
            CommetBox.TabStop = false;
            CommetBox.Text = "Your Comment Here";
            CommetBox.TextAlign = HorizontalAlignment.Left;
            CommetBox.UseAccent = false;
            CommetBox.UseSystemPasswordChar = false;
            // 
            // Comment
            // 
            Comment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Comment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Comment.Depth = 0;
            Comment.HighEmphasis = true;
            Comment.Icon = null;
            Comment.Location = new Point(13, 669);
            Comment.Margin = new Padding(4, 6, 4, 6);
            Comment.MouseState = MaterialSkin.MouseState.HOVER;
            Comment.Name = "Comment";
            Comment.NoAccentTextColor = Color.Empty;
            Comment.Size = new Size(95, 36);
            Comment.TabIndex = 17;
            Comment.Text = "Comment";
            Comment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Comment.UseAccentColor = false;
            Comment.UseVisualStyleBackColor = true;
            Comment.Click += Comment_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(513, 408);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(735, 310);
            flowLayoutPanel2.TabIndex = 18;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(136, 669);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 19;
            materialButton1.Text = "Buy Now";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // FullItemDetails
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1254, 729);
            Controls.Add(materialButton1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(Comment);
            Controls.Add(CommetBox);
            Controls.Add(metroLabel4);
            Controls.Add(metroLabel5);
            Controls.Add(metroLabel2);
            Controls.Add(metroLabel3);
            Controls.Add(metroLabel1);
            Controls.Add(metro1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FullItemDetails";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FullItemDetails";
            Load += FullItemDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metro1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 CommetBox;
        private MaterialSkin.Controls.MaterialButton Comment;
        private FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}