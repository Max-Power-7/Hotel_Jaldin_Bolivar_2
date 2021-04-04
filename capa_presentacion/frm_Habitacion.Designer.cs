namespace capa_presentacion
{
    partial class frm_Habitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Habitacion));
            this.dgvHabitacion = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNro_Hab = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNro_Piso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId_Tipo_Hab = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId_Habitacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDisponibles = new System.Windows.Forms.Button();
            this.btnOcupadas = new System.Windows.Forms.Button();
            this.btnReservadas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHabitacion
            // 
            this.dgvHabitacion.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitacion.Location = new System.Drawing.Point(261, 22);
            this.dgvHabitacion.Name = "dgvHabitacion";
            this.dgvHabitacion.Size = new System.Drawing.Size(492, 486);
            this.dgvHabitacion.TabIndex = 0;
            this.dgvHabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitacion_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(770, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nro. Habitacion";
            // 
            // txtNro_Hab
            // 
            this.txtNro_Hab.BackColor = System.Drawing.Color.Wheat;
            this.txtNro_Hab.Location = new System.Drawing.Point(926, 108);
            this.txtNro_Hab.Name = "txtNro_Hab";
            this.txtNro_Hab.Size = new System.Drawing.Size(100, 20);
            this.txtNro_Hab.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(759, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNro_Piso
            // 
            this.txtNro_Piso.BackColor = System.Drawing.Color.Wheat;
            this.txtNro_Piso.Location = new System.Drawing.Point(926, 137);
            this.txtNro_Piso.Name = "txtNro_Piso";
            this.txtNro_Piso.Size = new System.Drawing.Size(100, 20);
            this.txtNro_Piso.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(770, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nro. Piso";
            // 
            // txtId_Tipo_Hab
            // 
            this.txtId_Tipo_Hab.BackColor = System.Drawing.Color.Wheat;
            this.txtId_Tipo_Hab.Location = new System.Drawing.Point(937, 203);
            this.txtId_Tipo_Hab.Name = "txtId_Tipo_Hab";
            this.txtId_Tipo_Hab.Size = new System.Drawing.Size(89, 20);
            this.txtId_Tipo_Hab.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(766, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Id_Tipo_Habitacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SaddleBrown;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(770, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Estado";
            // 
            // txtId_Habitacion
            // 
            this.txtId_Habitacion.BackColor = System.Drawing.Color.Wheat;
            this.txtId_Habitacion.Location = new System.Drawing.Point(935, 320);
            this.txtId_Habitacion.Name = "txtId_Habitacion";
            this.txtId_Habitacion.Size = new System.Drawing.Size(97, 20);
            this.txtId_Habitacion.TabIndex = 16;
            this.txtId_Habitacion.TextChanged += new System.EventHandler(this.txtId_Habitacion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SaddleBrown;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(773, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID Habitacion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(759, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "MOSTRAR REGISTROS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Sienna;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(759, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Sienna;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(759, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(273, 33);
            this.button4.TabIndex = 18;
            this.button4.Text = "MODIFICAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.Moccasin;
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "Libre",
            "Ocupada",
            "Reservada"});
            this.txtEstado.Location = new System.Drawing.Point(926, 169);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 21);
            this.txtEstado.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Sienna;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(759, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(273, 35);
            this.button5.TabIndex = 21;
            this.button5.Text = "BUSCAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Wheat;
            this.txtBuscar.Location = new System.Drawing.Point(937, 396);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(89, 20);
            this.txtBuscar.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SaddleBrown;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(773, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "ID Tipo Habitacion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.pictureBox1.Location = new System.Drawing.Point(24, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 212);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnDisponibles
            // 
            this.btnDisponibles.BackColor = System.Drawing.Color.Chocolate;
            this.btnDisponibles.FlatAppearance.BorderSize = 0;
            this.btnDisponibles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnDisponibles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponibles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDisponibles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisponibles.Location = new System.Drawing.Point(24, 267);
            this.btnDisponibles.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisponibles.Name = "btnDisponibles";
            this.btnDisponibles.Size = new System.Drawing.Size(214, 36);
            this.btnDisponibles.TabIndex = 55;
            this.btnDisponibles.Text = "       DISPONIBLES";
            this.btnDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisponibles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisponibles.UseVisualStyleBackColor = false;
            this.btnDisponibles.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnOcupadas
            // 
            this.btnOcupadas.BackColor = System.Drawing.Color.Chocolate;
            this.btnOcupadas.FlatAppearance.BorderSize = 0;
            this.btnOcupadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnOcupadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnOcupadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcupadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcupadas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOcupadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOcupadas.Location = new System.Drawing.Point(24, 310);
            this.btnOcupadas.Margin = new System.Windows.Forms.Padding(2);
            this.btnOcupadas.Name = "btnOcupadas";
            this.btnOcupadas.Size = new System.Drawing.Size(214, 36);
            this.btnOcupadas.TabIndex = 56;
            this.btnOcupadas.Text = "       OCUPADAS";
            this.btnOcupadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOcupadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOcupadas.UseVisualStyleBackColor = false;
            this.btnOcupadas.Click += new System.EventHandler(this.btnOcupadas_Click);
            // 
            // btnReservadas
            // 
            this.btnReservadas.BackColor = System.Drawing.Color.Chocolate;
            this.btnReservadas.FlatAppearance.BorderSize = 0;
            this.btnReservadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnReservadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnReservadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservadas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReservadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservadas.Location = new System.Drawing.Point(24, 352);
            this.btnReservadas.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservadas.Name = "btnReservadas";
            this.btnReservadas.Size = new System.Drawing.Size(214, 36);
            this.btnReservadas.TabIndex = 57;
            this.btnReservadas.Text = "       RESERVADA";
            this.btnReservadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservadas.UseVisualStyleBackColor = false;
            this.btnReservadas.Click += new System.EventHandler(this.btnReservadas_Click);
            // 
            // frm_Habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 684);
            this.Controls.Add(this.btnReservadas);
            this.Controls.Add(this.btnOcupadas);
            this.Controls.Add(this.btnDisponibles);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtId_Habitacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId_Tipo_Hab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNro_Piso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNro_Hab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHabitacion);
            this.Name = "frm_Habitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Habitacion";
            this.Load += new System.EventHandler(this.frm_Habitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNro_Hab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNro_Piso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId_Tipo_Hab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId_Habitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox txtEstado;
        public System.Windows.Forms.DataGridView dgvHabitacion;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDisponibles;
        private System.Windows.Forms.Button btnOcupadas;
        private System.Windows.Forms.Button btnReservadas;
    }
}