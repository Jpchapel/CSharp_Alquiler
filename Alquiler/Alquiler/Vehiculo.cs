using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Alquiler
{
    public class Vehiculo
    {
        #region "prop privadas"
            private int idVehiculo;
            private string marca;
            private string modelo;
            private string color;
            private string combustible;
            private string alquilado;
        #endregion

        #region "prop públicas"
        public int IdVehiculo
        {
            get { return this.idVehiculo; }
            set { this.idVehiculo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { this.marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { this.modelo = value; }
        }
        public string Color
        {
            get { return color; }
            set { this.color = value; }
        }
        public string Combustible
        {
            get { return combustible; }
            set { this.combustible = value; }
        }
        public string Alquilado
        {
            get { return alquilado; }
            set { this.alquilado = value; }
        }
        #endregion

        public DataSet leerVehiculos(BaseDeDatos baseDatos)
        {
            string cadenaSQL = "Select * from Vehiculos";
            return baseDatos.operacionesSelect(cadenaSQL);
        }

        public void colocarMarcaAlquilado(BaseDeDatos baseDatos)
        {
            string cadenaSQL = string.Format("Update vehiculos set Alugado='{0}' where IdVehiculo={1}", this.Alquilado, this.IdVehiculo);
            baseDatos.operacionesNoSelect(cadenaSQL);
        }

        public void EstablecerValores(DataSet dataSet, int Indice)
        {
            this.IdVehiculo = Convert.ToInt32(dataSet.Tables[0].Rows[Indice][0]);
            this.Marca = Convert.ToString(dataSet.Tables[0].Rows[Indice][1]);
            this.Modelo = Convert.ToString(dataSet.Tables[0].Rows[Indice][2]);
            this.Color = Convert.ToString(dataSet.Tables[0].Rows[Indice][3]);
            this.Combustible = Convert.ToString(dataSet.Tables[0].Rows[Indice][4]);
            this.Alquilado = Convert.ToString(dataSet.Tables[0].Rows[Indice][5]);
        }
    }
}
