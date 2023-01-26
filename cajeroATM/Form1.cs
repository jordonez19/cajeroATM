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
    public partial class Form1 : Form
    {

        public static Form1 Instance;

        public String clave
        {
            get { return claveActual; }
            set { claveActual = value; }
        }
        public String claveActual = "1234";
        public String claveNueva;
        public String claveNuevaActual;

        public Form1()
        {
            InitializeComponent();
            Instance = this;

            clave = claveActual;
            claveNueva = claveNuevaActual;

        }

        private void ingresarBTN_Click(object sender, EventArgs e)
        {
            string celularField = celularTXT.Text;
            string claveField = claveTXT.Text;


            if (!string.IsNullOrWhiteSpace(celularField) && !string.IsNullOrWhiteSpace(claveField))
            {
                MessageBox.Show("dato:" + clave  );


                if (claveField == clave)
                {
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta");
                }

            }
            else
            {
                MessageBox.Show("Debes llenar los campos para poder continuar");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
