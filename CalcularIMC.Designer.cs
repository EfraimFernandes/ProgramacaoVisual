namespace ProgramacaoVisual
{
    partial class CalcularIMC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelAltura = new Label();
            textBoxAltura = new TextBox();
            buttonCalcular = new Button();
            textBoxPeso = new TextBox();
            labelPeso = new Label();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Font = new Font("Verdana", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAltura.Location = new Point(170, 124);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(138, 42);
            labelAltura.TabIndex = 0;
            labelAltura.Text = "Altura:";
            // 
            // textBoxAltura
            // 
            textBoxAltura.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAltura.Location = new Point(314, 135);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(254, 37);
            textBoxAltura.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = SystemColors.ActiveCaption;
            buttonCalcular.Cursor = Cursors.Hand;
            buttonCalcular.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCalcular.Location = new Point(260, 270);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(212, 41);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "Calcular!";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click_1;
            // 
            // textBoxPeso
            // 
            textBoxPeso.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPeso.Location = new Point(314, 198);
            textBoxPeso.Name = "textBoxPeso";
            textBoxPeso.Size = new Size(254, 37);
            textBoxPeso.TabIndex = 4;
            // 
            // labelPeso
            // 
            labelPeso.AutoSize = true;
            labelPeso.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPeso.Location = new Point(203, 188);
            labelPeso.Name = "labelPeso";
            labelPeso.Size = new Size(105, 38);
            labelPeso.TabIndex = 3;
            labelPeso.Text = "Peso:";
            // 
            // labelResultado
            // 
            labelResultado.BackColor = Color.Linen;
            labelResultado.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(110, 355);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(572, 69);
            labelResultado.TabIndex = 5;
            labelResultado.Text = "...";
            labelResultado.TextAlign = ContentAlignment.MiddleCenter;
            labelResultado.Click += labelResultado_Click;
            // 
            // CalcularIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResultado);
            Controls.Add(textBoxPeso);
            Controls.Add(labelPeso);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxAltura);
            Controls.Add(labelAltura);
            Name = "CalcularIMC";
            Text = "CalcularIMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAltura;
        private Button buttonCalcular;
        private TextBox textBoxPeso;
        private Label labelPeso;
        private Label labelResultado;
        public TextBox textBoxAltura;
    }
}
