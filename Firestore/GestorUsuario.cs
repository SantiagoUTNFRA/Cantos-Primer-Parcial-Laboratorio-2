namespace Firestore
{
    public class GestorUsuario : GestorFirestoreBase
    {
        public GestorUsuario() : base("Usuarios") { }

        public async Task<ResultadoOp> CrearUsuarioAsync(string nombre, string contrasenia)
        {
            var nuevoUsuario = new { Nombre = nombre, Contrasenia = contrasenia };
            return await CrearEntidadAsync(nuevoUsuario, nombre);
        }

        public async Task<ResultadoOp> ObtenerUsuarioAsync(string id)
        {
            return await ObtenerEntidadAsync(id);
        }

        public async Task<ResultadoOp> EsCredencialValidaAsync(string nombreUsuario, string contrasenia)
        {
            var resultado = await ObtenerUsuarioAsync(nombreUsuario);

            if (resultado.EsExitoso)
            {
                if (resultado.Datos is Dictionary<string, object> datosUsuario && datosUsuario.ContainsKey("Contrasenia") && (string)datosUsuario["Contrasenia"] == contrasenia)
                {
                    return new ResultadoOp { EsExitoso = true };
                }
            }

            return new ResultadoOp { EsExitoso = false, Datos = "Nombre de usuario o contraseña incorrectos." };
        }

        public override async Task<ResultadoOp> CrearEntidadAsync(object entidad, string? docId = null)
        {
            try
            {
                if (await ExisteAsync(docId))
                {
                    return new ResultadoOp { EsExitoso = false, Datos = $"El usuario '{docId}' ya existe en el sistema" };
                }

                var docIdResult = await base.CrearEntidadAsync(entidad, docId);
                return new ResultadoOp { EsExitoso = true, Datos = docIdResult };
            }
            catch (Exception ex)
            {
                return new ResultadoOp { EsExitoso = false, Datos = ex.Message };
            }
        }

        public override async Task<ResultadoOp> ObtenerEntidadAsync(string id)
        {
            try
            {
                var usuario = await base.ObtenerEntidadAsync(id);
                if (usuario.EsExitoso)
                {
                    var usuarioDict = usuario.Datos as Dictionary<string, object>;

                    if (usuarioDict != null && usuarioDict.ContainsKey("Contrasenia"))
                    {
                        usuarioDict["Contrasenia"] = usuarioDict["Contrasenia"].ToString();
                    }

                    return new ResultadoOp { EsExitoso = true, Datos = usuarioDict };
                }
                else
                {
                    return new ResultadoOp { EsExitoso = false, Datos = $"El usuario '{id}' no existe." };
                }
            }
            catch (Exception ex)
            {
                return new ResultadoOp { EsExitoso = false, Datos = ex.Message };
            }
        }
    }
}