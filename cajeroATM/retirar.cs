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
    public partial class retirar : UserControl
    {
        public static retirar instance;
        public retirar()
        {
            InitializeComponent();
            instance = this;
            //saldoCuentaRetiro = saldoCuentaRetiro;
        }

        private void retirar_Load(object sender, EventArgs e)
        {

        }
       
        private void n10BTN_Click(object sender, EventArgs e)
        {
            Form2.instance.saldoFinal -= 10000;
            MessageBox.Show("$10.000 han sido depositados en la cuenta, ya puedes consultar tu nuevo saldo.");
        }

        private void n20BTN_Click(object sender, EventArgs e)
        {

            Form2.instance.saldoFinal -= 20000;
            MessageBox.Show("$20.000 han sido depositados en la cuenta, ya puedes consultar tu nuevo saldo.");
        }
        private void n50BTN_Click_1(object sender, EventArgs e)
        {
            Form2.instance.saldoFinal -= 50000;
            MessageBox.Show("$50.000 han sido depositados en la cuenta, ya puedes consultar tu nuevo saldo.");
        }
        private void n100BTN_Click_1(object sender, EventArgs e)
        {
            Form2.instance.saldoFinal -= 100000;
            MessageBox.Show("$100.000 han sido depositados en la cuenta, ya puedes consultar tu nuevo saldo.");
        }
        private void n200BTN_Click_1(object sender, EventArgs e)
        {
            Form2.instance.saldoFinal -= 200000;
            MessageBox.Show("$200.000 han sido depositados en la cuenta, ya puedes consultar tu nuevo saldo.");
        }

        private void otroRetirarBTN_Click(object sender, EventArgs e)
        {
            Form2.instance.consultarSaldoForm.Hide();
            Form2.instance.depositarForm.Hide();
            Form2.instance.retirarForm.Hide();
            Form2.instance.cambioClaveForm.Hide();
            Form2.instance.otroValorDepositarForm.Hide();
            Form2.instance.otroValorRetirarForm.Show();
        }

       
    }
}
