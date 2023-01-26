using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cajeroATM
{
    public partial class consultarSaldo : UserControl
    {
        public static consultarSaldo instance;
        public Label saldoLabel;
        public consultarSaldo()
        {
            InitializeComponent();
            instance = this;
            saldoLabel = saldoLBL;

        }
        private void consultarSaldo_Load(object sender, EventArgs e)
        {

        }
    }
}
