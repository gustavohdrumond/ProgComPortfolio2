using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioCiclo02
{
    public partial class PortfolioCiclo03 : Form
    {
        public PortfolioCiclo03()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botaoCalculo_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;

            a = Convert.ToDouble(valorEntradaA.Text);
            b = Convert.ToDouble(valorEntradaB.Text);
            c = Convert.ToDouble(valorEntradaC.Text);

            delta(a, b, c);
            x1(a, b, c);
            x2(a, b, c);
        }

        private void delta(double a, double b, double c)
        {
            double delta = (b * b) - (4 * (a * c));
            resultadoDelta.Text = delta.ToString();
        }

        private void x1(double a, double b, double c)
        {
            double delta = (b * b) - (4 * (a * c));
            double x1 = (-b + (Math.Sqrt(delta))) / (2 * a);

            if (delta > 0)
            {
                resultadoX1.Text = x1.ToString();
            }
            else if (delta == 0)
            {
                resultadoX1.Text = x1.ToString();
            }
            else
            {
                resultadoX1.Text = "Equação não possui valor para ser exibido.";
            }
        }
        private void x2(double a, double b, double c)
        {
            double delta = (b * b) - (4 * (a * c));
            double x2 = (-b - (Math.Sqrt(delta))) / (2 * a);

            if (delta > 0)
            {
                resultadoX2.Text = x2.ToString();
            }
            else if (delta == 0)
            {
                resultadoX2.Text = x2.ToString();
            }
            else
            {
                resultadoX2.Text = "Equação não possui valor para ser exibido.";
            }
        }

    }
}