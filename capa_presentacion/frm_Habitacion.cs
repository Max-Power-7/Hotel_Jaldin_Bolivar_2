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
    public partial class frm_Habitacion : Form
    {
        public frm_Habitacion()
        {
            InitializeComponent();
        }
        
        clsHabitacion hab = new clsHabitacion();
        private void LimpiarTexto()
        {
            txtId_Habitacion.Clear();
            txtNro_Hab.Clear();
            txtNro_Piso.Clear();
            txtId_Tipo_Hab.Clear();
        }
        private void dgvHabitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvHabitacion.DataSource = hab.mostrar_Habitacion();
            dgvHabitacion.DataMember = "tac";
            dgvHabitacion.AutoResizeColumns();
            dgvHabitacion.AutoResizeRows();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                hab.Nro_habitacion = txtNro_Hab.Text;
                hab.Nro_piso = txtNro_Piso.Text;
                hab.Estado = txtEstado.Text;
                hab.Id_tipoHabitacion = txtId_Tipo_Hab.Text;
                if (txtNro_Hab.Text != "" && txtNro_Piso.Text !="" && txtEstado.Text!="" && txtId_Tipo_Hab.Text!="")
                {
                    hab.guardar();
                    LimpiarTexto();
                    MessageBox.Show("Guardado correctamente", "INFORMACION");
                }
                else {
                MessageBox.Show("Complete los campos datos");

                }
            }
            catch(Exception er)
            {
                MessageBox.Show("Error al modificar");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                hab.Id_habitacion = txtId_Habitacion.Text;

                if (txtNro_Hab.Text != "") 
                 { 
                    hab.Nro_habitacion = txtNro_Hab.Text;
                    hab.Nro_piso = txtNro_Piso.Text;
                    hab.Estado = txtEstado.Text;
                    hab.Id_tipoHabitacion = txtId_Tipo_Hab.Text;

                    if (txtNro_Hab.Text != "" && txtNro_Piso.Text != "" && txtEstado.Text != "" && txtId_Tipo_Hab.Text != "")
                    {
                        hab.Modificar_Hab();
                        LimpiarTexto();
                        MessageBox.Show("Modificado correctamente", "INFORMACION");
                    }
                    else {
                        MessageBox.Show("Necesita todos los campos", "INFORMACION");

                    }
                }

                else{
                    MessageBox.Show("Necesita completar los campos");

                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Modificar", "INFORMACION");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                hab.Id_habitacion = txtId_Habitacion.Text;                
                hab.Eliminar_Hab();
                LimpiarTexto();
                MessageBox.Show("Eliminado correctamente", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al eliminar" + er.ToString());
            }
        }

        private void frm_Habitacion_Load(object sender, EventArgs e)
        {
            dgvHabitacion.DataSource = hab.mostrar_Habitacion();
            dgvHabitacion.DataMember = "tac";
            dgvHabitacion.AutoResizeColumns();
            dgvHabitacion.AutoResizeRows();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtId_Habitacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = hab.buscar(txtBuscar.Text);
            dgvHabitacion.DataSource = ds;
            dgvHabitacion.DataMember = "tac";
            dgvHabitacion.AutoResizeColumns();
            dgvHabitacion.AutoResizeRows();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            dgvHabitacion.DataSource = hab.habitacion_Disponibles();
            dgvHabitacion.DataMember = "tac";
            dgvHabitacion.AutoResizeColumns();
            dgvHabitacion.AutoResizeRows();
        }

        private void btnOcupadas_Click(object sender, EventArgs e)
        {
            dgvHabitacion.DataSource = hab.habitacion_Ocupada();
            dgvHabitacion.DataMember = "tac";
            dgvHabitacion.AutoResizeColumns();
            dgvHabitacion.AutoResizeRows();           
        }

        private void btnReservadas_Click(object sender, EventArgs e)
        {
            dgvHabitacion.DataSource = hab.habitacion_Reservada();
            dgvHabitacion.DataMember = "tac";
            dgvHabitacion.AutoResizeColumns();
            dgvHabitacion.AutoResizeRows();
        }
    }
}
