namespace capa_presentacion
{
    partial class frm_Cliente_Titular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cliente_Titular));
            this.dgvClienteTitular = new System.Windows.Forms.DataGridView();
            this.txtLugar_nac = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtId_huesped = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtExtranjero = new System.Windows.Forms.ComboBox();
            this.dtpFecha_Nac = new System.Windows.Forms.DateTimePicker();
            this.txtId_cliente = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnClNacional = new System.Windows.Forms.Button();
            this.btnClExtrajero = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteTitular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClienteTitular
            // 
            this.dgvClienteTitular.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvClienteTitular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteTitular.GridColor = System.Drawing.Color.Orange;
            this.dgvClienteTitular.Location = new System.Drawing.Point(175, 25);
            this.dgvClienteTitular.Name = "dgvClienteTitular";
            this.dgvClienteTitular.Size = new System.Drawing.Size(805, 320);
            this.dgvClienteTitular.TabIndex = 0;
            this.dgvClienteTitular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteTitular_CellContentClick);
            // 
            // txtLugar_nac
            // 
            this.txtLugar_nac.Location = new System.Drawing.Point(252, 510);
            this.txtLugar_nac.Name = "txtLugar_nac";
            this.txtLugar_nac.Size = new System.Drawing.Size(100, 20);
            this.txtLugar_nac.TabIndex = 13;
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(251, 382);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(100, 20);
            this.txtCi.TabIndex = 14;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(252, 478);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtMaterno.TabIndex = 17;
            this.txtMaterno.TextChanged += new System.EventHandler(this.txtMaterno_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(563, 384);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 18;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(251, 449);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtPaterno.TabIndex = 22;
            // 
            // txtId_huesped
            // 
            this.txtId_huesped.Location = new System.Drawing.Point(563, 476);
            this.txtId_huesped.Name = "txtId_huesped";
            this.txtId_huesped.Size = new System.Drawing.Size(100, 20);
            this.txtId_huesped.TabIndex = 23;
            this.txtId_huesped.Text = "0";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(251, 418);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 24;
            // 
            // txtExtranjero
            // 
            this.txtExtranjero.FormattingEnabled = true;
            this.txtExtranjero.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.txtExtranjero.Location = new System.Drawing.Point(563, 441);
            this.txtExtranjero.Name = "txtExtranjero";
            this.txtExtranjero.Size = new System.Drawing.Size(100, 21);
            this.txtExtranjero.TabIndex = 26;
            this.txtExtranjero.SelectedIndexChanged += new System.EventHandler(this.txtExtranjero_SelectedIndexChanged);
            // 
            // dtpFecha_Nac
            // 
            this.dtpFecha_Nac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Nac.Location = new System.Drawing.Point(563, 410);
            this.dtpFecha_Nac.MaxDate = new System.DateTime(2000, 12, 5, 0, 0, 0, 0);
            this.dtpFecha_Nac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFecha_Nac.Name = "dtpFecha_Nac";
            this.dtpFecha_Nac.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha_Nac.TabIndex = 27;
            this.dtpFecha_Nac.Value = new System.DateTime(2000, 12, 5, 0, 0, 0, 0);
            this.dtpFecha_Nac.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtId_cliente
            // 
            this.txtId_cliente.Location = new System.Drawing.Point(850, 408);
            this.txtId_cliente.Name = "txtId_cliente";
            this.txtId_cliente.Size = new System.Drawing.Size(91, 20);
            this.txtId_cliente.TabIndex = 31;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(850, 492);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(91, 20);
            this.txtBuscar.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "lugar_nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "ci";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(441, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "id_huesped";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(444, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "extranjero";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(441, 410);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.TabIndex = 46;
            this.label13.Text = "fecha_nac";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(441, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 20);
            this.label14.TabIndex = 45;
            this.label14.Text = "telefono";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(699, 415);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 24);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(699, 381);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 24);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(33, 311);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(117, 24);
            this.btnInsertar.TabIndex = 54;
            this.btnInsertar.Text = "  INSERTAR";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLista.Location = new System.Drawing.Point(13, 205);
            this.btnLista.Margin = new System.Windows.Forms.Padding(2);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(157, 24);
            this.btnLista.TabIndex = 53;
            this.btnLista.Text = "LISTA COMPLETA";
            this.btnLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnClNacional
            // 
            this.btnClNacional.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnClNacional.FlatAppearance.BorderSize = 0;
            this.btnClNacional.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnClNacional.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnClNacional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClNacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClNacional.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClNacional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClNacional.Location = new System.Drawing.Point(13, 262);
            this.btnClNacional.Margin = new System.Windows.Forms.Padding(2);
            this.btnClNacional.Name = "btnClNacional";
            this.btnClNacional.Size = new System.Drawing.Size(157, 24);
            this.btnClNacional.TabIndex = 52;
            this.btnClNacional.Text = "NACIONALES";
            this.btnClNacional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClNacional.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClNacional.UseVisualStyleBackColor = false;
            this.btnClNacional.Click += new System.EventHandler(this.btnClNacional_Click);
            // 
            // btnClExtrajero
            // 
            this.btnClExtrajero.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnClExtrajero.FlatAppearance.BorderSize = 0;
            this.btnClExtrajero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnClExtrajero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnClExtrajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClExtrajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClExtrajero.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClExtrajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClExtrajero.Location = new System.Drawing.Point(13, 233);
            this.btnClExtrajero.Margin = new System.Windows.Forms.Padding(2);
            this.btnClExtrajero.Name = "btnClExtrajero";
            this.btnClExtrajero.Size = new System.Drawing.Size(157, 24);
            this.btnClExtrajero.TabIndex = 51;
            this.btnClExtrajero.Text = "EXTRANJEROS";
            this.btnClExtrajero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClExtrajero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClExtrajero.UseVisualStyleBackColor = false;
            this.btnClExtrajero.Click += new System.EventHandler(this.btnClExtrajero_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(846, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "ID Cliente";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(699, 491);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 24);
            this.btnBuscar.TabIndex = 56;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(846, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "nombre o id";
            // 
            // frm_Cliente_Titular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 660);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnClNacional);
            this.Controls.Add(this.btnClExtrajero);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtId_cliente);
            this.Controls.Add(this.dtpFecha_Nac);
            this.Controls.Add(this.txtExtranjero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId_huesped);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.txtLugar_nac);
            this.Controls.Add(this.dgvClienteTitular);
            this.Name = "frm_Cliente_Titular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Cliente_Titular";
            this.Load += new System.EventHandler(this.frm_Cliente_Titular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteTitular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLugar_nac;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtId_huesped;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox txtExtranjero;
        private System.Windows.Forms.DateTimePicker dtpFecha_Nac;
        private System.Windows.Forms.TextBox txtId_cliente;
        public System.Windows.Forms.DataGridView dgvClienteTitular;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnClNacional;
        private System.Windows.Forms.Button btnClExtrajero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
    }
}