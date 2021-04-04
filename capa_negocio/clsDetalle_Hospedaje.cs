using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using capa_datos;
namespace capa_negocio
{
    public class clsDetalle_Hospedaje : clsConexion
    {
        private string id_nota;
        private string id_habitacion;
        private string cant_dias;
        private string descuento;
        private string fecha_salida;
        private string preciov;

        public clsDetalle_Hospedaje()
        {
            id_nota = "";
            id_habitacion = "";
            cant_dias = "";
            descuento = "";
            fecha_salida = "";
            preciov = "";
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

        public string Cant_dias
        {
            get
            {
                return cant_dias;
            }

            set
            {
                cant_dias = value;
            }
        }

        public string Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }

        public string Fecha_salida
        {
            get
            {
                return fecha_salida;
            }

            set
            {
                fecha_salida = value;
            }
        }

        public string Preciov
        {
            get
            {
                return preciov;
            }

            set
            {
                preciov = value;
            }
        }

        public void guardar()
        {
            IniciarSP("Insertar_Detalle_Hospedaje");
            AddParametro("@id_nota", id_nota);
            AddParametro("@id_hab",id_habitacion);
            AddParametro("@cant_dias",cant_dias);
            AddParametro("@descuento",descuento);
            AddParametro("@fecha_salida",fecha_salida);
            AddParametro("@preciov",preciov);
            ejecutarSP();
        }

        public DataSet mostrar_Detalle_Hospedaje()
        {
            string s;
            s = "select *from Detalle_Hospedaje ";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Detalle_Hospedaje()
        {
            IniciarSP("Modificar_Detalle_Hospedaje");
            AddParametro("@id_nota", id_nota);
            AddParametro("@id_hab", id_habitacion);
            AddParametro("@cant_dias", cant_dias);
            AddParametro("@descuento", descuento);
            AddParametro("@fecha_salida", fecha_salida);
            AddParametro("@preciov", preciov);
            ejecutarSP();
        }

        public void Eliminar_Detalle_Hospedaje()
        {
            IniciarSP("Eliminar_Detalle_Hospedaje");
            AddParametro("@id_nota", id_nota);
            AddParametro("@id_hab", id_habitacion);
            ejecutarSP();
        }

    }
}
