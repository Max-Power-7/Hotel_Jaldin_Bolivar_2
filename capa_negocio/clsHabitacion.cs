using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using capa_datos;
namespace capa_negocio
{   
    public class clsHabitacion : clsConexion
    {
        private string id_habitacion;
        private string nro_habitacion;
        private string nro_piso;
        private string estado;
        private string id_tipoHabitacion;

        public clsHabitacion()
        {
            id_habitacion = "";
            nro_habitacion = "";
            nro_piso = "";
            estado = "";
            id_tipoHabitacion = "";
        }

        public string Id_habitacion
        {
            get
            {
                return id_habitacion;
            }

            set
            {
                id_habitacion = value;
            }
        }

        public string Nro_habitacion
        {
            get
            {
                return nro_habitacion;
            }

            set
            {
                nro_habitacion = value;
            }
        }

        public string Nro_piso
        {
            get
            {
                return nro_piso;
            }

            set
            {
                nro_piso = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
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

        public void guardar()
        {
            IniciarSP("Insertar_Hab");
            AddParametro("@nro_hab",nro_habitacion);
            AddParametro("@nro_piso",nro_piso);
            AddParametro("@estado",estado);
            AddParametro("@id_tipo",id_tipoHabitacion);
            ejecutarSP();
        }

        public DataSet mostrar_Habitacion()
        {
            string s;
            s = "select *from Habitacion";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
        // Habitaciones Disponibles
        public DataSet habitacion_Disponibles() {
            string s;
            s = "select nro_piso as piso,nro_habitacion as numero , precio ,estado ,tipo from Habitacion h,Tipo_Habitacion t where h.id_tipoHabitacion=t.id_tipoHabitacion and h.estado='libre' ";
            DataSet ds = new DataSet();
            ejecutarSQL(s,"tac",ds);
            return ds;
        }
        // Habitaciones Ocupadas
        public DataSet habitacion_Ocupada()
        {
            string s;
            s = "select nro_piso as piso,nro_habitacion as numero , precio ,estado , tipo from Habitacion h,Tipo_Habitacion t where h.id_tipoHabitacion=t.id_tipoHabitacion and h.estado='ocupada' ";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        //Habitaciones Reservadas 
        public DataSet habitacion_Reservada()
        {
            string s;
            s = "select nro_piso as piso,nro_habitacion as numero , precio ,estado , tipo from Habitacion h,Tipo_Habitacion t where h.id_tipoHabitacion=t.id_tipoHabitacion and h.estado='reservada' ";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }



        public void Modificar_Hab()
        {
            IniciarSP("Modificar_Hab");
            AddParametro("@id_hab", id_habitacion);
            AddParametro("@nro_hab", nro_habitacion);
            AddParametro("@nro_piso", nro_piso);
            AddParametro("@estado", estado);
            AddParametro("@id_tipo", id_tipoHabitacion);
            ejecutarSP();
        }

        public void Eliminar_Hab()
        {
            IniciarSP("Eliminar_Hab");
            AddParametro("@id_hab", id_habitacion);
            ejecutarSP();
        }

        public DataSet buscar(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from habitacion where id_tipoHabitacion like '" + dato + "%' or estado like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
