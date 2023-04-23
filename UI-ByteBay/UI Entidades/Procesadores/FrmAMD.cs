namespace UI_ByteBay.UI_Entidades.Procesadores
{
    public partial class FrmAMD : FrmGenerico
    {
        public FrmAMD()
        {
            InitializeComponent();
        }

        public override Form CrearFormularioEspecifico()
        {
            return new FrmIntel();
        }
    }
}
