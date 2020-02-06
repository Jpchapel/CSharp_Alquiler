using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler
{
    public partial class Form1 : Form
    {
        BaseDeDatos baseDatos = new BaseDeDatos("..\\..\\..\\AluguerVehiculos.mdb");
        Vehiculo vehiculo = new Vehiculo();

        DataSet dataSet;
        int idVehiculoDia = 0;

        public Form1()
        {
            InitializeComponent();
            baseDatos.abrirBD();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatagrid();
            cargarVehiculoDelDia();
        }

        private void cargarDatagrid()
        {
            dataSet = vehiculo.leerVehiculos(baseDatos);

            Vehiculos.DataSource = dataSet.Tables[0];
        }
        private void cargarVehiculoDelDia()
        {
            if (hayCochesParaAlquilar())
            {
                mostarVehiculoDelDia();
            }
            else
            {
                VehiculoDia.Text = "No hay vehiculos para alquilar";
            }
        }

        private bool hayCochesParaAlquilar()
        {
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToString(dataSet.Tables[0].Rows[i][5]) == "N")
                {
                    return true;
                }
            }
            return false;

        }
        private void mostarVehiculoDelDia()
        {
            Random random = new Random();
            int numeroRandom = random.Next(dataSet.Tables[0].Rows.Count);
            Boolean encontrado = false;
            do
            {
                if (Convert.ToString(dataSet.Tables[0].Rows[numeroRandom][5]).Equals("N"))
                {
                    encontrado = true;

                    string marcaCoche = Convert.ToString(dataSet.Tables[0].Rows[numeroRandom][1]);
                    string modeloCoche = Convert.ToString(dataSet.Tables[0].Rows[numeroRandom][2]);
                    string combustibleCoche = Convert.ToString(dataSet.Tables[0].Rows[numeroRandom][4]);

                    VehiculoDia.Text = marcaCoche + " " + modeloCoche + " " + combustibleCoche;

                    idVehiculoDia = Convert.ToInt32(dataSet.Tables[0].Rows[numeroRandom][0]);
                }
                else
                {
                    numeroRandom = random.Next(dataSet.Tables[0].Rows.Count);
                }
            } while (!encontrado);
        }


        private void Vehiculos_Click(object sender, EventArgs e)
        {
            vehiculo.EstablecerValores(dataSet, Vehiculos.CurrentRow.Index);
            Detalle fDetalle = new Detalle(vehiculo, baseDatos);
            fDetalle.ShowDialog();

            cargarDatagrid();
            cargarVehiculoDelDia();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            baseDatos.cerrarBD();
            this.Close();
        }

    }
}
