

namespace ProgramacaoVisual
{
    partial class JogoAdivinhacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button GetBtnIniciar()
        {
            return btnIniciar;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button btnIniciar)
        {
            txtTentativaJogador1 = new TextBox();
            txtTentativaJogador2 = new TextBox();
            btnJogador1 = new Button();
            btnJogador2 = new Button();
            labelResultado = new Label();
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // txtTentativaJogador1
            // 
            txtTentativaJogador1.Location = new Point(145, 145);
            txtTentativaJogador1.Name = "txtTentativaJogador1";
            txtTentativaJogador1.Size = new Size(100, 23);
            txtTentativaJogador1.TabIndex = 0;
            // 
            // txtTentativaJogador2
            // 
            txtTentativaJogador2.Location = new Point(508, 145);
            txtTentativaJogador2.Name = "txtTentativaJogador2";
            txtTentativaJogador2.Size = new Size(100, 23);
            txtTentativaJogador2.TabIndex = 1;
            // 
            // btnJogador1
            // 
            btnJogador1.Location = new Point(155, 200);
            btnJogador1.Name = "btnJogador1";
            btnJogador1.Size = new Size(75, 23);
            btnJogador1.TabIndex = 2;
            btnJogador1.Text = "Verificar";
            btnJogador1.UseVisualStyleBackColor = true;
            btnJogador1.Click += btnJogador1_Click;
            // 
            // btnJogador2
            // 
            btnJogador2.Location = new Point(520, 200);
            btnJogador2.Name = "btnJogador2";
            btnJogador2.Size = new Size(75, 23);
            btnJogador2.TabIndex = 3;
            btnJogador2.Text = "Verificar";
            btnJogador2.UseVisualStyleBackColor = true;
            btnJogador2.Click += btnJogador2_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(360, 296);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(28, 30);
            labelResultado.TabIndex = 4;
            labelResultado.Text = "...";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(340, 40);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar Jogo";
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // JogoAdivinhacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIniciar);
            Controls.Add(labelResultado);
            Controls.Add(btnJogador2);
            Controls.Add(btnJogador1);
            Controls.Add(txtTentativaJogador2);
            Controls.Add(txtTentativaJogador1);
            Name = "JogoAdivinhacao";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
       
        #endregion

        private TextBox txtTentativaJogador1;
        private TextBox txtTentativaJogador2;
        private Button btnJogador1;
        private Button btnJogador2;
        private Label labelResultado;
        private Button btnIniciar;
    }
}