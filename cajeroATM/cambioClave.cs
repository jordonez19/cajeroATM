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
    public partial class cambioClave : UserControl
    {
        public static cambioClave instance;
        public cambioClave()
        {
            InitializeComponent();
            instance= this;
        }

        private void cambioClave_Load(object sender, EventArgs e)
        {

        }

        private void cambiarClaveBTN_Click_1(object sender, EventArgs e)
        {
            String nuevaClave = nuevaClaveTXT.Text;
            String confirmarClave = confirmarClaveTXT.Text;

            if (nuevaClave == confirmarClave)
            {
                Form2.instance.claveActual = nuevaClave;
                MessageBox.Show("Su clave ah sido cambiada");
            }
        }
    }
}
