using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EFM_Kesh_2018_19
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bs;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Image imag = Image.FromFile("../ctm.jpg");          
            e.Graphics.DrawImage(imag, new Point(0, 0));         
        }

        private void miseAJourDesAutocarsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserControl1 us1 = new UserControl1();
            panel1.Controls.Add(us1);
            us1.Dock = DockStyle.Fill;
            us1.BringToFront();
            us1.Show();         
        }

        private void listeDesLignesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserControl2 us2 = new UserControl2();
            panel1.Controls.Add(us2);
            us2.Dock = DockStyle.Fill;
            us2.BringToFront();
            us2.Show();
        }

        private void voyagesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserControl3 us3 = new UserControl3();
            panel1.Controls.Add(us3);
            us3.Dock = DockStyle.Fill;
            us3.BringToFront();
            us3.Show();
        }
    }
}
