using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using capa_datos;
namespace capa_negocio
{    
    public class clsTipo_Empleado : clsConexion
    {
        private string id_tipoEmpleado;
        private string cargo;

        public clsTipo_Empleado()
        {
            id_tipoEmpleado = "";
            cargo = "";
        }

        public string Id_tipoEmpleado
        {
            get
            {
                return id_tipoEmpleado;
            }

            set
            {
                id_tipoEmpleado = value;
            }
        }

        public string Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public void guardar()
        {
            IniciarSP("inser_tipoEmpleado");
            AddParametro("@cargo", cargo);
            ejecutarSP();
        }

        public DataSet mostrar_Tipo_Empleado()
        {
            string s;
            s = "select *from Tipo_Empleado";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Tipo_Empleado()
        {
            IniciarSP("Modificar_Tipo_Empleado");
            AddParametro("@id_tipo_empleado",id_tipoEmpleado);
            AddParametro("@cargo",cargo);
            ejecutarSP();
        }

        public void Eliminar_Tipo_Empleado()
        {
            IniciarSP("Eliminar_Tipo_Empleado");
            AddParametro("@id_tipo_empleado",id_tipoEmpleado);
            ejecutarSP();
        }
    }
}
