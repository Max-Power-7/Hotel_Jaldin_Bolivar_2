using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frm_Cliente_Titular cl = new frm_Cliente_Titular();
            cl.ShowDialog();
        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Detalle_habitacion det = new frm_Detalle_habitacion();
            det.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_Tipo_Habitacion tip = new frm_Tipo_Habitacion();
            tip.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Habitacion hab = new frm_Habitacion();
            hab.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_Tipo_Empleado tipEmp = new frm_Tipo_Empleado();
            tipEmp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_Empleado emp = new frm_Empleado();
            emp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Reserva res = new frm_Reserva();
            res.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_Nota_Hospedaje not = new frm_Nota_Hospedaje();
            not.ShowDialog();
        }
    }
}
