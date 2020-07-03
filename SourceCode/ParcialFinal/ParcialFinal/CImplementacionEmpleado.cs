using System;
using System.Windows.Forms;

namespace ParcialFinal
{
    class CImplementacionEmpleado : IBridge
    {
        public void VerRegistro(DataGridView dtv)
        {
            string query = "SELECT us.nombre, re.entrada, re.fecha, re.temperatura " +
                            "FROM registro re, usuario us " +
                            "WHERE re.usuario_id = us.usuario_id";
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
