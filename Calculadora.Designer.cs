namespace ProgramacaoVisual
{
    partial class Calculadora
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
            txtDisplay = new TextBox();
            Button7 = new Button();
            Button8 = new Button();
            Button9 = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            Button6 = new Button();
            Button5 = new Button();
            Button4 = new Button();
            btnSubtract = new Button();
            Button3 = new Button();
            Button2 = new Button();
            Button1 = new Button();
            btnAdd = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            Button0 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.InactiveBorder;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Location = new Point(219, 108);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(342, 16);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // Button7
            // 
            Button7.Location = new Point(219, 188);
            Button7.Name = "Button7";
            Button7.Size = new Size(75, 23);
            Button7.TabIndex = 1;
            Button7.Text = "7";
            Button7.UseVisualStyleBackColor = true;
            Button7.Click += Button_Click;
            // 
            // Button8
            // 
            Button8.Location = new Point(300, 188);
            Button8.Name = "Button8";
            Button8.Size = new Size(75, 23);
            Button8.TabIndex = 2;
            Button8.Text = "8";
            Button8.UseVisualStyleBackColor = true;
            Button8.Click += Button_Click;
            // 
            // Button9
            // 
            Button9.Location = new Point(381, 188);
            Button9.Name = "Button9";
            Button9.Size = new Size(75, 23);
            Button9.TabIndex = 3;
            Button9.Text = "9";
            Button9.UseVisualStyleBackColor = true;
            Button9.Click += Button_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(486, 188);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 23);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += Operator_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(486, 228);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 23);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += Operator_Click;
            // 
            // Button6
            // 
            Button6.Location = new Point(381, 228);
            Button6.Name = "Button6";
            Button6.Size = new Size(75, 23);
            Button6.TabIndex = 7;
            Button6.Text = "6";
            Button6.UseVisualStyleBackColor = true;
            Button6.Click += Button_Click;
            // 
            // Button5
            // 
            Button5.Location = new Point(300, 228);
            Button5.Name = "Button5";
            Button5.Size = new Size(75, 23);
            Button5.TabIndex = 6;
            Button5.Text = "5";
            Button5.UseVisualStyleBackColor = true;
            Button5.Click += Button_Click;
            // 
            // Button4
            // 
            Button4.Location = new Point(219, 228);
            Button4.Name = "Button4";
            Button4.Size = new Size(75, 23);
            Button4.TabIndex = 5;
            Button4.Text = "4";
            Button4.UseVisualStyleBackColor = true;
            Button4.Click += Button_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(486, 266);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 23);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += Operator_Click;
            // 
            // Button3
            // 
            Button3.Location = new Point(381, 266);
            Button3.Name = "Button3";
            Button3.Size = new Size(75, 23);
            Button3.TabIndex = 11;
            Button3.Text = "3";
            Button3.UseVisualStyleBackColor = true;
            Button3.Click += Button_Click;
            // 
            // Button2
            // 
            Button2.Location = new Point(300, 266);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 10;
            Button2.Text = "2";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button_Click;
            // 
            // Button1
            // 
            Button1.Location = new Point(219, 266);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 9;
            Button1.Text = "1";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(486, 305);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Operator_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(381, 305);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(99, 23);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(300, 305);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Button0
            // 
            Button0.Location = new Point(219, 305);
            Button0.Name = "Button0";
            Button0.Size = new Size(75, 23);
            Button0.TabIndex = 13;
            Button0.Text = "0";
            Button0.UseVisualStyleBackColor = true;
            Button0.Click += Button_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnEquals);
            Controls.Add(btnClear);
            Controls.Add(Button0);
            Controls.Add(btnSubtract);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(btnMultiply);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(btnDivide);
            Controls.Add(Button9);
            Controls.Add(Button8);
            Controls.Add(Button7);
            Controls.Add(txtDisplay);
            Name = "Calculadora";
            Text = "Form1";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button Button7;
        private Button Button8;
        private Button Button9;
        private Button btnDivide;
        private Button btnMultiply;
        private Button Button6;
        private Button Button5;
        private Button Button4;
        private Button btnSubtract;
        private Button Button3;
        private Button Button2;
        private Button Button1;
        private Button btnAdd;
        private Button btnEquals;
        private Button btnClear;
        private Button Button0;
    }
}