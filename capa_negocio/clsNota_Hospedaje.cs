using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using capa_datos;
namespace capa_negocio
{
    public class clsNota_Hospedaje : clsConexion
    {
        private string id_nota;
        private string fecha;
        private string monto;
        private string id_cliente;
        private string id_empleado;

        public clsNota_Hospedaje()
        {
            id_nota = "";
            fecha = "";
            monto = "";
            id_cliente = "";
            id_empleado = "";
        }

        public string Id_nota
        {
            get
            {
                return id_nota;
            }

            set
            {
                id_nota = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Monto
        {
            get
            {
                return monto;
            }

            set
            {
                monto = value;
            }
        }

        public string Id_cliente
        {
            get
            {
                return id_cliente;
            }

            set
            {
                id_cliente = value;
            }
        }

        public string Id_empleado
        {
            get
            {
                return id_empleado;
            }

            set
            {
                id_empleado = value;
            }
        }
        public void guardar()
        {
            IniciarSP("Insertar_Nota");
            AddParametro("@fecha_N", fecha);
            AddParametro("@monto_N", monto);
            AddParametro("@id_cli", id_cliente);
            AddParametro("@id_emp", id_empleado);
            ejecutarSP();
        }

        public DataSet mostrar_Nota_Hospedaje()
        {
            string s;
            s = "select *from Nota_Hospedaje";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Nota()
        {
            IniciarSP("Modificar_Nota");
            AddParametro("@id_nota", id_nota);
            AddParametro("@fecha_N", fecha);
            AddParametro("@monto_N", monto);
            AddParametro("@id_cli", id_cliente);
            AddParametro("@id_emp", id_empleado);
            ejecutarSP();
        }

        public void Eliminar_Nota()
        {
            IniciarSP("Eliminar_Nota");
            AddParametro("@id_nota", id_nota);
            ejecutarSP();

        }
    }
   }
