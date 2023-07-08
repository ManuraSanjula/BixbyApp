namespace Bixbu_UI
{
    partial class Comment
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
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            SuspendLayout();
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.BackColor = Color.White;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel1.Location = new Point(21, 14);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(74, 19);
            metroLabel1.TabIndex = 0;
            metroLabel1.Text = "Comment";
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.BackColor = Color.White;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel2.Location = new Point(21, 49);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(39, 19);
            metroLabel2.TabIndex = 1;
            metroLabel2.Text = "User";
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.BackColor = Color.White;
            metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel3.Location = new Point(21, 84);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(53, 19);
            metroLabel3.TabIndex = 2;
            metroLabel3.Text = "ItemID";
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.BackColor = Color.White;
            metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel4.Location = new Point(135, 14);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(86, 19);
            metroLabel4.TabIndex = 3;
            metroLabel4.Text = "metroLabel4";
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.BackColor = Color.White;
            metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel5.Location = new Point(136, 49);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(86, 19);
            metroLabel5.TabIndex = 4;
            metroLabel5.Text = "metroLabel5";
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.BackColor = Color.White;
            metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel6.Location = new Point(136, 84);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(86, 19);
            metroLabel6.TabIndex = 5;
            metroLabel6.Text = "metroLabel6";
            // 
            // Comment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(metroLabel6);
            Controls.Add(metroLabel5);
            Controls.Add(metroLabel4);
            Controls.Add(metroLabel3);
            Controls.Add(metroLabel2);
            Controls.Add(metroLabel1);
            Name = "Comment";
            Size = new Size(557, 118);
            Load += Comment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}
