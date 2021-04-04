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
    public partial class frm_Reserva : Form
    {
        public frm_Reserva()
        {
            InitializeComponent();
        }

        private void LimpiarTexto()
        {
            txtId_res.Clear();           
            txtId_cliente.Clear();            
        }

        clsReserva res = new clsReserva();
        private void frm_Reserva_Load(object sender, EventArgs e)
        {
            dgvReserva.DataSource = res.mostrar_Reserva();
            dgvReserva.DataMember = "tac";
            dgvReserva.AutoResizeColumns();
            dgvReserva.AutoResizeRows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvReserva.DataSource = res.mostrar_Reserva();
            dgvReserva.DataMember = "tac";
            dgvReserva.AutoResizeColumns();
            dgvReserva.AutoResizeRows();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                res.Fecha_reserva = txtFechaRes.Text;
                res.Plazo_dias = txtPlazo.Text;
                res.Estado = txtEstado.Text;
                res.Id_cliente = txtId_cliente.Text;
                res.Id_habitacion = txtId_hab.Text;
                res.Id_empleado = txtId_emp.Text;
                res.guardar(); 
                LimpiarTexto();
                MessageBox.Show("Guardado con exito!", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al guardar" + er.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                res.Id_reserva = txtId_res.Text;
                res.Fecha_reserva = txtFechaRes.Text;
                res.Plazo_dias = txtPlazo.Text;
                res.Estado = txtEstado.Text;
                res.Id_cliente = txtId_cliente.Text;
                res.Id_habitacion = txtId_hab.Text;
                res.Id_empleado = txtId_emp.Text;
                res.Modificar_Reserva();
                LimpiarTexto();
                MessageBox.Show("Modificado con exito!", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al modificar" + er.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                res.Id_reserva = txtId_res.Text;
                res.Eliminar_Reserva();
                LimpiarTexto();
                MessageBox.Show("Eliminado con exito!", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al eliminar" + er.ToString());
            }
        }

        private void txtEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = res.buscar(txtBuscar.Text);
            dgvReserva.DataSource = ds;
            dgvReserva.DataMember = "tac";
            dgvReserva.AutoResizeColumns();
            dgvReserva.AutoResizeRows();
        }
    }
}
