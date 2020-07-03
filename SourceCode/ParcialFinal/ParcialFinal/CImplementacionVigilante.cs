using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialFinal
{
    class CImplementacionVigilante : IBridge
    {
        public void VerRegistro(DataGridView dtv)
        {
        }

        public void RegistroEntradaSalida(string entrada, string fecha, int temperatura, string dui)
        {

            string usuarioID = $"SELECT usuario_id FROM usuario WHERE dui = '{dui}'";
            var dt = ConnectionDB.ExecuteQuery(usuarioID);
            var dr = dt.Rows[0];
            var usuario_id = Convert.ToString(dr[0]);

            string query = "UPDATE registro " +
                                $"SET entrada = {entrada}, " +
                                $"fecha = '{fecha}', " +
                                $"temperatura = {temperatura} " +
                                $"WHERE usuario_id = {usuario_id}";

            try
            {
                ConnectionDB.ExecuteNonQuery(query);

                MessageBox.Show("¡Datos ingresados exitosamente!",
                    "Pre Segundo Examen Parcial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
