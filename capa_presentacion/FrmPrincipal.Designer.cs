namespace capa_presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTipoHab = new System.Windows.Forms.Button();
            this.btnTipoEmp = new System.Windows.Forms.Button();
            this.btnNotaHos = new System.Windows.Forms.Button();
            this.btnDetalleHab = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnHabitacion = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.AutoSize = true;
            this.panelContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContenedor.BackColor = System.Drawing.Color.Tan;
            this.panelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenedor.BackgroundImage")));
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Controls.Add(this.panelLateral);
            this.panelContenedor.Controls.Add(this.panelBarra);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1200, 600);
            this.panelContenedor.TabIndex = 0;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.Transparent;
            this.panelLateral.Controls.Add(this.pictureBox2);
            this.panelLateral.Controls.Add(this.btnTipoHab);
            this.panelLateral.Controls.Add(this.btnTipoEmp);
            this.panelLateral.Controls.Add(this.btnNotaHos);
            this.panelLateral.Controls.Add(this.btnDetalleHab);
            this.panelLateral.Controls.Add(this.btnReserva);
            this.panelLateral.Controls.Add(this.btnEmpleado);
            this.panelLateral.Controls.Add(this.btnHabitacion);
            this.panelLateral.Controls.Add(this.btnCliente);
            this.panelLateral.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 32);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(176, 568);
            this.panelLateral.TabIndex = 1;
            this.panelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLateral_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnTipoHab
            // 
            this.btnTipoHab.BackColor = System.Drawing.Color.Sienna;
            this.btnTipoHab.FlatAppearance.BorderSize = 0;
            this.btnTipoHab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnTipoHab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnTipoHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoHab.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTipoHab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoHab.Location = new System.Drawing.Point(11, 441);
            this.btnTipoHab.Margin = new System.Windows.Forms.Padding(2);
            this.btnTipoHab.Name = "btnTipoHab";
            this.btnTipoHab.Size = new System.Drawing.Size(146, 49);
            this.btnTipoHab.TabIndex = 9;
            this.btnTipoHab.Text = "TIPO HABITACION";
            this.btnTipoHab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoHab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTipoHab.UseVisualStyleBackColor = false;
            this.btnTipoHab.Click += new System.EventHandler(this.btnTipoHab_Click);
            // 
            // btnTipoEmp
            // 
            this.btnTipoEmp.BackColor = System.Drawing.Color.Sienna;
            this.btnTipoEmp.FlatAppearance.BorderSize = 0;
            this.btnTipoEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnTipoEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnTipoEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoEmp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTipoEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoEmp.Location = new System.Drawing.Point(11, 386);
            this.btnTipoEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnTipoEmp.Name = "btnTipoEmp";
            this.btnTipoEmp.Size = new System.Drawing.Size(146, 51);
            this.btnTipoEmp.TabIndex = 11;
            this.btnTipoEmp.Text = "TIPO EMPLEADO";
            this.btnTipoEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTipoEmp.UseVisualStyleBackColor = false;
            this.btnTipoEmp.Click += new System.EventHandler(this.btnTipoEmp_Click);
            // 
            // btnNotaHos
            // 
            this.btnNotaHos.BackColor = System.Drawing.Color.Sienna;
            this.btnNotaHos.FlatAppearance.BorderSize = 0;
            this.btnNotaHos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnNotaHos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnNotaHos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaHos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaHos.ForeColor = System.Drawing.Color.Transparent;
            this.btnNotaHos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaHos.Location = new System.Drawing.Point(11, 358);
            this.btnNotaHos.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotaHos.Name = "btnNotaHos";
            this.btnNotaHos.Size = new System.Drawing.Size(146, 24);
            this.btnNotaHos.TabIndex = 10;
            this.btnNotaHos.Text = "HOSPEDAJE";
            this.btnNotaHos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaHos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotaHos.UseVisualStyleBackColor = false;
            this.btnNotaHos.Click += new System.EventHandler(this.btnNotaHos_Click);
            // 
            // btnDetalleHab
            // 
            this.btnDetalleHab.BackColor = System.Drawing.Color.Sienna;
            this.btnDetalleHab.FlatAppearance.BorderSize = 0;
            this.btnDetalleHab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnDetalleHab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnDetalleHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleHab.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetalleHab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleHab.Location = new System.Drawing.Point(11, 305);
            this.btnDetalleHab.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetalleHab.Name = "btnDetalleHab";
            this.btnDetalleHab.Size = new System.Drawing.Size(146, 49);
            this.btnDetalleHab.TabIndex = 8;
            this.btnDetalleHab.Text = "DETALLE HABITACION";
            this.btnDetalleHab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleHab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetalleHab.UseVisualStyleBackColor = false;
            this.btnDetalleHab.Click += new System.EventHandler(this.btnDetalleHab_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.BackColor = System.Drawing.Color.Sienna;
            this.btnReserva.FlatAppearance.BorderSize = 0;
            this.btnReserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserva.Location = new System.Drawing.Point(11, 273);
            this.btnReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(146, 28);
            this.btnReserva.TabIndex = 5;
            this.btnReserva.Text = "RESERVA";
            this.btnReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.Sienna;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(11, 243);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(146, 26);
            this.btnEmpleado.TabIndex = 7;
            this.btnEmpleado.Text = "EMPLEADO";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnHabitacion
            // 
            this.btnHabitacion.BackColor = System.Drawing.Color.Sienna;
            this.btnHabitacion.FlatAppearance.BorderSize = 0;
            this.btnHabitacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnHabitacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitacion.ForeColor = System.Drawing.Color.Transparent;
            this.btnHabitacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabitacion.Location = new System.Drawing.Point(11, 213);
            this.btnHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnHabitacion.Name = "btnHabitacion";
            this.btnHabitacion.Size = new System.Drawing.Size(146, 26);
            this.btnHabitacion.TabIndex = 6;
            this.btnHabitacion.Text = "HABITACION";
            this.btnHabitacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabitacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHabitacion.UseVisualStyleBackColor = false;
            this.btnHabitacion.Click += new System.EventHandler(this.btnHabitacion_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Sienna;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(11, 185);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(146, 24);
            this.btnCliente.TabIndex = 4;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.DarkRed;
            this.panelBarra.Controls.Add(this.btnRestaurar);
            this.panelBarra.Controls.Add(this.btnMaximizar);
            this.panelBarra.Controls.Add(this.btnMinimizar);
            this.panelBarra.Controls.Add(this.btnCerrar);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(1200, 32);
            this.panelBarra.TabIndex = 0;
            this.panelBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1139, 6);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(18, 18);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1139, 5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(18, 18);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1115, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(18, 18);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1167, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(18, 18);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnHabitacion;
        public System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnTipoHab;
        private System.Windows.Forms.Button btnTipoEmp;
        private System.Windows.Forms.Button btnNotaHos;
        private System.Windows.Forms.Button btnDetalleHab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}