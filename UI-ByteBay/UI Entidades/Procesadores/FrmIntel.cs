using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ByteBay.UI_Entidades.Procesadores
{
    public partial class FrmIntel : FrmGenerico
    {
        public FrmIntel()
        {
            InitializeComponent();
        }

        public override Form CrearFormularioEspecifico()
        {
            return new FrmIntel();
        }
    }
}
