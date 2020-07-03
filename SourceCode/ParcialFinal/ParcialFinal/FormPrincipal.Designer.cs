namespace ParcialFinal
{
    partial class FormPrincipal
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.AgregarUsuario = new System.Windows.Forms.TabPage();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.btnClean_AddUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.EliminarUsuario = new System.Windows.Forms.TabPage();
            this.txtEliminarDUI = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpleadosEnEmpresa = new System.Windows.Forms.TabPage();
            this.btnVerEmpleadosDentroEmpresa = new System.Windows.Forms.Button();
            this.dgvEmpleadosDentroEmpresa = new System.Windows.Forms.DataGridView();
            this.DepartamentoMasConcurrido = new System.Windows.Forms.TabPage();
            this.btnDepartamentoMasConcurrido = new System.Windows.Forms.Button();
            this.dgvDepartamentoMasConcurrido = new System.Windows.Forms.DataGridView();
            this.RegistroGeneral = new System.Windows.Forms.TabPage();
            this.btnVerRegistroGeneral = new System.Windows.Forms.Button();
            this.dgvRegistroGeneral = new System.Windows.Forms.DataGridView();
            this.RegistroEmpleado = new System.Windows.Forms.TabPage();
            this.cmbDUI_Registro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVerRegistroEmpleado = new System.Windows.Forms.Button();
            this.dgvRegistroEmpleado = new System.Windows.Forms.DataGridView();
            this.RegistroEntradaSalida = new System.Windows.Forms.TabPage();
            this.cmbDUI = new System.Windows.Forms.ComboBox();
            this.txtHoraEntradaSalida = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEstadoEntrada = new System.Windows.Forms.ComboBox();
            this.btnRegistroVigilante = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaEntradaSalida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudTemperatura = new System.Windows.Forms.NumericUpDown();
            this.TabControl.SuspendLayout();
            this.AgregarUsuario.SuspendLayout();
            this.EliminarUsuario.SuspendLayout();
            this.EmpleadosEnEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosDentroEmpresa)).BeginInit();
            this.DepartamentoMasConcurrido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentoMasConcurrido)).BeginInit();
            this.RegistroGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroGeneral)).BeginInit();
            this.RegistroEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroEmpleado)).BeginInit();
            this.RegistroEntradaSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.AgregarUsuario);
            this.TabControl.Controls.Add(this.EliminarUsuario);
            this.TabControl.Controls.Add(this.EmpleadosEnEmpresa);
            this.TabControl.Controls.Add(this.DepartamentoMasConcurrido);
            this.TabControl.Controls.Add(this.RegistroGeneral);
            this.TabControl.Controls.Add(this.RegistroEmpleado);
            this.TabControl.Controls.Add(this.RegistroEntradaSalida);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(983, 731);
            this.TabControl.TabIndex = 0;
            // 
            // AgregarUsuario
            // 
            this.AgregarUsuario.Controls.Add(this.cmbDepartamento);
            this.AgregarUsuario.Controls.Add(this.label5);
            this.AgregarUsuario.Controls.Add(this.label6);
            this.AgregarUsuario.Controls.Add(this.txtFechaNacimiento);
            this.AgregarUsuario.Controls.Add(this.txtContrasena);
            this.AgregarUsuario.Controls.Add(this.label3);
            this.AgregarUsuario.Controls.Add(this.label4);
            this.AgregarUsuario.Controls.Add(this.txtDUI);
            this.AgregarUsuario.Controls.Add(this.btnClean_AddUser);
            this.AgregarUsuario.Controls.Add(this.btnAddUser);
            this.AgregarUsuario.Controls.Add(this.txtApellido);
            this.AgregarUsuario.Controls.Add(this.label1);
            this.AgregarUsuario.Controls.Add(this.label2);
            this.AgregarUsuario.Controls.Add(this.txtNombre);
            this.AgregarUsuario.Location = new System.Drawing.Point(8, 39);
            this.AgregarUsuario.Name = "AgregarUsuario";
            this.AgregarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.AgregarUsuario.Size = new System.Drawing.Size(967, 684);
            this.AgregarUsuario.TabIndex = 0;
            this.AgregarUsuario.Text = "Agregar Usuario";
            this.AgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Items.AddRange(new object[] {
            "Empleado",
            "Administrador",
            "Vigilante"});
            this.cmbDepartamento.Location = new System.Drawing.Point(421, 367);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(267, 33);
            this.cmbDepartamento.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(202, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 42);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fecha Nacimiento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(242, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 42);
            this.label6.TabIndex = 28;
            this.label6.Text = "Departamento:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(421, 316);
            this.txtFechaNacimiento.Margin = new System.Windows.Forms.Padding(5);
            this.txtFechaNacimiento.MaxLength = 25;
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(261, 31);
            this.txtFechaNacimiento.TabIndex = 27;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(422, 262);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(5);
            this.txtContrasena.MaxLength = 25;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(261, 31);
            this.txtContrasena.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(277, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 42);
            this.label3.TabIndex = 22;
            this.label3.Text = "DUI:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(260, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 42);
            this.label4.TabIndex = 24;
            this.label4.Text = "Contrasena:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(422, 208);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(5);
            this.txtDUI.MaxLength = 25;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(261, 31);
            this.txtDUI.TabIndex = 23;
            // 
            // btnClean_AddUser
            // 
            this.btnClean_AddUser.Location = new System.Drawing.Point(467, 480);
            this.btnClean_AddUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnClean_AddUser.Name = "btnClean_AddUser";
            this.btnClean_AddUser.Size = new System.Drawing.Size(221, 45);
            this.btnClean_AddUser.TabIndex = 21;
            this.btnClean_AddUser.Text = "Limpiar";
            this.btnClean_AddUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(202, 480);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(221, 45);
            this.btnAddUser.TabIndex = 20;
            this.btnAddUser.Text = "Agregar Usuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(422, 153);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(5);
            this.txtApellido.MaxLength = 25;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(261, 31);
            this.txtApellido.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(277, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(260, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 42);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellido:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(422, 99);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 31);
            this.txtNombre.TabIndex = 17;
            // 
            // EliminarUsuario
            // 
            this.EliminarUsuario.Controls.Add(this.txtEliminarDUI);
            this.EliminarUsuario.Controls.Add(this.btnDeleteUser);
            this.EliminarUsuario.Controls.Add(this.label7);
            this.EliminarUsuario.Location = new System.Drawing.Point(8, 39);
            this.EliminarUsuario.Name = "EliminarUsuario";
            this.EliminarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.EliminarUsuario.Size = new System.Drawing.Size(967, 684);
            this.EliminarUsuario.TabIndex = 1;
            this.EliminarUsuario.Text = "Eliminar Usuario";
            this.EliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // txtEliminarDUI
            // 
            this.txtEliminarDUI.Location = new System.Drawing.Point(313, 296);
            this.txtEliminarDUI.Margin = new System.Windows.Forms.Padding(5);
            this.txtEliminarDUI.MaxLength = 25;
            this.txtEliminarDUI.Name = "txtEliminarDUI";
            this.txtEliminarDUI.Size = new System.Drawing.Size(303, 31);
            this.txtEliminarDUI.TabIndex = 26;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteUser.Location = new System.Drawing.Point(642, 287);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(221, 45);
            this.btnDeleteUser.TabIndex = 14;
            this.btnDeleteUser.Text = "Eliminar";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(125, 296);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 45);
            this.label7.TabIndex = 12;
            this.label7.Text = "DUI del Usuario:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EmpleadosEnEmpresa
            // 
            this.EmpleadosEnEmpresa.Controls.Add(this.btnVerEmpleadosDentroEmpresa);
            this.EmpleadosEnEmpresa.Controls.Add(this.dgvEmpleadosDentroEmpresa);
            this.EmpleadosEnEmpresa.Location = new System.Drawing.Point(8, 39);
            this.EmpleadosEnEmpresa.Name = "EmpleadosEnEmpresa";
            this.EmpleadosEnEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.EmpleadosEnEmpresa.Size = new System.Drawing.Size(967, 684);
            this.EmpleadosEnEmpresa.TabIndex = 2;
            this.EmpleadosEnEmpresa.Text = "Empleados en Empresa";
            this.EmpleadosEnEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnVerEmpleadosDentroEmpresa
            // 
            this.btnVerEmpleadosDentroEmpresa.Location = new System.Drawing.Point(407, 614);
            this.btnVerEmpleadosDentroEmpresa.Margin = new System.Windows.Forms.Padding(5);
            this.btnVerEmpleadosDentroEmpresa.Name = "btnVerEmpleadosDentroEmpresa";
            this.btnVerEmpleadosDentroEmpresa.Size = new System.Drawing.Size(143, 57);
            this.btnVerEmpleadosDentroEmpresa.TabIndex = 29;
            this.btnVerEmpleadosDentroEmpresa.Text = "Ver Datos";
            this.btnVerEmpleadosDentroEmpresa.UseVisualStyleBackColor = true;
            this.btnVerEmpleadosDentroEmpresa.Click += new System.EventHandler(this.btnVerEmpleadosDentroEmpresa_Click);
            // 
            // dgvEmpleadosDentroEmpresa
            // 
            this.dgvEmpleadosDentroEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosDentroEmpresa.Location = new System.Drawing.Point(6, 5);
            this.dgvEmpleadosDentroEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmpleadosDentroEmpresa.Name = "dgvEmpleadosDentroEmpresa";
            this.dgvEmpleadosDentroEmpresa.RowHeadersWidth = 82;
            this.dgvEmpleadosDentroEmpresa.RowTemplate.Height = 33;
            this.dgvEmpleadosDentroEmpresa.Size = new System.Drawing.Size(955, 588);
            this.dgvEmpleadosDentroEmpresa.TabIndex = 28;
            // 
            // DepartamentoMasConcurrido
            // 
            this.DepartamentoMasConcurrido.Controls.Add(this.btnDepartamentoMasConcurrido);
            this.DepartamentoMasConcurrido.Controls.Add(this.dgvDepartamentoMasConcurrido);
            this.DepartamentoMasConcurrido.Location = new System.Drawing.Point(8, 39);
            this.DepartamentoMasConcurrido.Name = "DepartamentoMasConcurrido";
            this.DepartamentoMasConcurrido.Padding = new System.Windows.Forms.Padding(3);
            this.DepartamentoMasConcurrido.Size = new System.Drawing.Size(967, 684);
            this.DepartamentoMasConcurrido.TabIndex = 3;
            this.DepartamentoMasConcurrido.Text = "DepartamentoMasConcurrido";
            this.DepartamentoMasConcurrido.UseVisualStyleBackColor = true;
            // 
            // btnDepartamentoMasConcurrido
            // 
            this.btnDepartamentoMasConcurrido.Location = new System.Drawing.Point(437, 619);
            this.btnDepartamentoMasConcurrido.Margin = new System.Windows.Forms.Padding(5);
            this.btnDepartamentoMasConcurrido.Name = "btnDepartamentoMasConcurrido";
            this.btnDepartamentoMasConcurrido.Size = new System.Drawing.Size(143, 57);
            this.btnDepartamentoMasConcurrido.TabIndex = 31;
            this.btnDepartamentoMasConcurrido.Text = "Ver Datos";
            this.btnDepartamentoMasConcurrido.UseVisualStyleBackColor = true;
            this.btnDepartamentoMasConcurrido.Click += new System.EventHandler(this.btnDepartamentoMasConcurrido_Click);
            // 
            // dgvDepartamentoMasConcurrido
            // 
            this.dgvDepartamentoMasConcurrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentoMasConcurrido.Location = new System.Drawing.Point(6, 15);
            this.dgvDepartamentoMasConcurrido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDepartamentoMasConcurrido.Name = "dgvDepartamentoMasConcurrido";
            this.dgvDepartamentoMasConcurrido.RowHeadersWidth = 82;
            this.dgvDepartamentoMasConcurrido.RowTemplate.Height = 33;
            this.dgvDepartamentoMasConcurrido.Size = new System.Drawing.Size(961, 597);
            this.dgvDepartamentoMasConcurrido.TabIndex = 30;
            // 
            // RegistroGeneral
            // 
            this.RegistroGeneral.Controls.Add(this.btnVerRegistroGeneral);
            this.RegistroGeneral.Controls.Add(this.dgvRegistroGeneral);
            this.RegistroGeneral.Location = new System.Drawing.Point(8, 39);
            this.RegistroGeneral.Name = "RegistroGeneral";
            this.RegistroGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.RegistroGeneral.Size = new System.Drawing.Size(967, 684);
            this.RegistroGeneral.TabIndex = 4;
            this.RegistroGeneral.Text = "Registro General";
            this.RegistroGeneral.UseVisualStyleBackColor = true;
            // 
            // btnVerRegistroGeneral
            // 
            this.btnVerRegistroGeneral.Location = new System.Drawing.Point(419, 619);
            this.btnVerRegistroGeneral.Margin = new System.Windows.Forms.Padding(5);
            this.btnVerRegistroGeneral.Name = "btnVerRegistroGeneral";
            this.btnVerRegistroGeneral.Size = new System.Drawing.Size(143, 57);
            this.btnVerRegistroGeneral.TabIndex = 33;
            this.btnVerRegistroGeneral.Text = "Ver Datos";
            this.btnVerRegistroGeneral.UseVisualStyleBackColor = true;
            this.btnVerRegistroGeneral.Click += new System.EventHandler(this.btnVerRegistroGeneral_Click);
            // 
            // dgvRegistroGeneral
            // 
            this.dgvRegistroGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroGeneral.Location = new System.Drawing.Point(6, 15);
            this.dgvRegistroGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRegistroGeneral.Name = "dgvRegistroGeneral";
            this.dgvRegistroGeneral.RowHeadersWidth = 82;
            this.dgvRegistroGeneral.RowTemplate.Height = 33;
            this.dgvRegistroGeneral.Size = new System.Drawing.Size(955, 597);
            this.dgvRegistroGeneral.TabIndex = 32;
            // 
            // RegistroEmpleado
            // 
            this.RegistroEmpleado.Controls.Add(this.cmbDUI_Registro);
            this.RegistroEmpleado.Controls.Add(this.label8);
            this.RegistroEmpleado.Controls.Add(this.btnVerRegistroEmpleado);
            this.RegistroEmpleado.Controls.Add(this.dgvRegistroEmpleado);
            this.RegistroEmpleado.Location = new System.Drawing.Point(8, 39);
            this.RegistroEmpleado.Name = "RegistroEmpleado";
            this.RegistroEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.RegistroEmpleado.Size = new System.Drawing.Size(967, 684);
            this.RegistroEmpleado.TabIndex = 5;
            this.RegistroEmpleado.Text = "Registro Empleado";
            this.RegistroEmpleado.UseVisualStyleBackColor = true;
            // 
            // cmbDUI_Registro
            // 
            this.cmbDUI_Registro.FormattingEnabled = true;
            this.cmbDUI_Registro.Location = new System.Drawing.Point(300, 47);
            this.cmbDUI_Registro.Name = "cmbDUI_Registro";
            this.cmbDUI_Registro.Size = new System.Drawing.Size(299, 33);
            this.cmbDUI_Registro.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(167, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 42);
            this.label8.TabIndex = 36;
            this.label8.Text = "DUI:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnVerRegistroEmpleado
            // 
            this.btnVerRegistroEmpleado.Location = new System.Drawing.Point(626, 34);
            this.btnVerRegistroEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.btnVerRegistroEmpleado.Name = "btnVerRegistroEmpleado";
            this.btnVerRegistroEmpleado.Size = new System.Drawing.Size(143, 57);
            this.btnVerRegistroEmpleado.TabIndex = 35;
            this.btnVerRegistroEmpleado.Text = "Ver Datos";
            this.btnVerRegistroEmpleado.UseVisualStyleBackColor = true;
            this.btnVerRegistroEmpleado.Click += new System.EventHandler(this.btnVerRegistroEmpleado_Click);
            // 
            // dgvRegistroEmpleado
            // 
            this.dgvRegistroEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroEmpleado.Location = new System.Drawing.Point(20, 114);
            this.dgvRegistroEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRegistroEmpleado.Name = "dgvRegistroEmpleado";
            this.dgvRegistroEmpleado.RowHeadersWidth = 82;
            this.dgvRegistroEmpleado.RowTemplate.Height = 33;
            this.dgvRegistroEmpleado.Size = new System.Drawing.Size(926, 547);
            this.dgvRegistroEmpleado.TabIndex = 34;
            // 
            // RegistroEntradaSalida
            // 
            this.RegistroEntradaSalida.Controls.Add(this.nudTemperatura);
            this.RegistroEntradaSalida.Controls.Add(this.cmbDUI);
            this.RegistroEntradaSalida.Controls.Add(this.txtHoraEntradaSalida);
            this.RegistroEntradaSalida.Controls.Add(this.label13);
            this.RegistroEntradaSalida.Controls.Add(this.cmbEstadoEntrada);
            this.RegistroEntradaSalida.Controls.Add(this.btnRegistroVigilante);
            this.RegistroEntradaSalida.Controls.Add(this.label9);
            this.RegistroEntradaSalida.Controls.Add(this.label10);
            this.RegistroEntradaSalida.Controls.Add(this.txtFechaEntradaSalida);
            this.RegistroEntradaSalida.Controls.Add(this.label11);
            this.RegistroEntradaSalida.Controls.Add(this.label12);
            this.RegistroEntradaSalida.Location = new System.Drawing.Point(8, 39);
            this.RegistroEntradaSalida.Name = "RegistroEntradaSalida";
            this.RegistroEntradaSalida.Padding = new System.Windows.Forms.Padding(3);
            this.RegistroEntradaSalida.Size = new System.Drawing.Size(967, 684);
            this.RegistroEntradaSalida.TabIndex = 6;
            this.RegistroEntradaSalida.Text = "Registro Entrada/Salida";
            this.RegistroEntradaSalida.UseVisualStyleBackColor = true;
            // 
            // cmbDUI
            // 
            this.cmbDUI.FormattingEnabled = true;
            this.cmbDUI.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmbDUI.Location = new System.Drawing.Point(435, 416);
            this.cmbDUI.Name = "cmbDUI";
            this.cmbDUI.Size = new System.Drawing.Size(261, 33);
            this.cmbDUI.TabIndex = 38;
            // 
            // txtHoraEntradaSalida
            // 
            this.txtHoraEntradaSalida.Location = new System.Drawing.Point(435, 307);
            this.txtHoraEntradaSalida.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoraEntradaSalida.MaxLength = 25;
            this.txtHoraEntradaSalida.Name = "txtHoraEntradaSalida";
            this.txtHoraEntradaSalida.Size = new System.Drawing.Size(261, 31);
            this.txtHoraEntradaSalida.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(162, 307);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 42);
            this.label13.TabIndex = 36;
            this.label13.Text = "Hora de Entrada/Salida";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbEstadoEntrada
            // 
            this.cmbEstadoEntrada.FormattingEnabled = true;
            this.cmbEstadoEntrada.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmbEstadoEntrada.Location = new System.Drawing.Point(434, 204);
            this.cmbEstadoEntrada.Name = "cmbEstadoEntrada";
            this.cmbEstadoEntrada.Size = new System.Drawing.Size(261, 33);
            this.cmbEstadoEntrada.TabIndex = 35;
            // 
            // btnRegistroVigilante
            // 
            this.btnRegistroVigilante.Location = new System.Drawing.Point(405, 486);
            this.btnRegistroVigilante.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistroVigilante.Name = "btnRegistroVigilante";
            this.btnRegistroVigilante.Size = new System.Drawing.Size(221, 45);
            this.btnRegistroVigilante.TabIndex = 34;
            this.btnRegistroVigilante.Text = "Actualizar Registro";
            this.btnRegistroVigilante.UseVisualStyleBackColor = true;
            this.btnRegistroVigilante.Click += new System.EventHandler(this.btnRegistroVigilante_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(243, 362);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 42);
            this.label9.TabIndex = 30;
            this.label9.Text = "Temperatura:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(272, 416);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 42);
            this.label10.TabIndex = 32;
            this.label10.Text = "DUI:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFechaEntradaSalida
            // 
            this.txtFechaEntradaSalida.Location = new System.Drawing.Point(434, 258);
            this.txtFechaEntradaSalida.Margin = new System.Windows.Forms.Padding(5);
            this.txtFechaEntradaSalida.MaxLength = 25;
            this.txtFechaEntradaSalida.Name = "txtFechaEntradaSalida";
            this.txtFechaEntradaSalida.Size = new System.Drawing.Size(261, 31);
            this.txtFechaEntradaSalida.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(197, 204);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 42);
            this.label11.TabIndex = 26;
            this.label11.Text = "Estado de entrada:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(158, 258);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 42);
            this.label12.TabIndex = 28;
            this.label12.Text = "Fecha de Entrada/Salida";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudTemperatura
            // 
            this.nudTemperatura.Location = new System.Drawing.Point(435, 360);
            this.nudTemperatura.Name = "nudTemperatura";
            this.nudTemperatura.Size = new System.Drawing.Size(261, 31);
            this.nudTemperatura.TabIndex = 39;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 755);
            this.Controls.Add(this.TabControl);
            this.Name = "FormPrincipal";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.TabControl.ResumeLayout(false);
            this.AgregarUsuario.ResumeLayout(false);
            this.AgregarUsuario.PerformLayout();
            this.EliminarUsuario.ResumeLayout(false);
            this.EliminarUsuario.PerformLayout();
            this.EmpleadosEnEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosDentroEmpresa)).EndInit();
            this.DepartamentoMasConcurrido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentoMasConcurrido)).EndInit();
            this.RegistroGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroGeneral)).EndInit();
            this.RegistroEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroEmpleado)).EndInit();
            this.RegistroEntradaSalida.ResumeLayout(false);
            this.RegistroEntradaSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage AgregarUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TabPage EliminarUsuario;
        private System.Windows.Forms.TabPage EmpleadosEnEmpresa;
        private System.Windows.Forms.TabPage DepartamentoMasConcurrido;
        private System.Windows.Forms.Button btnClean_AddUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtEliminarDUI;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVerEmpleadosDentroEmpresa;
        private System.Windows.Forms.DataGridView dgvEmpleadosDentroEmpresa;
        private System.Windows.Forms.Button btnDepartamentoMasConcurrido;
        private System.Windows.Forms.DataGridView dgvDepartamentoMasConcurrido;
        private System.Windows.Forms.TabPage RegistroGeneral;
        private System.Windows.Forms.Button btnVerRegistroGeneral;
        private System.Windows.Forms.DataGridView dgvRegistroGeneral;
        private System.Windows.Forms.TabPage RegistroEmpleado;
        private System.Windows.Forms.Button btnVerRegistroEmpleado;
        private System.Windows.Forms.DataGridView dgvRegistroEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage RegistroEntradaSalida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFechaEntradaSalida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRegistroVigilante;
        private System.Windows.Forms.TextBox txtHoraEntradaSalida;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbEstadoEntrada;
        private System.Windows.Forms.ComboBox cmbDUI;
        private System.Windows.Forms.ComboBox cmbDUI_Registro;
        private System.Windows.Forms.NumericUpDown nudTemperatura;
    }
}