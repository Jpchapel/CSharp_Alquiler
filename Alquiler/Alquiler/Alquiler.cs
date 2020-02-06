using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Alquiler
{
    class Alquiler
    {
        #region "prop privadas"
            private int idAlquiler;
            private int idVehiculo;
            private string apellidosNombre;
            private DateTime fechaAlquiler;
            private int numeroDias;
        #endregion

        #region "prop públicas"
        public int IdAlquiler
        {
            get { return this.idAlquiler; }
            set { this.idAlquiler = value; }
        }

        public int IdVehiculo
        {
            get { return this.idVehiculo; }
            set { this.idVehiculo = value; }
        }
        public string ApellidosNombre
        {
            get { return apellidosNombre; }
            set { this.apellidosNombre = value; }
        }
        public DateTime FechaAlquiler
        {
            get { return fechaAlquiler; }
            set { this.fechaAlquiler = value; }
        }
        public int NumerDias
        {
            get { return this.numeroDias; }
            set { this.numeroDias = value; }
        }
        #endregion


        public DataSet LeerAlquiler(BaseDeDatos baseDatos)
        {
            string cadenaSQL = string.Format("select * from aluguer where idVehiculo={0}", this.IdVehiculo);
            return baseDatos.operacionesSelect(cadenaSQL);
        }
        public void Alquilar(BaseDeDatos baseDatos)
        {
            string cadenaSQL = String.Format(@"insert into Aluguer(IdVehiculo,Apenom,DataAluguer,NDias) values 
                                             ({0},'{1}','{2}',{3})", this.IdVehiculo, this.ApellidosNombre, this.FechaAlquiler, this.NumerDias);
            baseDatos.operacionesNoSelect(cadenaSQL);
        }
        public void BorrarAlquiler(BaseDeDatos baseDatos)
        {
            string cadenaSQL = String.Format("delete from aluguer where IdAluguer={0}", this.IdAlquiler);
            baseDatos.operacionesNoSelect(cadenaSQL);
        }

        public void EstablecerValores(DataSet dataSet, int Indice)
        {
            this.IdAlquiler = Convert.ToInt32(dataSet.Tables[0].Rows[Indice][0]);
            this.IdVehiculo = Convert.ToInt32(dataSet.Tables[0].Rows[Indice][1]);
            this.ApellidosNombre = Convert.ToString(dataSet.Tables[0].Rows[Indice][2]);
            this.FechaAlquiler = Convert.ToDateTime(dataSet.Tables[0].Rows[Indice][3]);
            this.NumerDias = Convert.ToInt32(dataSet.Tables[0].Rows[Indice][4]);
        }
    }
}
