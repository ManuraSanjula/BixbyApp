using Bixby_web_server.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bixbu_UI
{
    public partial class Comment : UserControl
    {
        public String commentText { get; }
        public String user { get; }
        public String item { get; }
        public Comment(String comment, String user, String itemId)
        {
            this.commentText = comment;
            this.user = user;
            this.item = itemId;
            InitializeComponent();
        }

        private void Comment_Load(object sender, EventArgs e)
        {
            metroLabel4.Text = commentText;
            metroLabel5.Text = user;
            metroLabel6.Text = item;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {
        }
    }
}
