namespace ProgramacaoVisual
{
    public partial class Calculadora : Form
    {

        double firstNum = 0;
        double secondNum = 0;
        string operation = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }


        // Adiciona número ao display
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = button.Text;
            }
            else
            {
                txtDisplay.Text += button.Text;
            }
        }

        // Operadores (+, -, *, /)
        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstNum = Convert.ToDouble(txtDisplay.Text);
            operation = button.Text;
            txtDisplay.Text = "";
        }

        // Botão de igual
        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDouble(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (firstNum + secondNum).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (firstNum - secondNum).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (firstNum * secondNum).ToString();
                    break;
                case "/":
                    if (secondNum != 0)
                    {
                        txtDisplay.Text = (firstNum / secondNum).ToString();
                    }
                    else
                    {
                        txtDisplay.Text = "Erro";
                    }
                    break;
            }
        }

        // Botão de limpar
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNum = 0; []
            secondNum = 0;
            operation = "";
        }
    }
}
