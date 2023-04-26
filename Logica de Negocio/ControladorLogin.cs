namespace Logica_de_Negocio
{
    public class ControladorLogin
    {
        private GestorUsuarios gestorUsuarios;

        public ControladorLogin()
        {
            gestorUsuarios = new GestorUsuarios();
        }

        public bool IniciarSesion(string nombreUsuario, string contrasenia)
        {
            // Obtener el usuario correspondiente al nombre de usuario ingresado
            Usuario usuario = gestorUsuarios.ObtenerUsuario(nombreUsuario);

            // Verificar si el usuario existe
            if (usuario != null)
            {
                // Verificar si la contraseña es correcta
                if (usuario.Contrasenia == contrasenia)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                // Si el usuario no existe, crear uno nuevo y guardarlo en la lista
                gestorUsuarios.AgregarUsuario(nombreUsuario, contrasenia);
                return true;
            }
        }

        
       
    }
}
