namespace Firestore
{
    public class ResultadoOp
    {
        private bool _esExitoso;
        private string _mensaje;
        private object _datos;

        public bool EsExitoso { get => _esExitoso; set => _esExitoso = value; }
        public string Mensaje { get => _mensaje; set => _mensaje = value; }
        public object Datos { get => _datos; set => _datos = value; }
    }
}
