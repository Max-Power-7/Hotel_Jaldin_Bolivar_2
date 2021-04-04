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
    public partial class frm_Empleado : Form
    {
        public frm_Empleado()
        {
            InitializeComponent();
        }
        clsEmpleado emp = new clsEmpleado();
        private void frm_Empleado_Load(object sender, EventArgs e)
        {
            dgvEmpleado.DataSource = emp.mostrar_Empleado();
            dgvEmpleado.DataMember = "tac";
            dgvEmpleado.AutoResizeColumns();
            dgvEmpleado.AutoResizeRows();
        }
        private void LimpiarTexto()
        {
            txtId_Emp.Clear();
            txtNombre.Clear();
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtTelefono.Clear();            
            txtSueldo.Clear();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                emp.Ci = txtCi.Text;
                emp.Nombre = txtNombre.Text;
                emp.Paterno = txtPaterno.Text;
                emp.Materno = txtMaterno.Text;
                emp.Telefono = txtTelefono.Text;
                emp.Fecha_ingreso = txtFecha_Ing.Text;
                emp.Sueldo = txtSueldo.Text;
                emp.Id_jefe = txtId_Jefe.Text;
                emp.Id_tipoEmpleado = txtId_Tipo_Emp.Text;
                emp.guardar();
                LimpiarTexto();
                MessageBox.Show("Insertado correctamente", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al insertar" + er.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvEmpleado.DataSource = emp.mostrar_Empleado();
            dgvEmpleado.DataMember = "tac";
            dgvEmpleado.AutoResizeColumns();
            dgvEmpleado.AutoResizeRows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                emp.Id_empleado = txtId_Emp.Text;
                emp.Ci = txtCi.Text;
                emp.Nombre = txtNombre.Text;
                emp.Paterno = txtPaterno.Text;
                emp.Materno = txtMaterno.Text;
                emp.Telefono = txtTelefono.Text;
                emp.Fecha_ingreso = txtFecha_Ing.Text;
                emp.Sueldo = txtSueldo.Text;
                emp.Id_tipoEmpleado = txtId_Tipo_Emp.Text;
                emp.Id_jefe = txtId_Jefe.Text;
                emp.Modificar_Empleado();
                LimpiarTexto();
                MessageBox.Show("Modificado correctamente", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al modificar" + er.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                emp.Id_empleado = txtId_Emp.Text;
                emp.Eliminar_empleado();
                LimpiarTexto();
                MessageBox.Show("Eliminado correctamente", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al eliminar" + er.ToString());
            }
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = emp.buscar(txtId_Emp.Text);
            dgvEmpleado.DataSource = ds;
            dgvEmpleado.DataMember = "tac";
            dgvEmpleado.AutoResizeColumns();
            dgvEmpleado.AutoResizeRows();
        }
    }
}
