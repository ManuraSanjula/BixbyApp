namespace Bixbu_UI.UI
{
    partial class CartItemuserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            metroLabel7 = new MetroFramework.Controls.MetroLabel();
            metroLabel8 = new MetroFramework.Controls.MetroLabel();
            metroButton1 = new MetroFramework.Controls.MetroButton();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel1.Location = new Point(30, 19);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(39, 19);
            metroLabel1.TabIndex = 1;
            metroLabel1.Text = "Item";
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel2.Location = new Point(30, 54);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(39, 19);
            metroLabel2.TabIndex = 2;
            metroLabel2.Text = "User";
            metroLabel2.Click += metroLabel2_Click;
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel3.Location = new Point(30, 87);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(66, 19);
            metroLabel3.TabIndex = 3;
            metroLabel3.Text = "Quantity";
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel4.Location = new Point(30, 121);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.RightToLeft = RightToLeft.Yes;
            metroLabel4.Size = new Size(43, 19);
            metroLabel4.TabIndex = 4;
            metroLabel4.Text = "Price";
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.Location = new Point(119, 54);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(33, 19);
            metroLabel6.TabIndex = 6;
            metroLabel6.Text = "----";
            metroLabel6.Click += metroLabel6_Click;
            // 
            // metroLabel7
            // 
            metroLabel7.AutoSize = true;
            metroLabel7.Location = new Point(120, 87);
            metroLabel7.Name = "metroLabel7";
            metroLabel7.Size = new Size(39, 19);
            metroLabel7.TabIndex = 7;
            metroLabel7.Text = "-----";
            metroLabel7.Click += metroLabel7_Click;
            // 
            // metroLabel8
            // 
            metroLabel8.AutoSize = true;
            metroLabel8.Location = new Point(120, 121);
            metroLabel8.Name = "metroLabel8";
            metroLabel8.Size = new Size(45, 19);
            metroLabel8.TabIndex = 8;
            metroLabel8.Text = "------";
            // 
            // metroButton1
            // 
            metroButton1.Highlight = true;
            metroButton1.Location = new Point(1112, 15);
            metroButton1.Name = "metroButton1";
            metroButton1.Size = new Size(91, 23);
            metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            metroButton1.TabIndex = 10;
            metroButton1.Text = "Delete";
            metroButton1.UseCustomBackColor = true;
            metroButton1.UseCustomForeColor = true;
            metroButton1.UseSelectable = true;
            metroButton1.UseStyleColors = true;
            metroButton1.Click += metroButton1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(120, 19);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(34, 21);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "----";
            // 
            // CartItemuserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(linkLabel1);
            Controls.Add(metroButton1);
            Controls.Add(metroLabel8);
            Controls.Add(metroLabel7);
            Controls.Add(metroLabel6);
            Controls.Add(metroLabel4);
            Controls.Add(metroLabel3);
            Controls.Add(metroLabel2);
            Controls.Add(metroLabel1);
            Name = "CartItemuserControl";
            Size = new Size(1246, 168);
            Load += CartItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        public MetroFramework.Controls.MetroLabel metroLabel7;
        public MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButton1;
        private LinkLabel linkLabel1;
    }
}
