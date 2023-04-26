namespace Logica_de_Negocio
{
    public class Usuario
    {
        private string _nombreUsuario;
        private string _contrasenia;

        public string NombreUsuario { get { return _nombreUsuario; } set { _nombreUsuario = value; } }
        public string Contrasenia { get { return _contrasenia; } set { _contrasenia = value; } }
    }
}
