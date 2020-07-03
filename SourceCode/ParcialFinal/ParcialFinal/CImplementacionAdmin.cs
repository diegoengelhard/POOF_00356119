using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialFinal
{
    class CImplementacionAdmin : IBridge
    {
        public void VerRegistro(DataGridView dtv)
        {
            string query = "SELECT us.nombre, re.entrada, re.fecha, re.temperatura " +
                            "FROM registro re, usuario us";
            try
            {
                var dt = ConnectionDB.ExecuteQuery(query);

                dtv.DataSource = dt;

                MessageBox.Show("¡Datos obtenidos exitosamente!",
                    "Tercer Examen Parcial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AgregarUsuario(int departamento, string nombre, string apellido, string dui, string contrasena,
               string fecha)
        {

            string NonQuery = "INSERT INTO usuario(nombre, apellido, dui, contrasena, fechaNacimiento, departamento_id) " +
                    $"VALUES('{nombre}', '{apellido}', '{dui}', '{contrasena}', " +
                    $"'{fecha}', {departamento})";

            try
            {
                ConnectionDB.ExecuteNonQuery(NonQuery);

                MessageBox.Show("¡Usuario agregado exitosamente!",
                    "Tercer Examen Parcial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string query = $"SELECT usuario_id FROM usuario WHERE dui = '{dui}'";

            var dt = ConnectionDB.ExecuteQuery(query);
            var dr = dt.Rows[0];
            var usuario_id = Convert.ToString(dr[0]);

            string NonQuery1 = "INSERT INTO registro(entrada, fecha, temperatura, usuario_id) " +
                                $"VALUES(false, NULL, NULL, {usuario_id})";

            ConnectionDB.ExecuteNonQuery(NonQuery1);
        }

        public void EliminarUsuario(string dui)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar al usuario especificado?",
            "Tercer Examen Parcial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string NonQuery = $"DELETE FROM usuario WHERE dui = '{dui}'";

                ConnectionDB.ExecuteNonQuery(NonQuery);

                MessageBox.Show("¡Usuario eliminado exitosamente!",
                    "Pre Segundo Examen Parcial 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void VerEmpleadosDentroEmpresa(DataGridView dtv)
        {
            string query = "SELECT us.nombre, re.entrada, re.fecha, re.temperatura " +
                            "FROM registro re, usuario us " +
                            "WHERE re.entrada = true";
            try
            {
                var dt = ConnectionDB.ExecuteQuery(query);

                dtv.DataSource = dt;

                MessageBox.Show("¡Datos obtenidos exitosamente!",
                    "Pre Segundo Examen Parcial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VerDepartamentoMasConcurrido(DataGridView dtv)
        {
            string query = "SELECT d.nombre, count(u.departamento_id) as frecuencia " +
                "FROM REGISTRO r, DEPARTAMENTO d, USUARIO u " +
                "WHERE r.usuario_id = u.usuario_id AND d.departamento_id = u.departamento_id " +
                "GROUP BY d.departamento_id " +
                "ORDER BY frecuencia DESC LIMIT 1;";
            try
            {
                var dt = ConnectionDB.ExecuteQuery(query);

                dtv.DataSource = dt;

                MessageBox.Show("¡Datos obtenidos exitosamente!",
                    "Pre Segundo Examen Parcial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
