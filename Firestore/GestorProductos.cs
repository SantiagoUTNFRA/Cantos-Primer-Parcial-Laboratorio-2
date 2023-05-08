using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Firestore
{
    public class GestorProductos : GestorFirestoreBase
    {
        public GestorProductos() : base("Productos") { }

        public async Task<ResultadoOp> CrearProductoAsync(string nombre, string descripcion, double precio)
        {
            var nuevoProducto = new { Nombre = nombre, Descripcion = descripcion, Precio = precio };
            return await CrearEntidadAsync(nuevoProducto, nombre);
        }

        public async Task<ResultadoOp> ObtenerProductoAsync(string id)
        {
            return await ObtenerEntidadAsync(id);
        }

        public override async Task<ResultadoOp> CrearEntidadAsync(object entidad, string? docId = null)
        {
            try
            {
                if (await ExisteAsync(docId))
                {
                    return new ResultadoOp { EsExitoso = false, Datos = $"El producto '{docId}' ya existe en el sistema" };
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
                var producto = await base.ObtenerEntidadAsync(id);
                if (producto.EsExitoso)
                {
                    var productoDict = producto.Datos as Dictionary<string, object>;

                    return new ResultadoOp { EsExitoso = true, Datos = productoDict };
                }
                else
                {
                    return new ResultadoOp { EsExitoso = false, Datos = $"El producto '{id}' no existe." };
                }
            }
            catch (Exception ex)
            {
                return new ResultadoOp { EsExitoso = false, Datos = ex.Message };
            }
        }
    }
}
