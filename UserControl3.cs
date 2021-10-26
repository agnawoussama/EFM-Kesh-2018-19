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
using System.IO;
using System.Xml.Serialization;

namespace EFM_Kesh_2018_19
{
    [Serializable]
    public partial class UserControl3 : UserControl
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
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
                dr.Close();
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
            //MessageBox.Show(comboBox1.SelectedItem.ToString());
            try
            {
                string requette1 = @"SELECT * FROM Personnel WHERE nom = @nom";               
                con.Open();
                cmd = new SqlCommand(requette1, con);
                cmd.Parameters.AddWithValue("@nom", comboBox1.SelectedItem.ToString());
                dr = cmd.ExecuteReader();
                string Matricule = "";
                if (dr.Read())
                {
                    Matricule = dr.GetString(0);                  
                }
                //MessageBox.Show(Matricule);
                dr.Close();
                
                string requette2 = $@"SELECT * FROM Voyage WHERE matricule = @matricule" ;
                cmd.Parameters.AddWithValue("@matricule", Matricule);
                cmd.CommandText = requette2;
                dr = cmd.ExecuteReader();

                //cmd.Parameters.AddWithValue("@matricule", comboBox1.SelectedItem.ToString());
                if (dr.HasRows)
                {
                    bs = new BindingSource();
                    bs.DataSource = dr;
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bs;
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Le Chauffeur n'a aucune voyage!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            afficher();
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.TableName = "Voyage";
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Voyage", con);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            //Xml Fichier
            FileStream fs = new FileStream("Voyages.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(DataTable));
            xs.Serialize(fs, dt);
            fs.Close();

            //Text Fichier
            FileStream fs2 = new FileStream("Voyages.txt", FileMode.Create, FileAccess.Write);
            using (TextWriter tw = new StreamWriter(fs2))
            {
                int col = dt.Columns.Count;
                tw.WriteLine("--------------------------TABLE VOYAGE--------------------------");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        tw.Write(" | "+dt.Rows[i][j].ToString());
                    }
                    tw.WriteLine(" | \n");
                }
            }
        }
    }
}
