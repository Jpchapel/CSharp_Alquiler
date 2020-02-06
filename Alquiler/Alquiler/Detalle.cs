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
    public partial class Detalle : Form
    {
        BaseDeDatos baseDatos;
        Vehiculo vehiculo;
        Alquiler alquiler = new Alquiler();

        public Detalle(Vehiculo vehiculo, BaseDeDatos baseDatos)
        {
            InitializeComponent();
            this.baseDatos = baseDatos;
            this.vehiculo = vehiculo;
        }

        private void Detalle_Load(object sender, EventArgs e)
        {
            cargarDatosVehiculo();
            comprobarAlquiler();
        }

        private void cargarDatosVehiculo()
        {
            Marca.Text = vehiculo.Marca;
            Modelo.Text = vehiculo.Modelo;
            Color.Text = vehiculo.Color;
            Combustible.Text = vehiculo.Combustible;
        }

        private void comprobarAlquiler()
        {
            if (vehiculo.Alquilado.Equals("S"))
            {
                Alquilar.Enabled = false;
                Devolver.Enabled = true;
            }
            else
            {
                Alquilar.Enabled = true;
                Devolver.Enabled = false;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alquilar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion;
            confirmacion = MessageBox.Show("¿Desea alquilar este vehiculo?", "Alquilar vehiculo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion.Equals(DialogResult.Yes))
            {
                pasarValoresaAlquiler();

                vehiculo.Alquilado = "S";
                vehiculo.colocarMarcaAlquilado(baseDatos);

                MessageBox.Show("Alquiler registrado en la BD", "Alquiler realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }

            this.Close();
        }

        private void pasarValoresaAlquiler()
        {
            alquiler.IdVehiculo = vehiculo.IdVehiculo;
            alquiler.ApellidosNombre = ApellidosNombre.Text;
            alquiler.FechaAlquiler = FechaAlquiler.Value.Date;
            alquiler.NumerDias = Convert.ToInt32(NumeroDias.Text);

            alquiler.Alquilar(baseDatos);
        }

        private void Devolver_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion;
            confirmacion = MessageBox.Show("¿Desea devolver este vehiculo?", "Devolver vehiculo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion.Equals(DialogResult.Yes))
            {
                alquiler.BorrarAlquiler(baseDatos);

                vehiculo.Alquilado = "N";
                vehiculo.colocarMarcaAlquilado(baseDatos);

                MessageBox.Show("Vehiculo devuelto la BD", "Vehiculo devuelto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }

            this.Close();
        }
    }
}
