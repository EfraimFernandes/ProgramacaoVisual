namespace ProgramacaoVisual
{
    public partial class CalcularIMC : Form
    {
        public CalcularIMC()
        {
            InitializeComponent();
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                double altura = Convert.ToDouble(textBoxAltura.Text);
                double peso = Convert.ToDouble(textBoxPeso.Text);

                double imc = peso / (altura * altura);

                string resultado;
                if (imc < 18.5)
                {
                    resultado = "Abaixo do peso";
                }
                else if (imc >= 18.5 && imc < 24.9)
                {
                    resultado = "Peso normal";
                }
                else if (imc >= 25 && imc < 29.9)
                {
                    resultado = "Sobrepeso";
                }
                else if (imc >= 30 && imc < 34.9)
                {
                    resultado = "Obesidade grau 1";
                }
                else if (imc >= 35 && imc < 39.9)
                {
                    resultado = "Obesidade grau 2";
                }
                else
                {
                    resultado = "Obesidade grau 3";
                }

                labelResultado.Text = $"IMC: {imc:F2} - {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos para altura e peso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void CalcularIMC_Load(object sender, EventArgs e)
        {

        }
    }
}
