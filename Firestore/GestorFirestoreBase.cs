using Google.Cloud.Firestore;

namespace Firestore
{
    public abstract class GestorFirestoreBase
    {

        private readonly FirestoreDb _firestoreDb;
        private readonly CollectionReference _coleccion;

        public GestorFirestoreBase(string nombreColeccion)
        {
            _firestoreDb = ConexionFirestore.ObtenerInstanciaFirestore();
            _coleccion = _firestoreDb.Collection(nombreColeccion);
        }

        public virtual async Task<ResultadoOp> CrearEntidadAsync(object entidad, string? docId = null)
        {
            try
            {
                string id = await CrearDocumentoAsync(entidad, docId);
                return new ResultadoOp { EsExitoso = true, Datos = id };
            }
            catch (Exception ex)
            {
                return new ResultadoOp { EsExitoso = false, Datos = ex.Message };
            }
        }

        public virtual async Task<ResultadoOp> ObtenerEntidadAsync(string id)
        {
            try
            {
                var entidad = await ObtenerDocumentoAsync(id);
                return entidad != null ? new ResultadoOp { EsExitoso = true, Datos = (Dictionary<string, object>)entidad } : new ResultadoOp { EsExitoso = false, Datos = $"La entidad con ID '{id}' no existe." };
            }
            catch (Exception ex)
            {
                return new ResultadoOp { EsExitoso = false, Datos = ex.Message };
            }
        }

        public virtual async Task<ResultadoOp> ActualizarEntidadAsync(string id, object entidad)
        {
            try
            {
                if (!await ExisteAsync(id))
                {
                    return new ResultadoOp { EsExitoso = false, Datos = $"La entidad con ID '{id}' no existe en el sistema" };
                }
                await ActualizarDocumentoAsync(id, entidad);
                return new ResultadoOp { EsExitoso = true, Datos = $"La entidad con ID '{id}' ha sido actualizada" };
            }
            catch (Exception ex)
            {
                return new ResultadoOp { EsExitoso = false, Datos = ex.Message };
            }
        }

        public virtual async Task<ResultadoOp> EliminarEntidadAsync(string id)
        {
            try
            {
                if (!await ExisteAsync(id))
                {
                    return new ResultadoOp { EsExitoso = false, Datos = $"La entidad con ID '{id}' no existe en el sistema" };
                }
                await EliminarDocumentoAsync(id);
                return new ResultadoOp { EsExitoso = true, Datos = $"La entidad con ID '{id}' ha sido eliminada" };
            }
            catch (Exception ex)
            {
                return new ResultadoOp { EsExitoso = false, Datos = ex.Message };
            }
        }

        private async Task<string> CrearDocumentoAsync(object objeto, string? docId = null)
        {
            DocumentReference docRef;

            if (string.IsNullOrEmpty(docId))
            {
                docRef = await _coleccion.AddAsync(objeto);
            }
            else
            {
                docRef = _coleccion.Document(docId);
                await docRef.SetAsync(objeto);
            }

            return docRef.Id;
        }

        private async Task<object> ObtenerDocumentoAsync(string id)
        {
            var docRef = _coleccion.Document(id);
            var snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                return snapshot.ToDictionary();
            }
            else
            {
                return null!;
            }
        }

        private async Task ActualizarDocumentoAsync(string id, object objeto)
        {
            var docRef = _coleccion.Document(id);
            await docRef.SetAsync(objeto);
        }

        private async Task EliminarDocumentoAsync(string id)
        {
            var docRef = _coleccion.Document(id);
            await docRef.DeleteAsync();
        }

        public async Task<bool> ExisteAsync(string id)
        {
            var documento = await ObtenerDocumentoAsync(id);
            return documento != null;
        }
    }
}
