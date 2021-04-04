using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using capa_datos;
namespace capa_negocio
{   
    public class clsTipo_Habitacion : clsConexion
    {
        private string id_tipoHabitacion;
        private string tipo;
        private string precio;
        private string id_detalle;

        public clsTipo_Habitacion()
        {
            id_tipoHabitacion = "";
            tipo = "";
            precio = "";
            id_detalle = "";
        }

        public string Id_tipoHabitacion
        {
            get
            {
                return id_tipoHabitacion;
            }

            set
            {
                id_tipoHabitacion = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public string Id_detalle
        {
            get
            {
                return id_detalle;
            }

            set
            {
                id_detalle = value;
            }
        }

        public void guardar()
        {
            IniciarSP("Insertar_TipoHab");
            AddParametro("@tipo",tipo);
            AddParametro("@precio",precio);
            AddParametro("@id_detalle",id_detalle);
            ejecutarSP();
        }

        public DataSet mostrar_Tipo_Habitacion()
        {
            string s;
            s = "select *from Tipo_Habitacion ";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_TipoHab()
        {
            IniciarSP("Modificar_TipoHab");
            AddParametro("@id_tipo",id_tipoHabitacion);
            AddParametro("@tipo",tipo);
            AddParametro("@precio", precio);
            AddParametro("@id_detalle", id_detalle);
            ejecutarSP();
        }

        public void Eliminar_TipoHab()
        {
            IniciarSP("Eliminar_TipoHab");
            AddParametro("@id_tipo",id_tipoHabitacion);
            ejecutarSP();
        }
    }
}
