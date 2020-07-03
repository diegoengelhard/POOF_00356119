using System.Windows.Forms;


namespace ParcialFinal
{
    class CAbstraccion
    {
        IBridge implementacion;

        public CAbstraccion(IBridge implementacion)
        {
            this.implementacion = implementacion;
        }

        public void VerRegistro(DataGridView dtv)
        {
            implementacion.VerRegistro(dtv);
        }
    }
}
