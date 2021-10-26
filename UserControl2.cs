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
    public partial class UserControl2 : UserControl
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bs;
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            afficher();
        }

        private void afficher()
        {

            try
            {
                string requette = @"SELECT * FROM Ligne";
                con.Open();
                cmd = new SqlCommand(requette, con);
                dr = cmd.ExecuteReader();
                bs = new BindingSource();
                bs.DataSource = dr;
                dataGridView1.DataSource = bs;
                DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                dgvCmb.ValueType = typeof(bool);
                dgvCmb.Name = "supp";
                dgvCmb.HeaderText = "Supprimer";
                dgvCmb.ReadOnly = false;
                dataGridView1.Columns.Add(dgvCmb);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString( Convert.ToBoolean(dataGridView1.Rows[0].Cells["supp"].Value)));
            //MessageBox.Show(dataGridView1.Rows[0].Cells[1].Value.ToString());
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
             {
                 if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["supp"].Value) == true)
                 {
                     /*string requette = @"DELETE FROM Ligne WHERE Code_ligne = @codeligne";
                     con.Open();
                     cmd = new SqlCommand(requette, con);
                     cmd.Parameters.AddWithValue("@codeligne", dataGridView1.Rows[i].Cells[1].Value);
                     cmd.ExecuteNonQuery();*/

                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("Syppression Reussi!");

                 }
             }
             con.Close();
             //afficher();

            //try
            //{
            //    string requette = @"DELETE FROM Ligne WHERE Code_car = @code_car";
            //    con.Open();
            //    cmd = new SqlCommand(requette, con);
            //    cmd.Parameters.AddWithValue("@Code_car", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Syppression Reussi!");
            //}
            //catch (Exception EX)
            //{
            //    MessageBox.Show(EX.Message);
            //}
            //finally
            //{
            //    con.Close();
            //    afficher();
            //}
        }
    }
}
