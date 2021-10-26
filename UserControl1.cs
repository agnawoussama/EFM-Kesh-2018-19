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
    public partial class UserControl1 : UserControl
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            dgvAutocar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            fill_comboBox();
            afficher();
        }

        private void fill_comboBox()
        {
            string requette = @"SELECT Nom_marque FROM Marque";

            using (cmd = new SqlCommand(requette, con))
            {
                con.Open();

                using (dr = cmd.ExecuteReader())
                {
                    // Call Read before accessing data.
                    while (dr.Read())
                    {
                        cmbx_Mrque.Items.Add(dr.GetString(0));
                    }
                }

                con.Close();
            }

            //try
            //{
            //    con.Open();
            //    cmd = new SqlCommand("SELECT Nom_marque FROM Marque", con);
            //    dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        cmbx_Mrque.Items.Add(dr.GetString(0));
            //    }
                
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Erreur!");
            //}
            //finally
            //{
            //    con.Close();
            //    dr.Close();
            //}
        }

        private void afficher()
        {           

            try
            {
                string requette = @"SELECT * FROM Autocar";
                con.Open();
                cmd = new SqlCommand(requette, con);
                dr = cmd.ExecuteReader();               
                bs.DataSource = dr;
                dgvAutocar.DataSource = bs;
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

        private void btnAjt_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                string requette = @"INSERT INTO Autocar VALUES (@Code_car, @capacite, @date_achat, @consommation, @nom_marque)";

                /*if (txtbx_codeCar.Text != "") { cmd.CommandText = @"INSERT INTO Autocar VALUES (@Code_car)"; cmd.ExecuteNonQuery(); }
                if (txtbx_codeCar.Text != "") { cmd.CommandText = @"INSERT INTO Autocar VALUES (@Code_car)"; cmd.ExecuteNonQuery(); }
                if (txtbx_codeCar.Text != "") { cmd.CommandText = @"INSERT INTO Autocar VALUES (@Code_car)"; cmd.ExecuteNonQuery(); }
                if (txtbx_codeCar.Text != "") { cmd.CommandText = @"INSERT INTO Autocar VALUES (@Code_car)"; cmd.ExecuteNonQuery(); }
                if (txtbx_codeCar.Text != "") { cmd.CommandText = @"INSERT INTO Autocar VALUES (@Code_car)"; cmd.ExecuteNonQuery(); }*/




                cmd.CommandText = requette;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@Code_car", txtbx_codeCar.Text);
                cmd.Parameters.AddWithValue("@capacite", txtbx_Cpcit.Text);
                cmd.Parameters.AddWithValue("@date_achat", dtmpck_dtAchat.Text);
                cmd.Parameters.AddWithValue("@consommation", txtbx_cnsom.Text);
                cmd.Parameters.AddWithValue("@nom_marque", cmbx_Mrque.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                bs.DataSource = dr;
                dgvAutocar.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ee");
            }
            finally
            {            
                con.Close();
                afficher();
            }

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                string requette = @"UPDATE Autocar SET capacite = @capacite, date_achat = @date_achat ,consommation = @consommation, nom_marque = @nom_marque WHERE Code_car = @code_car";
                con.Open();
                cmd = new SqlCommand(requette, con);
                cmd.Parameters.AddWithValue("@Code_car", txtbx_codeCar.Text) ;
                cmd.Parameters.AddWithValue("@capacite", txtbx_Cpcit.Text);
                cmd.Parameters.AddWithValue("@date_achat", dtmpck_dtAchat.Text);
                cmd.Parameters.AddWithValue("@consommation", txtbx_cnsom.Text);
                cmd.Parameters.AddWithValue("@nom_marque", cmbx_Mrque.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modification Reussi!");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
                afficher();
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            try
            {
                string requette = @"DELETE FROM Autocar WHERE Code_car = @code_car";
                con.Open();
                cmd = new SqlCommand(requette, con);
                cmd.Parameters.AddWithValue("@Code_car", dgvAutocar.SelectedRows[0].Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Syppression Reussi!");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
                afficher();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnPrvs_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnNxt_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }
    }
}
