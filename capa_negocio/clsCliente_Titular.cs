using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using capa_datos;

namespace capa_negocio
{
    public class clsCliente_Titular : clsConexion
    {
        private string id_cliente;
        private string ci;
        private string nombre;        
        private string paterno;
        private string materno;
        private string lugar_nacimiento;
        private string telefono;
        private string fecha_nac;
        private string extranjero;
        private string id_huesped;

        public clsCliente_Titular()
        {
            id_cliente = "";
            ci = "";
            nombre = "";
            paterno = "";
            materno = "";
            lugar_nacimiento = "";
            telefono = "";
            fecha_nac = "";
            extranjero = "";
            id_huesped = "";
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

        public string Lugar_nacimiento
        {
            get
            {
                return lugar_nacimiento;
            }

            set
            {
                lugar_nacimiento = value;
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

        public string Fecha_nac
        {
            get
            {
                return fecha_nac;
            }

            set
            {
                fecha_nac = value;
            }
        }

        public string Extranjero
        {
            get
            {
                return extranjero;
            }

            set
            {
                extranjero = value;
            }
        }

        public string Id_huesped
        {
            get
            {
                return id_huesped;
            }

            set
            {
                id_huesped = value;
            }
        }
        public void guardar()
        {
            IniciarSP("insertar_cliente");
            AddParametro("@ci", ci);
            AddParametro("@nombre", nombre);
            AddParametro("@paterno", paterno);

            AddParametro("@materno", materno);
            AddParametro("@lugar_nacimiento", lugar_nacimiento);
            AddParametro("@telefono", telefono);

            AddParametro("@fecha_nac", fecha_nac);
            AddParametro("@extranjero", extranjero);
            AddParametro("@id_huesped", id_huesped);
            ejecutarSP();
        }

        //Mostrar Lista de Clientes
        public DataSet mostrar_cliente()
        {
            string s;
            s = "select * from Cliente_Titular";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
        //Muestra la Lista de Clientes Extranjeros
        public DataSet mostrar_clientes_extrajeros()
        {
            string a;
            a = "select ci ,nombre,paterno,materno,telefono,lugar_nacimiento,DATEDIFF(YEAR,fecha_nac,GETDATE()) as año from Cliente_Titular where extranjero='SI'";
            DataSet ds = new DataSet();
            ejecutarSQL(a, "tac", ds);
            return ds;
        }
        //Muestra la Lista de Clientes Nacionales
        public DataSet mostrar_clientes_nacionales()
        {
            string b;
            b = "select ci ,nombre,paterno,materno,telefono,lugar_nacimiento, DATEDIFF(YEAR,fecha_nac,GETDATE()) as año from Cliente_Titular where extranjero='NO'";
            DataSet ds = new DataSet();
            ejecutarSQL(b, "tac", ds);
            return ds;
        }


        public void modificar_cliente()
        {
            IniciarSP("modificar_cliente");
            AddParametro("@id_cliente1", id_cliente);
            AddParametro("@ci1",ci);
            AddParametro("@nombre1", nombre);
            AddParametro("@paterno1", paterno);
            AddParametro("@materno1", materno);
            AddParametro("@lugar_nacimiento1", lugar_nacimiento);
            AddParametro("@telefono1", telefono);
            AddParametro("@fecha_nac1", fecha_nac);
            AddParametro("@extranjero1", extranjero);
            AddParametro("@id_huesped1", id_huesped);
            ejecutarSP(); 
        }

        public void eliminar_cliente()
        {
            IniciarSP("eliminar_cliente");
            AddParametro("@id_cliente2", id_cliente);
            ejecutarSP();
        }


        public DataSet buscar(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from cliente_titular where id_cliente like '" + dato + "%' or nombre like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
        
    }
}
