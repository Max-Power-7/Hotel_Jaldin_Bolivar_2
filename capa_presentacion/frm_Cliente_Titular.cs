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
    public partial class frm_Cliente_Titular : Form
    {
        public frm_Cliente_Titular()
        {
            InitializeComponent();
        }
        clsCliente_Titular cli = new clsCliente_Titular();
        private void LimpiarTexto() 
        {
            txtId_cliente.Clear();
            txtCi.Clear();
            txtNombre.Clear();
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtLugar_nac.Clear();
            txtTelefono.Clear();
            txtId_huesped.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvClienteTitular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Cliente_Titular_Load(object sender, EventArgs e)
        {
            dgvClienteTitular.DataSource = cli.mostrar_cliente();
            dgvClienteTitular.DataMember = "tac";
            dgvClienteTitular.AutoResizeColumns();
            dgvClienteTitular.AutoResizeRows();
        }
        
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                cli.Ci = txtCi.Text;
                cli.Nombre = txtNombre.Text;
                cli.Paterno = txtPaterno.Text;
                cli.Materno = txtMaterno.Text;
                cli.Lugar_nacimiento = txtLugar_nac.Text;
                cli.Telefono = txtTelefono.Text;
                cli.Fecha_nac = dtpFecha_Nac.Text;
                cli.Extranjero = txtExtranjero.Text;
                cli.Id_huesped = txtId_huesped.Text;
                cli.guardar();
                MessageBox.Show("Datos Guardados");


            }
            catch (Exception er)
            {
                MessageBox.Show("Complete los datos :) ");
            }
        }



       /* private void txtFecha_nac_TextChanged(object sender, EventArgs e)
        {

        }*/

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            dgvClienteTitular.DataSource = cli.mostrar_cliente();
            dgvClienteTitular.DataMember = "tac";
            dgvClienteTitular.AutoResizeColumns();
            dgvClienteTitular.AutoResizeRows();
        }

        private void btnClExtrajero_Click(object sender, EventArgs e)
        {
            dgvClienteTitular.DataSource = cli.mostrar_clientes_extrajeros();
            dgvClienteTitular.DataMember = "tac";
            dgvClienteTitular.AutoResizeColumns();
            dgvClienteTitular.AutoResizeRows();
        }

        private void btnClNacional_Click(object sender, EventArgs e)
        {
            dgvClienteTitular.DataSource = cli.mostrar_clientes_nacionales();
            dgvClienteTitular.DataMember = "tac";
            dgvClienteTitular.AutoResizeColumns();
            dgvClienteTitular.AutoResizeRows();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cli.Id_cliente = txtId_cliente.Text;
                if (txtId_cliente.Text != "")
                {
                    cli.eliminar_cliente();
                    MessageBox.Show("Eliminado con existo :) ");

                }
                else
                {
                    MessageBox.Show("Introdusca el ID Cliente :) ");
                }
            }
            catch (Exception er)
            {

                MessageBox.Show("No es posible eliminar ");

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                cli.Id_cliente = txtId_cliente.Text;
                cli.Ci = txtCi.Text;
                cli.Nombre = txtNombre.Text;
                cli.Paterno = txtPaterno.Text;
                cli.Materno = txtMaterno.Text;
                cli.Lugar_nacimiento = txtLugar_nac.Text;
                cli.Telefono = txtTelefono.Text;
                cli.Fecha_nac = dtpFecha_Nac.Text;
                cli.Extranjero = txtExtranjero.Text;
                cli.Id_huesped = txtId_huesped.Text;

                if (cli.Id_cliente != "")
                {
                    if (txtId_cliente.Text != "" && txtCi.Text != "" && txtNombre.Text != "" && txtPaterno.Text != ""
                        && txtMaterno.Text != "" && txtLugar_nac.Text != "" && txtTelefono.Text != ""
                        && txtExtranjero.Text != "" && txtId_huesped.Text != "")
                    {
                        cli.modificar_cliente();
                        MessageBox.Show("Modificado con exito!", "INFORMACION");
                    }
                    else
                    {
                        MessageBox.Show("Necesita todos los campos para modificar");

                    }
                }
                else
                {
                    MessageBox.Show("Necesita el ID CLIENTE...");

                }


            }
            catch (Exception er)
            {
                MessageBox.Show("Error al modificar" + er.ToString());
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
                ds = cli.buscar(txtBuscar.Text);            
                dgvClienteTitular.DataSource = ds;
                dgvClienteTitular.DataMember = "tac";
                dgvClienteTitular.AutoResizeColumns();
                dgvClienteTitular.AutoResizeRows();
            

        }

        private void txtMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExtranjero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
