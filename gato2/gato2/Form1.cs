using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gato2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        public void conexion()
        {
            string conString = null;
            conString = "Server=USUARIO-PC;Database=gato3;Trusted_Connection=true;";

            conn = new SqlConnection(conString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void limpiar()
        {
            txtguardar.Clear();

        }
        public void guardar_Click(object sender, EventArgs e)
        {
            if (txtguardar.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Error");
            }
            else
            {
                SqlCommand com;
                string query;
                query = "INSERT INTO x VALUES (" + Convert.ToInt32(txtNumero.Text) + ",'" + txtguardar.Text + "','" + txtjugador2.Text + "');";
                try
                {
                    conexion();
                    com = new SqlCommand(query, conn);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Registro Guardado");
                    com.Dispose();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

        private void jugar_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.txtc.Text = txtguardar.Text;
            frm2.txtjugador.Text = txtjugador2.Text;

            frm2.Show();
            this.Hide();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
