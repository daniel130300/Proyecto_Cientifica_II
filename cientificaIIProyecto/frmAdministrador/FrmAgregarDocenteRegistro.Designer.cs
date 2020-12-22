namespace Registro
{
    partial class FrmAgregarDocenteRegistro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarDocenteRegistro));
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escuela_BDDDataSet28 = new cientificaIIProyecto.Escuela_BDDDataSet28();
            this.btnAgregarDoc = new System.Windows.Forms.Button();
            this.lblTituloAgregar = new System.Windows.Forms.Label();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.Identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pictureRegDoc = new System.Windows.Forms.PictureBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo_electronico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.estadoCivilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escuela_BDDDataSet29 = new cientificaIIProyecto.Escuela_BDDDataSet29();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregarRegs = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblProfesion = new System.Windows.Forms.Label();
            this.cmbProfesion = new System.Windows.Forms.ComboBox();
            this.profesionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escuela_BDDDataSet30 = new cientificaIIProyecto.Escuela_BDDDataSet30();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesionesTableAdapter1 = new cientificaIIProyecto.Escuela_BDDDataSet19TableAdapters.ProfesionesTableAdapter();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.escuela_BDDDataSet27 = new cientificaIIProyecto.Escuela_BDDDataSet27();
            this.generoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter2 = new cientificaIIProyecto.Escuela_BDDDataSet27TableAdapters.GeneroTableAdapter();
            this.generoTableAdapter = new cientificaIIProyecto.Escuela_BDDDataSet28TableAdapters.GeneroTableAdapter();
            this.generoTableAdapter1 = new cientificaIIProyecto.Escuela_BDDDataSet26TableAdapters.GeneroTableAdapter();
            this.generoTableAdapter3 = new cientificaIIProyecto.Escuela_BDDDataSet26TableAdapters.GeneroTableAdapter();
            this.tableAdapterManager1 = new cientificaIIProyecto.Escuela_BDDDataSetTableAdapters.TableAdapterManager();
            this.tableAdapterManager2 = new cientificaIIProyecto.Escuela_BDDDataSet9TableAdapters.TableAdapterManager();
            this.profesionesTableAdapter2 = new cientificaIIProyecto.Escuela_BDDDataSet9TableAdapters.ProfesionesTableAdapter();
            this.tableAdapterManager3 = new cientificaIIProyecto.Escuela_BDDDataSet8TableAdapters.TableAdapterManager();
            this.estado_CivilTableAdapter = new cientificaIIProyecto.Escuela_BDDDataSet29TableAdapters.Estado_CivilTableAdapter();
            this.profesionesTableAdapter = new cientificaIIProyecto.Escuela_BDDDataSet30TableAdapters.ProfesionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCivilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(38, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Sexo: ";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DataSource = this.generoBindingSource;
            this.cmbSexo.DisplayMember = "Descripcion_genero";
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(95, 282);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(114, 25);
            this.cmbSexo.TabIndex = 36;
            this.cmbSexo.ValueMember = "Id_genero";
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.escuela_BDDDataSet28;
            // 
            // escuela_BDDDataSet28
            // 
            this.escuela_BDDDataSet28.DataSetName = "Escuela_BDDDataSet28";
            this.escuela_BDDDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregarDoc
            // 
            this.btnAgregarDoc.FlatAppearance.BorderSize = 0;
            this.btnAgregarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDoc.Location = new System.Drawing.Point(42, 447);
            this.btnAgregarDoc.Name = "btnAgregarDoc";
            this.btnAgregarDoc.Size = new System.Drawing.Size(169, 47);
            this.btnAgregarDoc.TabIndex = 35;
            this.btnAgregarDoc.Text = "Agregar Docente";
            this.btnAgregarDoc.UseVisualStyleBackColor = true;
            this.btnAgregarDoc.Visible = false;
            this.btnAgregarDoc.Click += new System.EventHandler(this.btnAgregarDoc_Click);
            // 
            // lblTituloAgregar
            // 
            this.lblTituloAgregar.AutoSize = true;
            this.lblTituloAgregar.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloAgregar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgregar.ForeColor = System.Drawing.Color.White;
            this.lblTituloAgregar.Location = new System.Drawing.Point(315, 22);
            this.lblTituloAgregar.Name = "lblTituloAgregar";
            this.lblTituloAgregar.Size = new System.Drawing.Size(243, 28);
            this.lblTituloAgregar.TabIndex = 34;
            this.lblTituloAgregar.Text = "AGREGAR DOCENTE";
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identidad,
            this.Contraseña,
            this.Nombres,
            this.Apellidos,
            this.Foto,
            this.Fecha_nacimiento,
            this.Id_estado,
            this.Estado_civil,
            this.Id_genero,
            this.Genero,
            this.Correo_electronico,
            this.Sueldo});
            this.dgvRegistro.Location = new System.Drawing.Point(37, 517);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistro.Size = new System.Drawing.Size(753, 204);
            this.dgvRegistro.TabIndex = 33;
            this.dgvRegistro.Visible = false;
            // 
            // Identidad
            // 
            this.Identidad.DataPropertyName = "Identidad";
            this.Identidad.HeaderText = "Identidad";
            this.Identidad.Name = "Identidad";
            this.Identidad.ReadOnly = true;
            this.Identidad.Width = 76;
            // 
            // Contraseña
            // 
            this.Contraseña.DataPropertyName = "Contraseña";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            this.Contraseña.Width = 86;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 74;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 74;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Width = 53;
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.DataPropertyName = "Fecha_nacimiento";
            this.Fecha_nacimiento.HeaderText = "Fecha de nacimiento";
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.ReadOnly = true;
            this.Fecha_nacimiento.Width = 120;
            // 
            // Id_estado
            // 
            this.Id_estado.DataPropertyName = "Id_estado";
            this.Id_estado.HeaderText = "Id Estado";
            this.Id_estado.Name = "Id_estado";
            this.Id_estado.ReadOnly = true;
            this.Id_estado.Visible = false;
            // 
            // Estado_civil
            // 
            this.Estado_civil.DataPropertyName = "Descripcion_estado";
            this.Estado_civil.HeaderText = "Estado Civil";
            this.Estado_civil.Name = "Estado_civil";
            this.Estado_civil.ReadOnly = true;
            this.Estado_civil.Width = 80;
            // 
            // Id_genero
            // 
            this.Id_genero.DataPropertyName = "Id_genero";
            this.Id_genero.HeaderText = "Id Genero";
            this.Id_genero.Name = "Id_genero";
            this.Id_genero.ReadOnly = true;
            this.Id_genero.Visible = false;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Descripcion_genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 67;
            // 
            // Correo_electronico
            // 
            this.Correo_electronico.DataPropertyName = "Correo_electronico";
            this.Correo_electronico.HeaderText = "Correo Electrónico";
            this.Correo_electronico.Name = "Correo_electronico";
            this.Correo_electronico.ReadOnly = true;
            this.Correo_electronico.Width = 109;
            // 
            // Sueldo
            // 
            this.Sueldo.DataPropertyName = "Sueldo";
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            this.Sueldo.Width = 65;
            // 
            // btnCargar
            // 
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(609, 324);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(145, 47);
            this.btnCargar.TabIndex = 32;
            this.btnCargar.Text = "Cargar Imagen";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureRegDoc
            // 
            this.pictureRegDoc.Image = ((System.Drawing.Image)(resources.GetObject("pictureRegDoc.Image")));
            this.pictureRegDoc.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureRegDoc.InitialImage")));
            this.pictureRegDoc.Location = new System.Drawing.Point(577, 89);
            this.pictureRegDoc.Name = "pictureRegDoc";
            this.pictureRegDoc.Size = new System.Drawing.Size(213, 219);
            this.pictureRegDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRegDoc.TabIndex = 31;
            this.pictureRegDoc.TabStop = false;
            // 
            // txtSueldo
            // 
            this.txtSueldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(115, 405);
            this.txtSueldo.MaxLength = 5;
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(101, 19);
            this.txtSueldo.TabIndex = 30;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Sueldo: ";
            // 
            // txtCorreo_electronico
            // 
            this.txtCorreo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo_electronico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo_electronico.Location = new System.Drawing.Point(207, 367);
            this.txtCorreo_electronico.MaxLength = 200;
            this.txtCorreo_electronico.Name = "txtCorreo_electronico";
            this.txtCorreo_electronico.Size = new System.Drawing.Size(197, 19);
            this.txtCorreo_electronico.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Correo electrónico: ";
            // 
            // datePickerFechaNacimiento
            // 
            this.datePickerFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFechaNacimiento.Location = new System.Drawing.Point(217, 238);
            this.datePickerFechaNacimiento.Name = "datePickerFechaNacimiento";
            this.datePickerFechaNacimiento.Size = new System.Drawing.Size(321, 26);
            this.datePickerFechaNacimiento.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fecha de nacimiento: ";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(133, 165);
            this.txtApellidos.MaxLength = 150;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(215, 19);
            this.txtApellidos.TabIndex = 24;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(133, 126);
            this.txtNombres.MaxLength = 150;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(215, 19);
            this.txtNombres.TabIndex = 23;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(133, 89);
            this.txtIdentidad.MaxLength = 13;
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(215, 19);
            this.txtIdentidad.TabIndex = 22;
            this.txtIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Identidad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombres: ";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.DataSource = this.estadoCivilBindingSource;
            this.cmbEstadoCivil.DisplayMember = "Descripcion_estado";
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstadoCivil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(141, 322);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(114, 25);
            this.cmbEstadoCivil.TabIndex = 38;
            this.cmbEstadoCivil.ValueMember = "Id_estado";
            // 
            // estadoCivilBindingSource
            // 
            this.estadoCivilBindingSource.DataMember = "Estado Civil";
            this.estadoCivilBindingSource.DataSource = this.escuela_BDDDataSet29;
            // 
            // escuela_BDDDataSet29
            // 
            this.escuela_BDDDataSet29.DataSetName = "Escuela_BDDDataSet29";
            this.escuela_BDDDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(38, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Estado Civil:";
            // 
            // btnAgregarRegs
            // 
            this.btnAgregarRegs.FlatAppearance.BorderSize = 0;
            this.btnAgregarRegs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRegs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRegs.Location = new System.Drawing.Point(42, 448);
            this.btnAgregarRegs.Name = "btnAgregarRegs";
            this.btnAgregarRegs.Size = new System.Drawing.Size(170, 45);
            this.btnAgregarRegs.TabIndex = 40;
            this.btnAgregarRegs.Text = "Agregar Registro";
            this.btnAgregarRegs.UseVisualStyleBackColor = true;
            this.btnAgregarRegs.Visible = false;
            this.btnAgregarRegs.Click += new System.EventHandler(this.btnAgregarRegs_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Contraseña:  ";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(151, 203);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(197, 19);
            this.txtContraseña.TabIndex = 42;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblProfesion
            // 
            this.lblProfesion.AutoSize = true;
            this.lblProfesion.BackColor = System.Drawing.Color.Transparent;
            this.lblProfesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesion.ForeColor = System.Drawing.Color.White;
            this.lblProfesion.Location = new System.Drawing.Point(293, 323);
            this.lblProfesion.Name = "lblProfesion";
            this.lblProfesion.Size = new System.Drawing.Size(80, 20);
            this.lblProfesion.TabIndex = 43;
            this.lblProfesion.Text = "Profesión:";
            this.lblProfesion.Visible = false;
            // 
            // cmbProfesion
            // 
            this.cmbProfesion.DataSource = this.profesionesBindingSource;
            this.cmbProfesion.DisplayMember = "Descripcion_profesion";
            this.cmbProfesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProfesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesion.FormattingEnabled = true;
            this.cmbProfesion.Location = new System.Drawing.Point(377, 322);
            this.cmbProfesion.Name = "cmbProfesion";
            this.cmbProfesion.Size = new System.Drawing.Size(159, 25);
            this.cmbProfesion.TabIndex = 44;
            this.cmbProfesion.ValueMember = "Id_profesion";
            this.cmbProfesion.Visible = false;
            // 
            // profesionesBindingSource
            // 
            this.profesionesBindingSource.DataMember = "Profesiones";
            this.profesionesBindingSource.DataSource = this.escuela_BDDDataSet30;
            // 
            // escuela_BDDDataSet30
            // 
            this.escuela_BDDDataSet30.DataSetName = "Escuela_BDDDataSet30";
            this.escuela_BDDDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDocentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Id_profesion,
            this.Descripcion_profesion,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvDocentes.Location = new System.Drawing.Point(37, 517);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(753, 204);
            this.dgvDocentes.TabIndex = 45;
            this.dgvDocentes.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Identidad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Identidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 76;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Contraseña";
            this.dataGridViewTextBoxColumn2.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 86;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 74;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 74;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Foto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Foto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 53;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha_nacimiento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha de nacimiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id_estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 71;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Descripcion_estado";
            this.dataGridViewTextBoxColumn8.HeaderText = "Estado Civil";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id_genero";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id Genero";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 73;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Descripcion_genero";
            this.dataGridViewTextBoxColumn10.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 67;
            // 
            // Id_profesion
            // 
            this.Id_profesion.DataPropertyName = "Id_Profesion";
            this.Id_profesion.HeaderText = "Id_profesion";
            this.Id_profesion.Name = "Id_profesion";
            this.Id_profesion.ReadOnly = true;
            this.Id_profesion.Visible = false;
            this.Id_profesion.Width = 90;
            // 
            // Descripcion_profesion
            // 
            this.Descripcion_profesion.DataPropertyName = "Descripcion_profesion";
            this.Descripcion_profesion.HeaderText = "Profesión";
            this.Descripcion_profesion.Name = "Descripcion_profesion";
            this.Descripcion_profesion.ReadOnly = true;
            this.Descripcion_profesion.Width = 76;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Correo_electronico";
            this.dataGridViewTextBoxColumn11.HeaderText = "Correo Electrónico";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 109;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Sueldo";
            this.dataGridViewTextBoxColumn12.HeaderText = "Sueldo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 65;
            // 
            // profesionesTableAdapter1
            // 
            this.profesionesTableAdapter1.ClearBeforeFill = true;
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvertencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.White;
            this.lblAdvertencia.Location = new System.Drawing.Point(354, 203);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(0, 20);
            this.lblAdvertencia.TabIndex = 46;
            // 
            // escuela_BDDDataSet27
            // 
            this.escuela_BDDDataSet27.DataSetName = "Escuela_BDDDataSet27";
            this.escuela_BDDDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoBindingSource2
            // 
            this.generoBindingSource2.DataMember = "Genero";
            this.generoBindingSource2.DataSource = this.escuela_BDDDataSet27;
            // 
            // generoTableAdapter2
            // 
            this.generoTableAdapter2.ClearBeforeFill = true;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // generoTableAdapter1
            // 
            this.generoTableAdapter1.ClearBeforeFill = true;
            // 
            // generoTableAdapter3
            // 
            this.generoTableAdapter3.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.GeneroTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = cientificaIIProyecto.Escuela_BDDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.ProfesionesTableAdapter = this.profesionesTableAdapter2;
            this.tableAdapterManager2.UpdateOrder = cientificaIIProyecto.Escuela_BDDDataSet9TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // profesionesTableAdapter2
            // 
            this.profesionesTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Connection = null;
            this.tableAdapterManager3.Estado_CivilTableAdapter = null;
            this.tableAdapterManager3.UpdateOrder = cientificaIIProyecto.Escuela_BDDDataSet8TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estado_CivilTableAdapter
            // 
            this.estado_CivilTableAdapter.ClearBeforeFill = true;
            // 
            // profesionesTableAdapter
            // 
            this.profesionesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAgregarDocenteRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 756);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.cmbProfesion);
            this.Controls.Add(this.lblProfesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblTituloAgregar);
            this.Controls.Add(this.dgvRegistro);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pictureRegDoc);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCorreo_electronico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datePickerFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarRegs);
            this.Controls.Add(this.btnAgregarDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarDocenteRegistro";
            this.Text = "FrmAgregarDocente";
            this.Load += new System.EventHandler(this.FrmAgregarDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCivilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela_BDDDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.PictureBox pictureRegDoc;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreo_electronico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePickerFechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnAgregarDoc;
        public System.Windows.Forms.Label lblTituloAgregar;
        public System.Windows.Forms.Button btnAgregarRegs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        public System.Windows.Forms.ComboBox cmbProfesion;
        public System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_profesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_profesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        public System.Windows.Forms.Label lblProfesion;
        private cientificaIIProyecto.Escuela_BDDDataSet19TableAdapters.ProfesionesTableAdapter profesionesTableAdapter1;
        private System.Windows.Forms.Label lblAdvertencia;
        private cientificaIIProyecto.Escuela_BDDDataSet27 escuela_BDDDataSet27;
        private System.Windows.Forms.BindingSource generoBindingSource2;
        private cientificaIIProyecto.Escuela_BDDDataSet27TableAdapters.GeneroTableAdapter generoTableAdapter2;
        private cientificaIIProyecto.Escuela_BDDDataSet28 escuela_BDDDataSet28;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private cientificaIIProyecto.Escuela_BDDDataSet28TableAdapters.GeneroTableAdapter generoTableAdapter;
        private cientificaIIProyecto.Escuela_BDDDataSet26TableAdapters.GeneroTableAdapter generoTableAdapter1;
        private cientificaIIProyecto.Escuela_BDDDataSet26TableAdapters.GeneroTableAdapter generoTableAdapter3;
        private cientificaIIProyecto.Escuela_BDDDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private cientificaIIProyecto.Escuela_BDDDataSet9TableAdapters.TableAdapterManager tableAdapterManager2;
        private cientificaIIProyecto.Escuela_BDDDataSet9TableAdapters.ProfesionesTableAdapter profesionesTableAdapter2;
        private cientificaIIProyecto.Escuela_BDDDataSet8TableAdapters.TableAdapterManager tableAdapterManager3;
        private cientificaIIProyecto.Escuela_BDDDataSet29 escuela_BDDDataSet29;
        private System.Windows.Forms.BindingSource estadoCivilBindingSource;
        private cientificaIIProyecto.Escuela_BDDDataSet29TableAdapters.Estado_CivilTableAdapter estado_CivilTableAdapter;
        private cientificaIIProyecto.Escuela_BDDDataSet30 escuela_BDDDataSet30;
        private System.Windows.Forms.BindingSource profesionesBindingSource;
        private cientificaIIProyecto.Escuela_BDDDataSet30TableAdapters.ProfesionesTableAdapter profesionesTableAdapter;
    }
}