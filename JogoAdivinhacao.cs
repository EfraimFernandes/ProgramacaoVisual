using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacaoVisual
{
    public partial class JogoAdivinhacao : Form
    {
        private int numeroEscolhido;
        private int tentativasJogador1 = 0;
        private int tentativasJogador2 = 0;
        private bool jogador1Ativo = true;
        private bool fimDeJogo = false;
        private Random random = new Random();



        public JogoAdivinhacao()
        {
            InitializeComponent(GetBtnIniciar());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click()
        {
            IniciarJogoJogador1();
        }

        private void IniciarJogoJogador1()
        {
            numeroEscolhido = random.Next(0, 10);
            tentativasJogador1 = 0;
            jogador1Ativo = true;
            labelResultado.Text = "Jogador 1, advinhe o número!";
        }

        private void IniciarJogoJogador2()
        {
            numeroEscolhido = random.Next(0, 10);
            tentativasJogador2 = 0;
            jogador1Ativo = false;
            labelResultado.Text = "Jogador 2, advinhe o número!";
        }


        private void btnJogador1_Click(object sender, EventArgs e)
        {
            if (jogador1Ativo && !fimDeJogo)
            {
                Jogar(ref tentativasJogador1, txtTentativaJogador1.Text, true);
            }
        }

        private void btnJogador2_Click(object sender, EventArgs e)
        {
            if (!jogador1Ativo && !fimDeJogo)
            {
                Jogar(ref tentativasJogador2, txtTentativaJogador2.Text, false);
            }
        }

        private void Jogar(ref int tentativas, string tentativaTexto, bool jogador1)
        {
            int tentativa;
            if (int.TryParse(tentativaTexto, out tentativa))
            {
                while (tentativa != numeroEscolhido)
                {
                    tentativas++;
                    if (tentativa < numeroEscolhido)
                    {
                        labelResultado.Text = "O número é maior!";
                    }
                    else if (tentativa > numeroEscolhido)
                    {
                        labelResultado.Text = "O número é menor!";
                    }

                    tentativaTexto = InputBox("Tente novamente! Insira um número:");
                    if (!int.TryParse(tentativaTexto, out tentativa))
                    {
                        MessageBox.Show("Número inválido! Insira um número válido entre 1 e 10.");
                        return;
                    }
                }

                tentativas++;
                if (jogador1)
                {
                    MessageBox.Show($"Jogador 1 acertou o número {numeroEscolhido} em {tentativasJogador1} tentativas!");
                    IniciarJogoJogador2();
                }
                else
                {
                    MessageBox.Show($"Jogador 2 acertou o número {numeroEscolhido} em {tentativasJogador2} tentativas!");
                    fimDeJogo = true;
                    VerificarVencedor();
                }
            }
            else
            {
                MessageBox.Show("Número inválido! Insira um número válido entre 1 e 10.");
            }
        }

        private void VerificarVencedor()
        {
            if (tentativasJogador1 < tentativasJogador2)
            {
                MessageBox.Show("Jogador 1 venceu com menos tentativas!");
            }
            else if (tentativasJogador1 > tentativasJogador2)
            {
                MessageBox.Show("Jogador 2 venceu com menos tentativas!");
            }
            else
            {
                MessageBox.Show("Empate! Ambos acertaram com o mesmo número de tentativas.");
            }
        }

        private string InputBox(string prompt)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(prompt, "Tentativa", "", -1, -1);
        }
    }
}
