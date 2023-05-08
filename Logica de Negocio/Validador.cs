
namespace Logica_de_Negocio
{
    public static class Validador
    {
        public static bool EsContraseniaValida(string contrasenia)
        {
            // Reemplaza las siguientes reglas de validación con las que sean apropiadas para tu aplicación
            bool tieneLongitudValida = contrasenia.Length >= 2;

            if (tieneLongitudValida)
            {
                return true;
            }
            return false;
        }
    }

}
