namespace capa_presentacion
{
    partial class frm_Detalle_habitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Detalle_habitacion));
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dgvDetalle_Habitacion = new System.Windows.Forms.DataGridView();
            this.txtLimite_Personas = new System.Windows.Forms.TextBox();
            this.txtId_Detalle = new System.Windows.Forms.TextBox();
            this.txtCamas = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTv_Cable = new System.Windows.Forms.ComboBox();
            this.txtDVD = new System.Windows.Forms.ComboBox();
            this.txtInternet = new System.Windows.Forms.ComboBox();
            this.txtAire_Acondicionado = new System.Windows.Forms.ComboBox();
            this.txtBaño_Privado = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle_Habitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(310, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "INSERTAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(310, 328);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "MOSTRAR REGISTROS";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(779, 332);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 28);
            this.button7.TabIndex = 6;
            this.button7.Text = "MODIFICAR";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(779, 264);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 28);
            this.button8.TabIndex = 7;
            this.button8.Text = "ELIMINAR";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dgvDetalle_Habitacion
            // 
            this.dgvDetalle_Habitacion.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvDetalle_Habitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle_Habitacion.Location = new System.Drawing.Point(258, 26);
            this.dgvDetalle_Habitacion.Name = "dgvDetalle_Habitacion";
            this.dgvDetalle_Habitacion.Size = new System.Drawing.Size(704, 171);
            this.dgvDetalle_Habitacion.TabIndex = 8;
            this.dgvDetalle_Habitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtLimite_Personas
            // 
            this.txtLimite_Personas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLimite_Personas.Location = new System.Drawing.Point(652, 250);
            this.txtLimite_Personas.Name = "txtLimite_Personas";
            this.txtLimite_Personas.Size = new System.Drawing.Size(72, 20);
            this.txtLimite_Personas.TabIndex = 11;
            // 
            // txtId_Detalle
            // 
            this.txtId_Detalle.Location = new System.Drawing.Point(652, 430);
            this.txtId_Detalle.Name = "txtId_Detalle";
            this.txtId_Detalle.Size = new System.Drawing.Size(72, 20);
            this.txtId_Detalle.TabIndex = 13;
            this.txtId_Detalle.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtCamas
            // 
            this.txtCamas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCamas.Location = new System.Drawing.Point(652, 223);
            this.txtCamas.Name = "txtCamas";
            this.txtCamas.Size = new System.Drawing.Size(72, 20);
            this.txtCamas.TabIndex = 14;
            this.txtCamas.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(551, 503);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 28);
            this.button5.TabIndex = 17;
            this.button5.Text = "BUSCAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "id_detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "camas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "limite_personas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "tv_cable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "dvd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "aire_acondicionado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "internet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(494, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "baño_privado";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTv_Cable
            // 
            this.txtTv_Cable.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTv_Cable.FormattingEnabled = true;
            this.txtTv_Cable.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.txtTv_Cable.Location = new System.Drawing.Point(652, 278);
            this.txtTv_Cable.Name = "txtTv_Cable";
            this.txtTv_Cable.Size = new System.Drawing.Size(72, 21);
            this.txtTv_Cable.TabIndex = 27;
            // 
            // txtDVD
            // 
            this.txtDVD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDVD.FormattingEnabled = true;
            this.txtDVD.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.txtDVD.Location = new System.Drawing.Point(652, 307);
            this.txtDVD.Name = "txtDVD";
            this.txtDVD.Size = new System.Drawing.Size(72, 21);
            this.txtDVD.TabIndex = 28;
            // 
            // txtInternet
            // 
            this.txtInternet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtInternet.FormattingEnabled = true;
            this.txtInternet.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.txtInternet.Location = new System.Drawing.Point(652, 366);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(72, 21);
            this.txtInternet.TabIndex = 30;
            // 
            // txtAire_Acondicionado
            // 
            this.txtAire_Acondicionado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAire_Acondicionado.FormattingEnabled = true;
            this.txtAire_Acondicionado.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.txtAire_Acondicionado.Location = new System.Drawing.Point(652, 336);
            this.txtAire_Acondicionado.Name = "txtAire_Acondicionado";
            this.txtAire_Acondicionado.Size = new System.Drawing.Size(72, 21);
            this.txtAire_Acondicionado.TabIndex = 29;
            // 
            // txtBaño_Privado
            // 
            this.txtBaño_Privado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBaño_Privado.FormattingEnabled = true;
            this.txtBaño_Privado.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.txtBaño_Privado.Location = new System.Drawing.Point(652, 397);
            this.txtBaño_Privado.Name = "txtBaño_Privado";
            this.txtBaño_Privado.Size = new System.Drawing.Size(72, 21);
            this.txtBaño_Privado.TabIndex = 31;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(566, 477);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(88, 20);
            this.txtBuscar.TabIndex = 32;
            // 
            // frm_Detalle_habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 660);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtBaño_Privado);
            this.Controls.Add(this.txtInternet);
            this.Controls.Add(this.txtAire_Acondicionado);
            this.Controls.Add(this.txtDVD);
            this.Controls.Add(this.txtTv_Cable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtCamas);
            this.Controls.Add(this.txtId_Detalle);
            this.Controls.Add(this.txtLimite_Personas);
            this.Controls.Add(this.dgvDetalle_Habitacion);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Name = "frm_Detalle_habitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Detalle_habitacion";
            this.Load += new System.EventHandler(this.frm_Detalle_habitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle_Habitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtLimite_Personas;
        private System.Windows.Forms.TextBox txtId_Detalle;
        private System.Windows.Forms.TextBox txtCamas;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtTv_Cable;
        private System.Windows.Forms.ComboBox txtDVD;
        private System.Windows.Forms.ComboBox txtInternet;
        private System.Windows.Forms.ComboBox txtAire_Acondicionado;
        private System.Windows.Forms.ComboBox txtBaño_Privado;
        public System.Windows.Forms.DataGridView dgvDetalle_Habitacion;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}