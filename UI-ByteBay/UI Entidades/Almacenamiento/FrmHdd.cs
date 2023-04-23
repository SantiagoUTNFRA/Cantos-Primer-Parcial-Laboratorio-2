using UI_ByteBay.UI_Entidades.Procesadores;

namespace UI_ByteBay.UI_Entidades.Almacenamiento
{
    public partial class FrmHdd : FrmGenerico
    {
        public FrmHdd()
        {
            InitializeComponent();
        }

        public override Form CrearFormularioEspecifico()
        {
            return new FrmIntel();
        }
    }
}
