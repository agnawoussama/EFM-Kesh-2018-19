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


namespace EFM_Kesh_2018_19
{
    public partial class UserControl3 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = EfmKesh18; Integrated Security = True");
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bs;
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            fill_comboBox();
            afficher();
        }

        private void afficher()
        {

            try
            {
                string requette = @"SELECT * FROM Voyage";
                con.Open();
                cmd = new SqlCommand(requette, con);
                dr = cmd.ExecuteReader();
                bs = new BindingSource();
                bs.DataSource = dr;
                dataGridView1.DataSource = bs;
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur!");
            }
            finally
            {
                con.Close();
                //dr.Close();
            }
        }


        private void fill_comboBox()
        {
            string requette = @"SELECT nom FROM Personnel";

            using (cmd = new SqlCommand(requette, con))
            {
                con.Open();

                using (dr = cmd.ExecuteReader())
                {
                    // Call Read before accessing data.
                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr.GetString(0));
                    }
                }

                con.Close();
            }

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string requette1 = @"SELECT * FROM Personnel WHERE matricule = @matricule";               
                con.Open();
                cmd = new SqlCommand(requette1, con);
                cmd.Parameters.AddWithValue("@matricule", comboBox1.SelectedItem.ToString());
                dr = cmd.ExecuteReader();
                string Matricule = dr.GetString(0);
                //dr.Close();

                string requette2 = $@"SELECT * FROM Voyage WHERE matricule = @matricule" ;
                cmd.Parameters.AddWithValue("@matricule", Matricule);
                cmd.CommandText = requette2;
                dr = cmd.ExecuteReader();

                //cmd.Parameters.AddWithValue("@matricule", comboBox1.SelectedItem.ToString());
                bs = new BindingSource();
                bs.DataSource = dr;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                //dr.Close();
            }
        }
    }
}
