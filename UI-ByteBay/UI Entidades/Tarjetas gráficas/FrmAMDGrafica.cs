using UI_ByteBay.UI_Entidades.Procesadores;

namespace UI_ByteBay.UI_Entidades.Tarjetas_gráficas
{
    public partial class FrmAMDGrafica : FrmGenerico
    {
        public FrmAMDGrafica()
        {
            InitializeComponent();
        }

        public override Form CrearFormularioEspecifico()
        {
            return new FrmIntel();
        }
    }
}
