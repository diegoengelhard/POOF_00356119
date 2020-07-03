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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string query = $"SELECT count(*) FROM usuario WHERE dui = '{txtDUI.Text}' and contrasena = '{txtContrasena.Text}'";

            var dt = ConnectionDB.ExecuteQuery(query);
            var dr = dt.Rows[0];
            var match = Convert.ToString(dr[0]);

            if (match == "1")
            {
                MessageBox.Show("¡Bienvenido!",
                    "Tercer Examen Parcial", MessageBoxButtons.OK, MessageBoxIcon.Information);


                FormPrincipal ventana = new FormPrincipal(SetUserType());
                ventana.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Los datos ingresados no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string SetUserType()
        {
            string queryEmpleado = $"SELECT count(*) FROM usuario WHERE dui = '{txtDUI.Text}' and contrasena = '{txtContrasena.Text}' " +
                                    $"AND departamento_id = 1";

            string queryAdmin = $"SELECT count(*) FROM usuario WHERE dui = '{txtDUI.Text}' and contrasena = '{txtContrasena.Text}' " +
                                    $"AND departamento_id = 2";

            string queryVigilante = $"SELECT count(*) FROM usuario WHERE dui = '{txtDUI.Text}' and contrasena = '{txtContrasena.Text}' " +
                                    $"AND departamento_id = 3";

            var dt_empleado = ConnectionDB.ExecuteQuery(queryEmpleado);
            var dr_empleado = dt_empleado.Rows[0];
            var empleado = Convert.ToString(dr_empleado[0]);

            var dt_admin = ConnectionDB.ExecuteQuery(queryAdmin);
            var dr_admin = dt_admin.Rows[0];
            var admin = Convert.ToString(dr_admin[0]);

            var dt_vigilante = ConnectionDB.ExecuteQuery(queryVigilante);
            var dr_vigilante = dt_vigilante.Rows[0];
            var vigilante = Convert.ToString(dr_vigilante[0]);

            if (empleado == "1")
                return "e";
            if (admin == "1")
                return "a";
            if (vigilante == "1")
                return "v";
            else
                return "";
        }
    }
}
