using CalculadoraPOO.metodo;
using System.Security.Cryptography.X509Certificates;

namespace CalculadoraPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.num1 = txbPrimeiroNumero.Text;
            controle.num2 = txbSegundoNumero.Text;
            controle.Executar();

            if (controle.mensagem.Equals(""))
            {
                lblResultado.Text = controle.resultado;
            }
            else
            {
                lblResultado.Text = controle.mensagem;
            }

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

        }
    }
}
