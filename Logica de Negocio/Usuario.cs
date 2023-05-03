using Google.Cloud.Firestore;

namespace Logica_de_Negocio
{
    public class Usuario
    {
        private string _nombreUsuario;
        private string _contrasenia;
        private string _dni;


        public string NombreUsuario { get { return _nombreUsuario; } set { _nombreUsuario = value; } }
        public string Contrasenia { get { return _contrasenia; } set { _contrasenia = value; } }
        public string Dni { get { return _dni; } set { _dni = value; } }

    }
}
