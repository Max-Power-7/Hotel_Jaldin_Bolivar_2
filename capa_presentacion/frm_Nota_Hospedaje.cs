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
    public partial class frm_Nota_Hospedaje : Form
    {
        public frm_Nota_Hospedaje()
        {
            InitializeComponent();
        }

        //formularios usados o invocados
        frm_Cliente_Titular frm_Cliente;
        frm_Habitacion frm_hab;
        frm_Empleado frm_emp;

        //clases necesarias
        clsNota_Hospedaje nota = new clsNota_Hospedaje();
        clsDetalle_Hospedaje det = new clsDetalle_Hospedaje();

        private void LimpiarTexto()
        {
            txtId_nota.Clear();
            //txtId_hab.Clear();
            txtCantidadDias.Clear();
            txtDescuento.Clear();
        }

        private void frm_Nota_Hospedaje_Load(object sender, EventArgs e)
        {

            /*datagrid
            DataGridView dgv = (DataGridView)sender;
            txtRecepcionista.Text = dgv[0,e.rowIndex];
            */
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frm_Cliente = new frm_Cliente_Titular();
            frm_Cliente.dgvClienteTitular.CellMouseDoubleClick += DgvCliente_CellMouseDoubleClick;
            frm_Cliente.ShowDialog();
        }
        private void DgvCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv[9, e.RowIndex].Value.ToString().Trim() != "")
            {
                MessageBox.Show("El cliente que ha seleccionado es un acompañante de otro que es el cliente titular","Informacion");
                txtId_cli.Clear();
                txtNombre_cli.Clear();
            }
            else
            {
                txtId_cli.Text = dgv[0, e.RowIndex].Value.ToString().Trim();
                txtNombre_cli.Text = dgv[2, e.RowIndex].Value.ToString().Trim() + " " + dgv[3, e.RowIndex].Value.ToString().Trim() + " " + dgv[4, e.RowIndex].Value.ToString().Trim();                
            }
            frm_Cliente.Close();
        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            frm_hab = new frm_Habitacion();
            frm_hab.dgvHabitacion.CellMouseDoubleClick += dgvHabitacion_CellMouseDoubleClick;
            frm_hab.ShowDialog();
        }

        private void dgvHabitacion_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            txtId_hab.Text = dgv[0, e.RowIndex].Value.ToString().Trim();
            txtNro_Hab.Text = dgv[1, e.RowIndex].Value.ToString().Trim();
            txtNro_piso.Text = dgv[2, e.RowIndex].Value.ToString().Trim();

            //Mostrando el tipo de habitacion en el edit correspondiente
            string tipo_hab = (dgv[4, e.RowIndex].Value.ToString().Trim());
            //Preguntando si el tipo de habitacion es un valor numerico
            if (tipo_hab == "1" || tipo_hab == "2" || tipo_hab == "3" || tipo_hab == "4")
            {
                //para convertir string a int
                int tipo_h = int.Parse(tipo_hab);
                if (tipo_h == 1) { tipo_hab = "simple"; }
                if (tipo_h == 2) { tipo_hab = "familiar"; }
                if (tipo_h == 3) { tipo_hab = "matrimonial"; }
                if (tipo_h == 4) { tipo_hab = "especial"; }
            }
            
            txtEstado.Text = dgv[3, e.RowIndex].Value.ToString().Trim();
            if (txtEstado.Text == "Ocupada")
            {
                txtId_hab.Clear();
                txtNro_Hab.Clear();
                txtEstado.Clear();
                txtNro_piso.Clear();
                MessageBox.Show("La habitacion seleccionada está ya ocupada", "Informacion");
                txtTipo_hab.Clear();
            }
            txtTipo_hab.Text = tipo_hab;
            frm_hab.Close();
        }
        int sw = 0;
        private void btnMostrarNota_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "Nota Hospedaje";
            dgvNota_Detalle.DataSource = nota.mostrar_Nota_Hospedaje();
            dgvNota_Detalle.DataMember = "tac";
            dgvNota_Detalle.AutoResizeColumns();
            dgvNota_Detalle.AutoResizeRows();
        }

        private void btnMostrarDetalle_Click(object sender, EventArgs e)
        {

            if (sw == 0)
            {
                labelTitulo.Text = "Detalle Hospedaje";
                dgvNota_Detalle.DataSource = det.mostrar_Detalle_Hospedaje();
                dgvNota_Detalle.DataMember = "tac";
                dgvNota_Detalle.AutoResizeColumns();
                dgvNota_Detalle.AutoResizeRows();
                sw = 1;
            }
            else
            {
                labelTitulo.Text = "Nota Hospedaje";
                dgvNota_Detalle.DataSource = nota.mostrar_Nota_Hospedaje();
                dgvNota_Detalle.DataMember = "tac";
                dgvNota_Detalle.AutoResizeColumns();
                dgvNota_Detalle.AutoResizeRows();
                sw = 0;
            }
        }
        clsEmpleado emp = new clsEmpleado();
        private void button1_Click(object sender, EventArgs e)
        {
            frm_emp = new frm_Empleado();
            frm_emp.dgvEmpleado.CellMouseDoubleClick += DgvEmpleado_CellMouseDoubleClick;
            frm_emp.ShowDialog();
        }

        private void DgvEmpleado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            string tipo_emp;
            {
                tipo_emp = dgv[9, e.RowIndex].Value.ToString().Trim();
                if (tipo_emp != "1")
                {
                    txtRecepcionista.Text = dgv[2, e.RowIndex].Value.ToString().Trim() + " " + dgv[3, e.RowIndex].Value.ToString().Trim() + " " + dgv[4, e.RowIndex].Value.ToString().Trim();
                    txtId_emp.Text = "1";
                }
                else
                {
                    MessageBox.Show("Solo un recepcionista puede registrar un hospedaje", "INFORMACION");
                }
            }
            frm_emp.Close();
        }

        private void btnColocar_Click(object sender, EventArgs e)
        {

            if (labelTitulo.Text == "Nota Hospedaje")
            {
                try
                {
                    nota.Fecha = txtFechaNota.Text;
                    nota.Monto = "";
                    nota.Id_cliente = txtId_cli.Text;
                    nota.Id_empleado = txtId_emp.Text;
                    nota.guardar();
                    LimpiarTexto();
                    MessageBox.Show("Nota insertada con exito!", "INFORMACION");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error al insertar nota" + er.ToString());
                }
            }
            else
            {
                if (labelTitulo.Text == "Detalle Hospedaje")
                {
                    try
                    {
                        det.Id_nota = txtId_nota.Text;
                        det.Id_habitacion = txtId_hab.Text;
                        det.Cant_dias = txtCantidadDias.Text;
                        det.Descuento = txtDescuento.Text;
                        det.Fecha_salida = "";
                        det.Preciov = "";
                        det.guardar();
                        LimpiarTexto();
                        MessageBox.Show("Detalle insertado con exito!", "INFORMACION");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Error al insertar detalle" + er.ToString());
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button2.Enabled = false;
            if (labelTitulo.Text == "Nota Hospedaje")
            {
                try
                {
                    nota.Id_nota = txtId_nota.Text;
                    nota.Fecha = txtFechaNota.Text;
                    nota.Monto = "";
                    nota.Id_cliente = txtId_cli.Text;
                    nota.Id_empleado = txtId_emp.Text;
                    nota.Modificar_Nota();
                    LimpiarTexto();
                    MessageBox.Show("Nota modificada con exito!", "INFORMACION");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error al modificar nota" + er.ToString());
                }
            }
            else
            {
                if (labelTitulo.Text == "Detalle Hospedaje")
                {
                    try
                    {
                        det.Id_nota = txtId_nota.Text;
                        det.Id_habitacion = txtId_hab.Text;
                        det.Cant_dias = txtCantidadDias.Text;
                        det.Descuento = txtDescuento.Text;
                        det.Fecha_salida = "";
                        det.Preciov = "";
                        det.Modificar_Detalle_Hospedaje();
                        LimpiarTexto();
                        MessageBox.Show("Detalle modificiado con exito!", "INFORMACION");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Error al modificar detalle" + er.ToString());
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //btnEliminar.Enabled = false;
            if (labelTitulo.Text == "Nota Hospedaje")
            {
                try
                {
                    nota.Id_nota = txtId_nota.Text;
                    nota.Eliminar_Nota();
                    LimpiarTexto();
                    MessageBox.Show("Nota eliminada con exito!", "INFORMACION");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error al eliminar nota" + er.ToString());
                }
            }
            else
            {
                if (labelTitulo.Text == "Detalle Hospedaje")
                {
                    try
                    {
                        det.Id_nota = txtId_nota.Text;
                        det.Id_habitacion = txtId_hab.Text;
                        det.Eliminar_Detalle_Hospedaje();
                        LimpiarTexto();
                        MessageBox.Show("Detalle eliminada con exito!", "INFORMACION");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Error al eliminar detalle" + er.ToString());
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (labelTitulo.Text == "Detalle Hospedaje")
            {
                labelTitulo.Text = "Detalle Hospedaje";
                dgvNota_Detalle.DataSource = det.mostrar_Detalle_Hospedaje();
                dgvNota_Detalle.DataMember = "tac";
                dgvNota_Detalle.AutoResizeColumns();
                dgvNota_Detalle.AutoResizeRows();
            }
            else
            {
                labelTitulo.Text = "Nota Hospedaje";
                dgvNota_Detalle.DataSource = nota.mostrar_Nota_Hospedaje();
                dgvNota_Detalle.DataMember = "tac";
                dgvNota_Detalle.AutoResizeColumns();
                dgvNota_Detalle.AutoResizeRows();
            }
        }
    }
}
