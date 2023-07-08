namespace Bixbu_UI.User
{
    partial class UserLogin
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
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            textBox1 = new TextBox();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            metroButton1 = new MetroFramework.Controls.MetroButton();
            Password = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel1.Location = new Point(36, 91);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(53, 25);
            metroLabel1.TabIndex = 5;
            metroLabel1.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 128);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(554, 31);
            textBox1.TabIndex = 6;
            textBox1.UseSystemPasswordChar = true;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel2.Location = new Point(36, 182);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(82, 25);
            metroLabel2.TabIndex = 8;
            metroLabel2.Text = "Password";
            // 
            // metroButton1
            // 
            metroButton1.DisplayFocus = true;
            metroButton1.Highlight = true;
            metroButton1.Location = new Point(36, 296);
            metroButton1.Name = "metroButton1";
            metroButton1.Size = new Size(123, 32);
            metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            metroButton1.TabIndex = 9;
            metroButton1.Text = "Login";
            metroButton1.UseCustomBackColor = true;
            metroButton1.UseCustomForeColor = true;
            metroButton1.UseSelectable = true;
            metroButton1.UseStyleColors = true;
            metroButton1.Click += metroButton1_Click;
            // 
            // Password
            // 
            Password.AnimateReadOnly = false;
            Password.BackgroundImageLayout = ImageLayout.None;
            Password.CharacterCasing = CharacterCasing.Normal;
            Password.Depth = 0;
            Password.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Password.HideSelection = true;
            Password.LeadingIcon = null;
            Password.Location = new Point(36, 220);
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
            Password.Size = new Size(554, 48);
            Password.TabIndex = 10;
            Password.TabStop = false;
            Password.TextAlign = HorizontalAlignment.Left;
            Password.TrailingIcon = null;
            Password.UseSystemPasswordChar = true;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 370);
            Controls.Add(Password);
            Controls.Add(metroButton1);
            Controls.Add(metroLabel2);
            Controls.Add(textBox1);
            Controls.Add(metroLabel1);
            Name = "UserLogin";
            Padding = new Padding(3, 60, 3, 3);
            Text = "UserLogin";
            Load += UserLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private TextBox textBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MaterialSkin.Controls.MaterialTextBox2 Password;
    }
}