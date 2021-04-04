using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using capa_datos;
namespace capa_negocio
{    
    public class clsReserva : clsConexion
    {
        private string id_reserva;
        private string fecha_reserva;
        private string plazo_dias;
        private string estado;
        private string id_cliente;
        private string id_habitacion;
        private string id_empleado;

        public clsReserva()
        {
            id_reserva = "";
            fecha_reserva = "";
            plazo_dias = "";
            estado = "";
            id_cliente = "";
            id_habitacion = "";
            id_empleado = "";
        }

        public string Id_reserva
        {
            get
            {
                return id_reserva;
            }

            set
            {
                id_reserva = value;
            }
        }

        public string Fecha_reserva
        {
            get
            {
                return fecha_reserva;
            }

            set
            {
                fecha_reserva = value;
            }
        }

        public string Plazo_dias
        {
            get
            {
                return plazo_dias;
            }

            set
            {
                plazo_dias = value;
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
            IniciarSP("Insertar_Reserva");
            AddParametro("@fecha_r",fecha_reserva);
            AddParametro("@plazo_dias",plazo_dias);
            AddParametro("@estado",estado);
            AddParametro("@id_cli",id_cliente);
            AddParametro("@id_hab ",id_habitacion);
            AddParametro("@id_emp",id_empleado);            
            ejecutarSP();
        }

        public DataSet mostrar_Reserva()
        {
            string s;
            s = "select *from Reserva ";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Reserva()
        {
            IniciarSP("Modificar_Reserva");
            AddParametro("@id_reserva",id_reserva);
            AddParametro("@fecha_r", fecha_reserva);
            AddParametro("@plazo_dias", plazo_dias);
            AddParametro("@estado", estado);
            AddParametro("@id_cli", id_cliente);
            AddParametro("@id_hab ", id_habitacion);
            AddParametro("@id_emp", id_empleado);
            ejecutarSP();
        }

        public void Eliminar_Reserva()
        {
            IniciarSP("Eliminar_Reserva");
            AddParametro("@id_reserva",id_reserva);
            ejecutarSP();
        }

        public DataSet buscar(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from Reserva where id_reserva like '" + dato + "%' or estado like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
