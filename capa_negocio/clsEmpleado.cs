using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using capa_datos;
namespace capa_negocio
{
    public class clsEmpleado : clsConexion
    {
        private string id_empleado;
        private string ci;
        private string nombre;
        private string paterno;
        private string materno;       
        private string telefono;
        private string fecha_ingreso;
        private string sueldo;
        private string id_tipoEmpleado;
        private string id_jefe;

        public clsEmpleado()
        {
            id_empleado = "";
            ci = "";
            nombre = "";
            paterno = "";
            materno = "";
            telefono = "";
            fecha_ingreso = "";
            sueldo = "";
            id_tipoEmpleado = "";
            id_jefe = "";
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

        public string Ci
        {
            get
            {
                return ci;
            }

            set
            {
                ci = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Paterno
        {
            get
            {
                return paterno;
            }

            set
            {
                paterno = value;
            }
        }

        public string Materno
        {
            get
            {
                return materno;
            }

            set
            {
                materno = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Fecha_ingreso
        {
            get
            {
                return fecha_ingreso;
            }

            set
            {
                fecha_ingreso = value;
            }
        }

        public string Sueldo
        {
            get
            {
                return sueldo;
            }

            set
            {
                sueldo = value;
            }
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

        public string Id_jefe
        {
            get
            {
                return id_jefe;
            }

            set
            {
                id_jefe = value;
            }
        }

        public void guardar()
        {
            IniciarSP("insertar_empleado");
            AddParametro("@ci_emp",ci);
            AddParametro("@nombre_emp",nombre);
            AddParametro("@paterno_emp",paterno);
            AddParametro("@materno_emp",materno);
            AddParametro("@telefono_emp",telefono);
            AddParametro("@fecha_ingreso",fecha_ingreso);
            AddParametro("@sueldo",sueldo);
            AddParametro("@id_tipo",id_tipoEmpleado);
            AddParametro("@id_jefe",id_jefe);
            ejecutarSP();
        }

        public DataSet mostrar_Empleado()
        {
            string s;
            s = "select *from Empleado";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Empleado()
        {
            IniciarSP("Modificar_Empleado");
            AddParametro("@id_empleado",id_empleado);
            AddParametro("@ci1", ci);
            AddParametro("@nombre1", nombre);
            AddParametro("@paterno1", paterno);
            AddParametro("@materno1", materno);
            AddParametro("@telefono1", telefono);
            AddParametro("@fecha_ingreso", fecha_ingreso);
            AddParametro("@sueldo", sueldo);
            AddParametro("@id_tipo_empl", id_tipoEmpleado);
            AddParametro("@id_jef", id_jefe);
            ejecutarSP();
        }

        public void Eliminar_empleado()
        {
            IniciarSP("Eliminar_empleado");
            AddParametro("@id_emp",id_empleado);
            ejecutarSP();
        }
        public DataSet buscar(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from empleado where id_empleado like '" + dato + "%' or nombre like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
