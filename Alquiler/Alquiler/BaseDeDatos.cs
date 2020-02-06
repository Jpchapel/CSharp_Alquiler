using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Alquiler
{
    public class BaseDeDatos
    {
        OleDbConnection conexion;

        public BaseDeDatos(string nombreBD)
        {
            string cadenaConexion = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='{0}'", nombreBD);
            conexion = new OleDbConnection(cadenaConexion);
        }

        public void abrirBD()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                    MessageBox.Show("Bd Abierta");
                }
            }
            catch (OleDbException errorBD)
            {
                MessageBox.Show(errorBD.Message, "Error intentando abrir B.D.");
            }
        }

        public void cerrarBD()
        {
            try
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    MessageBox.Show("BD Cerrada");
                }
            }
            catch (OleDbException errorBD)
            {
                MessageBox.Show(errorBD.Message, "Error intentando cerrar B.D.");
            }
        }

        public void operacionesNoSelect(string cadenaSQL)
        {
            try
            {
                OleDbCommand comando = new OleDbCommand(cadenaSQL, conexion);
                comando.ExecuteNonQuery();
            }
            catch (OleDbException errorBD)
            {
                MessageBox.Show(errorBD.Message, "Error intentando operacion nonSelect B.D.");
            }
        }

        public DataSet operacionesSelect(string cadenaSQL)
        {
            DataSet dataSet = new DataSet();

            try
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cadenaSQL, conexion);
                dataAdapter.Fill(dataSet);
            }
            catch (OleDbException errorBD)
            {
                MessageBox.Show(errorBD.Message, "Error intentando operacion Select B.D.");
            }

            return dataSet;
        }
        public int operacionesScalar(string cadenaSQL)
        {
            int resultado = 0;
            try
            {
                OleDbCommand comando = new OleDbCommand(cadenaSQL, conexion);
                resultado = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch (OleDbException errorBD)
            {
                MessageBox.Show(errorBD.Message, "Error intentando operacion scalar B.D.");
            }
            return resultado;
        }
    }
}
