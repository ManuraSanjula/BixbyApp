namespace Bixbu_UI.UI
{
    partial class OrderItemUserControll
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
            metroLabel8 = new MetroFramework.Controls.MetroLabel();
            metroLabel7 = new MetroFramework.Controls.MetroLabel();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            metroLabel9 = new MetroFramework.Controls.MetroLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // metroLabel8
            // 
            metroLabel8.AutoSize = true;
            metroLabel8.Location = new Point(102, 109);
            metroLabel8.Name = "metroLabel8";
            metroLabel8.Size = new Size(83, 19);
            metroLabel8.TabIndex = 16;
            metroLabel8.Text = "metroLabel8";
            // 
            // metroLabel7
            // 
            metroLabel7.AutoSize = true;
            metroLabel7.Location = new Point(102, 75);
            metroLabel7.Name = "metroLabel7";
            metroLabel7.Size = new Size(83, 19);
            metroLabel7.TabIndex = 15;
            metroLabel7.Text = "metroLabel7";
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.Location = new Point(101, 42);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(83, 19);
            metroLabel6.TabIndex = 14;
            metroLabel6.Text = "metroLabel6";
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel4.Location = new Point(12, 109);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.RightToLeft = RightToLeft.Yes;
            metroLabel4.Size = new Size(43, 19);
            metroLabel4.TabIndex = 13;
            metroLabel4.Text = "Price";
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel3.Location = new Point(12, 75);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(63, 19);
            metroLabel3.TabIndex = 12;
            metroLabel3.Text = "Confirm";
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel2.Location = new Point(12, 42);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(39, 19);
            metroLabel2.TabIndex = 11;
            metroLabel2.Text = "User";
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel1.Location = new Point(12, 11);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(23, 19);
            metroLabel1.TabIndex = 17;
            metroLabel1.Text = "ID";
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.Location = new Point(101, 11);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(83, 19);
            metroLabel5.TabIndex = 18;
            metroLabel5.Text = "metroLabel5";
            // 
            // metroLabel9
            // 
            metroLabel9.AutoSize = true;
            metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel9.Location = new Point(12, 152);
            metroLabel9.Name = "metroLabel9";
            metroLabel9.RightToLeft = RightToLeft.Yes;
            metroLabel9.Size = new Size(45, 19);
            metroLabel9.TabIndex = 19;
            metroLabel9.Text = "Items";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(101, 142);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1130, 81);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(1073, 11);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 21;
            materialButton1.Text = "Confirm Delivery";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // OrderItemUserControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(materialButton1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(metroLabel9);
            Controls.Add(metroLabel5);
            Controls.Add(metroLabel1);
            Controls.Add(metroLabel8);
            Controls.Add(metroLabel7);
            Controls.Add(metroLabel6);
            Controls.Add(metroLabel4);
            Controls.Add(metroLabel3);
            Controls.Add(metroLabel2);
            Name = "OrderItemUserControll";
            Size = new Size(1246, 242);
            Load += OrderItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}
