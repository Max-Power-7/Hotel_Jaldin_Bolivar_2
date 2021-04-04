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
    public partial class frm_Tipo_Habitacion : Form
    {
        public frm_Tipo_Habitacion()
        {
            InitializeComponent();
        }
        clsTipo_Habitacion Tip = new clsTipo_Habitacion();
        private void LimpiarTexto()
        {
            txtId_detalle.Clear();
            txtId_tipo_hab.Clear();
            txtPrecio.Clear();
            txtTipo.Clear();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Tip.Tipo = txtTipo.Text;
                Tip.Precio = txtPrecio.Text;
                Tip.Id_detalle = txtId_detalle.Text;                
                Tip.guardar();
                LimpiarTexto();
                MessageBox.Show("Guardado con éxito!", "INFORMACION");
            }
            catch(Exception er)
            {
                MessageBox.Show("Error al guardar"+er.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Tipo_Habitacion_Load(object sender, EventArgs e)
        {
            dgvTipo_Habitacion.DataSource = Tip.mostrar_Tipo_Habitacion();
            dgvTipo_Habitacion.DataMember = "tac";
            dgvTipo_Habitacion.AutoResizeColumns();
            dgvTipo_Habitacion.AutoResizeRows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvTipo_Habitacion.DataSource = Tip.mostrar_Tipo_Habitacion();
            dgvTipo_Habitacion.DataMember = "tac";
            dgvTipo_Habitacion.AutoResizeColumns();
            dgvTipo_Habitacion.AutoResizeRows();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tip.Id_tipoHabitacion = txtId_tipo_hab.Text;
                Tip.Tipo = txtTipo.Text;
                Tip.Precio = txtPrecio.Text;
                Tip.Id_detalle = txtId_detalle.Text;                
                Tip.Modificar_TipoHab();
                LimpiarTexto();
                MessageBox.Show("Modificado con éxito!", "INFORMACION");
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
                Tip.Id_tipoHabitacion = txtId_tipo_hab.Text;                
                Tip.Eliminar_TipoHab();
                LimpiarTexto();
                MessageBox.Show("Eliminado con éxito!", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al eliminar" + er.ToString());
            }
        }
    }
}
