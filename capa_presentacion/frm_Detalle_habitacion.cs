using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_negocio;
using capa_datos;

namespace capa_presentacion
{
    public partial class frm_Detalle_habitacion : Form
    {
        public frm_Detalle_habitacion()
        {
            InitializeComponent();
        }
        private void LimpiarTexto()
        {
            txtCamas.Clear();
            txtLimite_Personas.Clear();
        }

        clsDetalle_Habitacion det = new clsDetalle_Habitacion();
        private void frm_Detalle_habitacion_Load(object sender, EventArgs e)
        {
            dgvDetalle_Habitacion.DataSource = det.mostrar_Detalle_habitacion();
            dgvDetalle_Habitacion.DataMember = "tac";
            dgvDetalle_Habitacion.AutoResizeColumns();
            dgvDetalle_Habitacion.AutoResizeRows();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                det.Camas = txtCamas.Text;
                det.Limite_personas = txtLimite_Personas.Text;
                det.Tv_cable = txtTv_Cable.Text;
                det.Dvd = txtDVD.Text;
                det.Aire_acondicionado = txtAire_Acondicionado.Text;
                det.Internet = txtInternet.Text;
                det.Baño_privado = txtBaño_Privado.Text;
                det.guardar();
                LimpiarTexto();
                MessageBox.Show("Guardado con exito!", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al guardar" + er.ToString());
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dgvDetalle_Habitacion.DataSource = det.mostrar_Detalle_habitacion();
            dgvDetalle_Habitacion.DataMember = "tac";
            dgvDetalle_Habitacion.AutoResizeColumns();
            dgvDetalle_Habitacion.AutoResizeRows();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                det.Id_detalle = txtId_Detalle.Text;
                det.Camas = txtCamas.Text;
                det.Limite_personas = txtLimite_Personas.Text;
                det.Tv_cable = txtTv_Cable.Text;
                det.Dvd = txtDVD.Text;
                det.Aire_acondicionado = txtAire_Acondicionado.Text;
                det.Internet = txtInternet.Text;
                det.Baño_privado = txtBaño_Privado.Text;
                det.Modificar_Detalle_Hab();
                LimpiarTexto();
                MessageBox.Show("Modificado con exito!", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al modificar" + er.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                det.Id_detalle = txtId_Detalle.Text;                
                det.Eliminar_Detalle_Hab();
                LimpiarTexto();
                MessageBox.Show("Eliminado con exito!", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al eliminar" + er.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = det.buscar(txtBuscar.Text);
            dgvDetalle_Habitacion.DataSource = ds;
            dgvDetalle_Habitacion.DataMember = "tac";
            dgvDetalle_Habitacion.AutoResizeColumns();
            dgvDetalle_Habitacion.AutoResizeRows();
        }
    }
}
