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
    public partial class otroValorDepositar : UserControl
    {
        public otroValorDepositar()
        {
            InitializeComponent();
        }

        private void otroValorDepositar_Load(object sender, EventArgs e)
        {

        }

        private void depositarBTN_Click(object sender, EventArgs e)
        {
            String depositarField = depositarTXT.Text;
            double depositarSaldo = Convert.ToDouble(depositarField);
            Form2.instance.saldoFinal += depositarSaldo;
            MessageBox.Show("$" + depositarField + " han sido depositados en la cuenta, ya puedes consultar tu nuevo saldo.");
            Form2.instance.consultarSaldoForm.Hide();
            Form2.instance.depositarForm.Hide();
            Form2.instance.retirarForm.Hide();
            Form2.instance.cambioClaveForm.Hide();
            Form2.instance.otroValorDepositarForm.Hide();
            Form2.instance.otroValorRetirarForm.Hide();
        }
    }
}
