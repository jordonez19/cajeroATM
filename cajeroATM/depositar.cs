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
    public partial class depositar : UserControl
    {
        public static depositar instance;
        public double depositarSaldo;
        public double saldoCuentaDeposito;
        public depositar()
        {
            InitializeComponent();
            instance = this;
        }

        private void n10BTN_Click(object sender, EventArgs e)
        {
            Form2.instance.saldoFinal += 10000;
            MessageBox.Show("$10.000 han sido depositados en la cuenta, ya puedes consultar tu nuevo saldo.");
        }

        private void n20BTN_Click(object sender, EventArgs e)
        {

            Form2.instance.saldoFinal += 20000;
            MessageBox.Show("$20.000 han sido depositados en la cuenta, ya puedes consultar tu nuevo saldo.");
        }

        private void n50BTN_Click(object sender, EventArgs e)
        {
            
            Form2.instance.saldoFinal += 50000;
            MessageBox.Show("$50.000 han sido depositados en la cuenta, ya puedes consultar tu nuevo saldo.");
        }

        private void n100BTN_Click(object sender, EventArgs e)
        {
            
            Form2.instance.saldoFinal += 100000;
            MessageBox.Show("$100.000 han sido depositados en la cuenta, ya puedes consultar tu nuevo saldo.");
        }

        private void n200BTN_Click(object sender, EventArgs e)
        {
            
            Form2.instance.saldoFinal += 200000;

            MessageBox.Show("$200.000 han sido depositados en la cuenta, ya puedes consultar tu nuevo saldo.");
        }

        private void otroDepositarBTN_Click(object sender, EventArgs e)
        {
            Form2.instance.consultarSaldoForm.Hide();
            Form2.instance.depositarForm.Hide();
            Form2.instance.retirarForm.Hide();
            Form2.instance.cambioClaveForm.Hide();
            Form2.instance.otroValorDepositarForm.Show();
            Form2.instance.otroValorRetirarForm.Hide();
        }
    }
}
