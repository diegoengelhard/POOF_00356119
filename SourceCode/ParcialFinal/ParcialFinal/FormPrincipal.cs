using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialFinal
{
    public partial class FormPrincipal : Form
    {

        CAbstraccion administrador = new CAbstraccion(new CImplementacionAdmin());
        CAbstraccion empleado = new CAbstraccion(new CImplementacionEmpleado());

        CImplementacionAdmin admin = new CImplementacionAdmin();
        CImplementacionVigilante vigilante = new CImplementacionVigilante();

        private string userType;
        public FormPrincipal(string userType)
        {
            InitializeComponent();

            this.userType = userType;
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (userType == "e")
            {
                TabControl.TabPages.Remove(AgregarUsuario);
                TabControl.TabPages.Remove(EliminarUsuario);
                TabControl.TabPages.Remove(EmpleadosEnEmpresa);
                TabControl.TabPages.Remove(DepartamentoMasConcurrido);
                TabControl.TabPages.Remove(RegistroGeneral);
                TabControl.TabPages.Remove(RegistroEntradaSalida);
            }

            if (userType == "a")
            {
                TabControl.TabPages.Remove(RegistroEntradaSalida);
                TabControl.TabPages.Remove(RegistroEmpleado);
            }

            if(userType == "v")
            {
                TabControl.TabPages.Remove(AgregarUsuario);
                TabControl.TabPages.Remove(EliminarUsuario);
                TabControl.TabPages.Remove(EmpleadosEnEmpresa);
                TabControl.TabPages.Remove(DepartamentoMasConcurrido);
                TabControl.TabPages.Remove(RegistroGeneral);
                TabControl.TabPages.Remove(RegistroEmpleado);
            }

            var users = ConnectionDB.ExecuteQuery("SELECT dui FROM usuario");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }

            cmbDUI.DataSource = usersCombo;
            cmbDUI_Registro.DataSource = usersCombo;

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int departamento = 0;

            if (cmbDepartamento.SelectedItem.ToString() == "Empleado")
                departamento = 1;
            if (cmbDepartamento.SelectedItem.ToString() == "Aministrador")
                departamento = 2;
            if (cmbDepartamento.SelectedItem.ToString() == "Vigilante")
                departamento = 3;

            admin.AgregarUsuario(departamento, txtNombre.Text, txtApellido.Text, txtDUI.Text,
                txtContrasena.Text, txtFechaNacimiento.Text);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            admin.EliminarUsuario(txtEliminarDUI.Text);
        }

        private void btnVerEmpleadosDentroEmpresa_Click(object sender, EventArgs e)
        {
            admin.VerEmpleadosDentroEmpresa(dgvEmpleadosDentroEmpresa);
        }

        private void btnDepartamentoMasConcurrido_Click(object sender, EventArgs e)
        {
            admin.VerDepartamentoMasConcurrido(dgvDepartamentoMasConcurrido);
        }

        private void btnVerRegistroGeneral_Click(object sender, EventArgs e)
        {
            administrador.VerRegistro(dgvRegistroGeneral);
        }

        private void btnVerRegistroEmpleado_Click(object sender, EventArgs e)
        {
            empleado.VerRegistro(dgvRegistroEmpleado);
        }

        private void btnRegistroVigilante_Click(object sender, EventArgs e)
        {
            string usuarioID = $"SELECT usuario_id FROM usuario WHERE dui = '{cmbDUI.SelectedItem}'";
            var dt = ConnectionDB.ExecuteQuery(usuarioID);
            var dr = dt.Rows[0];
            var usuario_id = Convert.ToString(dr[0]);

            string fecha = txtFechaEntradaSalida.Text;
            string hora = txtHoraEntradaSalida.Text;

            string fechaHoraYSalida = fecha + " " + hora;

            vigilante.RegistroEntradaSalida(cmbEstadoEntrada.SelectedItem.ToString(), fechaHoraYSalida, (int)(nudTemperatura.Value), cmbDUI.SelectedItem.ToString());e ;
        }
    }
}
