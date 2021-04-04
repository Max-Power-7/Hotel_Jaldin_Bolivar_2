using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_datos;
using capa_negocio;

namespace capa_presentacion
{
    public partial class frm_Tipo_Empleado : Form
    {
        public frm_Tipo_Empleado()
        {
            InitializeComponent();
        }
        clsTipo_Empleado tip = new clsTipo_Empleado();
        private void LimpiarTexto()
        {
            txtId_tipo_emp.Clear();
            txtTipo.Clear();
        }
        private void frm_Tipo_Empleado_Load(object sender, EventArgs e)
        {
            dvgTipo_emp.DataSource = tip.mostrar_Tipo_Empleado();
            dvgTipo_emp.DataMember = "tac";
            dvgTipo_emp.AutoResizeColumns();
            dvgTipo_emp.AutoResizeRows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dvgTipo_emp.DataSource = tip.mostrar_Tipo_Empleado();
            dvgTipo_emp.DataMember = "tac";
            dvgTipo_emp.AutoResizeColumns();
            dvgTipo_emp.AutoResizeRows();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                tip.Cargo = txtTipo.Text;
                tip.guardar();
                LimpiarTexto();
                MessageBox.Show("Guardado con exito!", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al guardar" + er.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                tip.Id_tipoEmpleado = txtId_tipo_emp.Text;
                tip.Eliminar_Tipo_Empleado();
                LimpiarTexto();
                MessageBox.Show("Eliminado con exito!", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al eliminar" + er.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {                
                tip.Id_tipoEmpleado = txtId_tipo_emp.Text;
                tip.Cargo = txtTipo.Text;
                tip.Modificar_Tipo_Empleado();
                LimpiarTexto();
                MessageBox.Show("Modificado con exito!", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al modificar" + er.ToString());
            }
        }
    }
}
