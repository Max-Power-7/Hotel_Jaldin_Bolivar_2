using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using capa_datos;
namespace capa_negocio
{
    public class clsDetalle_Habitacion : clsConexion
    {
        private string id_detalle;
        private string camas;
        private string limite_personas;
        private string tv_cable;
        private string dvd;
        private string aire_acondicionado;
        private string internet;
        private string baño_privado;

        public clsDetalle_Habitacion()
        {
            id_detalle = "";
            camas = "";
            limite_personas = "";
            tv_cable = "";
            dvd = "";
            aire_acondicionado = "";
            internet = "";
            baño_privado = "";
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

        public string Camas
        {
            get
            {
                return camas;
            }

            set
            {
                camas = value;
            }
        }

        public string Limite_personas
        {
            get
            {
                return limite_personas;
            }

            set
            {
                limite_personas = value;
            }
        }

        public string Tv_cable
        {
            get
            {
                return tv_cable;
            }

            set
            {
                tv_cable = value;
            }
        }

        public string Dvd
        {
            get
            {
                return dvd;
            }

            set
            {
                dvd = value;
            }
        }

        public string Aire_acondicionado
        {
            get
            {
                return aire_acondicionado;
            }

            set
            {
                aire_acondicionado = value;
            }
        }

        public string Internet
        {
            get
            {
                return internet;
            }

            set
            {
                internet = value;
            }
        }

        public string Baño_privado
        {
            get
            {
                return baño_privado;
            }

            set
            {
                baño_privado = value;
            }
        }
        public void guardar()
        {
            IniciarSP("Insertar_Detalle_Hab");
            AddParametro("@camas",camas);
            AddParametro("@limite_personas",limite_personas);
            AddParametro("@tv_cable",tv_cable);
            AddParametro("@dvd",dvd);
            AddParametro("@aire_acondicionado",aire_acondicionado);
            AddParametro("@internet",internet);
            AddParametro("@baño_privado",baño_privado);
            ejecutarSP();
        }

        public DataSet mostrar_Detalle_habitacion()
        {
            string s;
            s = "select *from Detalle_habitacion";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Detalle_Hab()
        {
            IniciarSP("Modificar_Detalle_Hab");
            AddParametro("@id_detalle",id_detalle);
            AddParametro("@camas",camas);
            AddParametro("@limite_personas",limite_personas);
            AddParametro("@tv_cable",tv_cable);
            AddParametro("@dvd", dvd);
            AddParametro("@aire_acondicionado", aire_acondicionado);
            AddParametro("@internet", internet);
            AddParametro("@baño_privado", baño_privado);            
            ejecutarSP();
        }

        public void Eliminar_Detalle_Hab()
        {
            IniciarSP("Eliminar_Detalle_Hab");
            AddParametro("@id_detallehab",id_detalle);
            ejecutarSP();
        }

        public DataSet buscar(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from Detalle_habitacion where id_detalle like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
