using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_ByteBay.UI_Entidades.Procesadores;

namespace UI_ByteBay.UI_Entidades.Memorias_RAM
{
    public partial class FrmDdr4 : FrmGenerico
    {
        public FrmDdr4()
        {
            InitializeComponent();
        }

        public override Form CrearFormularioEspecifico()
        {
            return new FrmIntel();
        }
    }
}
