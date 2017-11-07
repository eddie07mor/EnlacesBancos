using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace prototipoEnlace
{
    public partial class Form1 : Form
    {
        BDComun cma = new BDComun();
        public Form1()
        {
            InitializeComponent();
        }

        //string var;

        private void label4_Click(object sender, EventArgs e)
        {

        }


        //Prueba de Conexion a BD
        private void button1_Click(object sender, EventArgs e)
        {
            

            /*Conex.Conex con = new Conex.Conex(var);

            try
            {

                con.OpenConnection();
                MessageBox.Show("Conexion exitosa");
            }
            catch
            {
                MessageBox.Show("Error");
            }*/

            //BDComun.ObtenerConexion();
            //MessageBox.Show("Conectado");

        }


        //Mostrar Movimiento de Proveedores
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            cma.llenarCombo(comboBox1);

            /*try
            {

                BDComun.ObtenerConexion();
                comboBox1.Text = "BANCOS";
                comboBox1.Items.Clear();

                BDComun.ObtenerConexion conectar = new BDComun.();
                conectar.open();
                MySqlCommand comando = new MySqlCommand("Select banco from hotelsancarlos",conectar);
                MySqlDataReader almacena = comando.ExecuteReader();

                while(almacena.Read()){
                    comboBox1.Refresh();
                    comboBox1.Items.Add(almacena.GetValue(0).ToString());

                }

              
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }*/
        }
    }
}
