using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajeroATM
{
    public partial class otroValorRetirar : UserControl
    {
        public otroValorRetirar()
        {
            InitializeComponent();
        }

        private void depositarBTN_Click(object sender, EventArgs e)
        {
            String retirarField = retirarTXT.Text;
            double depositarSaldo = Convert.ToDouble(retirarField);
            Form2.instance.saldoFinal += depositarSaldo;
            MessageBox.Show("$" + retirarField + " han sido depositados en la cuenta, ya puedes consultar tu nuevo saldo.");
            Form2.instance.consultarSaldoForm.Hide();
            Form2.instance.depositarForm.Hide();
            Form2.instance.retirarForm.Hide();
            Form2.instance.cambioClaveForm.Hide();
            Form2.instance.otroValorDepositarForm.Hide();
            Form2.instance.otroValorRetirarForm.Hide();
        }

        private void otroValorRetirar_Load(object sender, EventArgs e)
        {

        }
    }
}
