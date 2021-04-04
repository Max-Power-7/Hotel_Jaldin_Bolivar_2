using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace capa_presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        }
        #region formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }

        // Color para el rectangulo inferior
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }


        int lx, ly;
        int sw, sh;


        private void btnMaximizar_Click(object sender, EventArgs e)
        {

            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;

            this.Size = new Size(sw, sh);
            this.Location = new Point(lx,ly);
        }

        private void panelBarra_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Abrirformulario<frm_Cliente_Titular>();
            btnCliente.BackColor = Color.FromArgb(12,61,92);
        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            Abrirformulario<frm_Habitacion>();
            btnHabitacion.BackColor=Color.FromArgb(12,61,92);
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Abrirformulario<frm_Empleado>();
            btnEmpleado.BackColor = Color.FromArgb(12,61,92);
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            Abrirformulario<frm_Reserva>();
            btnReserva.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNotaHos_Click(object sender, EventArgs e)
        {
            Abrirformulario<frm_Nota_Hospedaje>();
            btnNotaHos.BackColor = Color.FromArgb(12,61,92);
        }

        private void btnDetalleHab_Click(object sender, EventArgs e)
        {
            Abrirformulario<frm_Detalle_habitacion>();
            btnDetalleHab.BackColor = Color.FromArgb(12,61,92);
        }

        private void btnTipoEmp_Click(object sender, EventArgs e)
        {
            Abrirformulario<frm_Tipo_Empleado>();
            btnTipoEmp.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnTipoHab_Click(object sender, EventArgs e)
        {
            Abrirformulario<frm_Tipo_Habitacion>();
            btnTipoHab.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_Cliente_Titular cli = new frm_Cliente_Titular();
            cli.Close();

            //Cerrar los demas formularios y volver al principal 
            //panelContenedor.Visible = true;


            //frm_Cliente_Titular.fromClo=new FormClosedEventHandler(ClosedForms);
            //   Abrirformulario<FrmPrincipal>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Cliente_Titular cli = new frm_Cliente_Titular();
            cli.Close();
        }

        private void Abrirformulario<MiForm>() where MiForm: Form, new()
        {   Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;

                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

                formulario.FormClosed += new FormClosedEventHandler(ClosedForms); 
            }
            else {
                    formulario.BringToFront();
                 }
        }
        private void ClosedForms(Object sender, FormClosedEventArgs e)
        {

            if (Application.OpenForms["FrmCliente"] == null)
                btnCliente.BackColor = Color.FromArgb(12,40,65);

            if (Application.OpenForms["FrmHabitacion"] == null)
                btnHabitacion.BackColor = Color.FromArgb(12, 40, 65);

            if (Application.OpenForms["FrmEmpleado"] == null)
                btnEmpleado.BackColor = Color.FromArgb(12, 40, 65);

            if (Application.OpenForms["FrmReserva"] == null)
                btnReserva.BackColor = Color.FromArgb(12, 40, 65);


        }

    }

}
