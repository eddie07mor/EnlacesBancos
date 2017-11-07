using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace prototipoEnlace
{
    public class BDComun
    {
        //public static MySqlConnection ObtenerConexion() {

            MySqlConnection conectar = new MySqlConnection("Server=localhost; database=hotelsancarlos; Uid=root; pwd=;");

            public void llenarCombo(ComboBox combo1)
        {
            MySqlCommand cm = new MySqlCommand("banco",conectar);

            cm.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            combo1.ValueMember = "idBanco";
            combo1.DisplayMember = "nombre";

            combo1.DataSource = dt;


        }

            //conectar.Open();
            //return conectar;
        }
    }

