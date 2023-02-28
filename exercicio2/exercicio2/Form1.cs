using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int a = 0, b = 1, num = 0, soma = 0;
            bool pertence = false;
            
            if(!int.TryParse(txtNumero.Text, out num))
            {
                MessageBox.Show("Informe um número inteiro!");
                return;
            }

            while (soma < num)
            {
                soma = a + b;
                a = b;
                b = soma;

                if (soma == num)
                {
                    pertence = true;
                }
            }
            if (pertence)
            {
                MessageBox.Show("Número pertence a sequência de fibonacci");          
            } else
            {
                MessageBox.Show("Número não pertence a sequência de fibonacci");
            }
        }
    }
}
