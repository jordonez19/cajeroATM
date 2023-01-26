using cajeroATM;
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
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public UserControl consultarSaldoForm;
        public UserControl depositarForm;
        public UserControl retirarForm;
        public UserControl cambioClaveForm;
        public UserControl otroValorDepositarForm;
        public UserControl otroValorRetirarForm;
        public double saldo = 1000000;
        public double saldoFinal;


        public Form2()
        {
            InitializeComponent();
            instance = this;
            saldoFinal = saldo;
            consultarSaldoForm = consultarSaldo1;
            depositarForm = depositar1;
            retirarForm = retirar1;
            cambioClaveForm = cambioClave1;

            otroValorDepositarForm = otroValorDepositar1;
            otroValorRetirarForm = otroValorRetirar1;
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            consultarSaldo1.Hide();
            depositar1.Hide();
            retirar1.Hide();
            cambioClave1.Hide();
            otroValorDepositar1.Hide();
            otroValorRetirar1.Hide();


        }

        private void saldoBTN_Click(object sender, EventArgs e)
        {
            consultarSaldo1.Show();
            depositar1.Hide();
            retirar1.Hide();
            cambioClave1.Hide();

            consultarSaldo.instance.saldoLabel.Text = Convert.ToInt32(saldoFinal).ToString("N");
        }

        private void depositarBTN_Click(object sender, EventArgs e)
        {
            depositar1.Show();
            consultarSaldo1.Hide();
            retirar1.Hide();
            cambioClave1.Hide();
        }

        private void retirarBTN_Click(object sender, EventArgs e)
        {
            retirar1.Show();
            consultarSaldo1.Hide();
            depositar1.Hide();
            cambioClave1.Hide();

        }

        private void cambioClaveBTN_Click(object sender, EventArgs e)
        {
            cambioClave1.Show();
            consultarSaldo1.Hide();
            depositar1.Hide();
            retirar1.Hide();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Instance.Show();
        }

        private void otroValorRetirar1_Load(object sender, EventArgs e)
        {

        }
    }
}
