using Newtonsoft.Json;

namespace Logica_de_Negocio
{
    public class GestorUsuarios
    {
        private readonly List<Usuario> listaDeUsuarios;
        private readonly string pathJson = Path.Combine(Directory.GetCurrentDirectory(), "usuarios.json");

        public GestorUsuarios()
        {
            if (!File.Exists(pathJson))
            {
                // Si no existe el archivo, lo creo vacio
                File.WriteAllText(pathJson, "");
            }

            string json = File.ReadAllText(pathJson);

            if(string.IsNullOrEmpty(json))
            {
                listaDeUsuarios = new List<Usuario>();
            }
            else
            {
                listaDeUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);
            }
        }

        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            foreach (Usuario usuario in listaDeUsuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario)
                {
                    return usuario;
                }
            }
            return null!;
        }

        public void AgregarUsuario(string nombreUsuario, string contrasenia)
        {
            Usuario nuevoUsuario = new Usuario { NombreUsuario = nombreUsuario, Contrasenia = contrasenia };
            listaDeUsuarios.Add(nuevoUsuario);
            GuardarUsuarios();
        }

        public void GuardarUsuarios()
        {
            string jsonCompleto = JsonConvert.SerializeObject(listaDeUsuarios);

            File.WriteAllText(pathJson, jsonCompleto);
        }



    }
}
