﻿namespace Bixbu_UI
{
    partial class HomeItem
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
            pictureBox1 = new PictureBox();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            Cart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 251);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.BackColor = Color.White;
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel1.Location = new Point(12, 264);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(103, 25);
            metroLabel1.TabIndex = 1;
            metroLabel1.Text = "metroLabel1";
            metroLabel1.Click += metroLabel1_Click;
            // 
            // Cart
            // 
            Cart.BackColor = Color.CornflowerBlue;
            Cart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Cart.ForeColor = SystemColors.ActiveCaptionText;
            Cart.Location = new Point(22, 302);
            Cart.Name = "Cart";
            Cart.Size = new Size(78, 31);
            Cart.TabIndex = 2;
            Cart.Text = "Cart";
            Cart.UseVisualStyleBackColor = false;
            Cart.Click += Cart_Click;
            // 
            // HomeItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Cart);
            Controls.Add(metroLabel1);
            Controls.Add(pictureBox1);
            Name = "HomeItem";
            Size = new Size(405, 358);
            Load += HomeItem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public Button Cart;
    }
}
