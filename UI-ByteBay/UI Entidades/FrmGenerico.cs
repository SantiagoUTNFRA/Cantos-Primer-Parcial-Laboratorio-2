// Clase padre para establecer algunas propiedades y comportamientos.

namespace UI_ByteBay.UI_Entidades
{
    public partial class FrmGenerico : Form
    {
        // Crear un método virtual para crear instancias de formularios específicos
        public virtual Form CrearFormularioEspecifico()
        {
            return null!; // Debe anularse en el formulario específico
        }

        public FrmGenerico()
        {
            // Establecer algunas propiedades comunes
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
        }

        //TODO: modificar todo lo que devuelve el override de cada formulario que hereda de FrmGenerico.
    }
}
