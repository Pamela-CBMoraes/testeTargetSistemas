using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio3
{
    public partial class Form1 : Form
    {
        public class Faturamento
        {
            public int dia { get; set; }
            public double valor { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            double menorValor = 0.0, maiorValor = 0.0, mediaMensal = 0.0, totalMensal = 0.0;
            int contador = 0, dias = 0;
            
            StreamReader r = new StreamReader("dados.json");

            string json = r.ReadToEnd();
            Faturamento[] faturamentoMensal = JsonConvert.DeserializeObject<Faturamento[]>(json);

            menorValor = faturamentoMensal[0].valor;
            maiorValor = faturamentoMensal[0].valor;

            foreach (Faturamento fatDiario in faturamentoMensal)
            {
                if(fatDiario.valor > 0.0)
                {
                    contador++;
                    totalMensal = totalMensal + fatDiario.valor;

                    if (fatDiario.valor< menorValor)
                    {
                        menorValor = fatDiario.valor;
                    }

                    if (fatDiario.valor > maiorValor)
                    {
                        maiorValor = fatDiario.valor;
                    }
                }
            }
            mediaMensal = totalMensal / contador;

            foreach (Faturamento fatDiario in faturamentoMensal)
            {
                if (fatDiario.valor > mediaMensal)
                {
                    dias++;
                }
            }

            lblMostraMenorValor.Visible = true;
            lblMostraMenorValor.Text = menorValor.ToString("n");
            lblMostraMaiorValorFat.Visible = true;
            lblMostraMaiorValorFat.Text = maiorValor.ToString("n");
            lblMostraQtdeDias.Visible = true;
            lblMostraQtdeDias.Text = dias.ToString();
        }
    }
}
