using Google.Cloud.Firestore;

namespace Firestore
{
    public class GestorFirestore
    {
        //todo: implementar el resto de los métodos, parametrizar todo lo que se pueda y 

        private readonly FirestoreDb _firestoreDb;
        private readonly CollectionReference _coleccionUsuarios;

        public GestorFirestore()
        {
            _firestoreDb = ConexionFirestore.ObtenerInstanciaFirestore();
            _coleccionUsuarios = _firestoreDb.Collection("Usuarios");
        }

        public async Task<ResultadoOp> CrearUsuarioAsync(string nombre, int contrasenia)
        {
            try
            {
                var nuevoUsuario = new { Nombre = nombre, Contrasenia = contrasenia };
                DocumentReference docRef = _coleccionUsuarios.Document(nombre);

                // Verificar si el usuario ya existe
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    return new ResultadoOp { EsExitoso = false, Datos = $"Usuario con nombre: '{nombre}' ya existe." };
                }

                await docRef.SetAsync(nuevoUsuario);
                return new ResultadoOp { EsExitoso = true, Datos = docRef.Id };
            }
            catch (Exception ex)
            {
                return new ResultadoOp { EsExitoso = false, Datos = ex.Message };
            }
        }

        public async Task<ResultadoOp> ObtenerUsuarioAsync(string usuarioID)
        {
            try
            {
                DocumentSnapshot snapshot = await _coleccionUsuarios.Document(usuarioID).GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    return new ResultadoOp { EsExitoso = true, Datos = snapshot.ToDictionary() };
                }
                else
                {
                    return new ResultadoOp { EsExitoso = false, Datos = $"Usuario con ID: '{usuarioID}' no está funcionando." };
                }
            }
            catch (Exception ex)
            {
                return new ResultadoOp { EsExitoso = false, Datos = ex.Message };
            }
        }

        public async Task<ResultadoOp> ObetenerTodosLosUsuariosAsync()
        {
            try
            {
                QuerySnapshot snapshot = await _coleccionUsuarios.GetSnapshotAsync();
                var usuarios = new List<Dictionary<string, object>>();

                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    var usuarioData = document.ToDictionary();
                    usuarioData.Add("Id", document.Id);
                    usuarios.Add(usuarioData);
                }

                return new ResultadoOp { EsExitoso = true, Datos = usuarios };
            }
            catch (Exception ex)
            {
                return new ResultadoOp { EsExitoso = false, Datos = ex.Message };
            }
        }

        public async Task<ResultadoOp> ActualizarUsuarioAsync(string usuarioID, string nombre, int contrasenia, int dni)
        {
            try
            {
                DocumentReference docRef = _coleccionUsuarios.Document(usuarioID);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    Dictionary<string, object> actualizaciones = new()
                    {
                        { "Nombre", nombre },
                        { "Contrasenia", contrasenia },
                        {"Dni", dni}
                    };

                    await docRef.UpdateAsync(actualizaciones);
                    return new ResultadoOp { EsExitoso = true };
                }
                else
                {
                    return new ResultadoOp { EsExitoso = false, Datos = $"Usuario con ID: '{usuarioID}' no está funcionando." };
                }
            }
            catch (Exception ex)
            {
                return new ResultadoOp { EsExitoso = false, Datos = ex.Message };
            }
        }

        public async Task<ResultadoOp> EliminarUsuarioAsync(string usuarioID)
        {
            try
            {
                DocumentReference docRef = _coleccionUsuarios.Document(usuarioID);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    await docRef.DeleteAsync();
                    return new ResultadoOp { EsExitoso = true };
                }
                else
                {
                    return new ResultadoOp { EsExitoso = false, Datos = $"Usuario con ID: '{usuarioID}' no está funcionando." };
                }
            }
            catch (Exception ex)
            {
                return new ResultadoOp { EsExitoso = false, Datos = ex.Message };
            }
        }


    }
}
