namespace ProgramacaoVisual
{
    partial class CriacaoFuncoes
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblA = new Label();
            lblB = new Label();
            lblMaior = new Label();
            txtB = new TextBox();
            txtMaior = new TextBox();
            txtA = new TextBox();
            btnVerificar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(154, 111);
            lblA.Name = "lblA";
            lblA.Size = new Size(15, 15);
            lblA.TabIndex = 0;
            lblA.Text = "A";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(154, 184);
            lblB.Name = "lblB";
            lblB.Size = new Size(14, 15);
            lblB.TabIndex = 1;
            lblB.Text = "B";
            // 
            // lblMaior
            // 
            lblMaior.AutoSize = true;
            lblMaior.Location = new Point(154, 260);
            lblMaior.Name = "lblMaior";
            lblMaior.Size = new Size(38, 15);
            lblMaior.TabIndex = 2;
            lblMaior.Text = "Maior";
            // 
            // txtB
            // 
            txtB.Location = new Point(257, 181);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 3;
            // 
            // txtMaior
            // 
            txtMaior.Location = new Point(257, 257);
            txtMaior.Name = "txtMaior";
            txtMaior.Size = new Size(100, 23);
            txtMaior.TabIndex = 4;
            // 
            // txtA
            // 
            txtA.Location = new Point(257, 108);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 5;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(454, 103);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 6;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(454, 176);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // CriacaoFuncoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar);
            Controls.Add(btnVerificar);
            Controls.Add(txtA);
            Controls.Add(txtMaior);
            Controls.Add(txtB);
            Controls.Add(lblMaior);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Name = "CriacaoFuncoes";
            Text = "CriacaoFuncoes";
            Load += CriacaoFuncoes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblB;
        private Label lblMaior;
        private TextBox txtB;
        private TextBox txtMaior;
        private TextBox txtA;
        private Button btnVerificar;
        private Button btnLimpar;
    }
}