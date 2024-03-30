namespace CalculadoraPOO
{
    partial class Form1
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
            btnSomar = new Button();
            lblPrimeiroNumero = new Label();
            lblSegundoNumero = new Label();
            txbPrimeiroNumero = new TextBox();
            txbSegundoNumero = new TextBox();
            lblResultado = new Label();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(71, 264);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(85, 29);
            btnSomar.TabIndex = 0;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // lblPrimeiroNumero
            // 
            lblPrimeiroNumero.AutoSize = true;
            lblPrimeiroNumero.Location = new Point(71, 65);
            lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            lblPrimeiroNumero.Size = new Size(179, 20);
            lblPrimeiroNumero.TabIndex = 1;
            lblPrimeiroNumero.Text = "Digite o primeiro número";
            // 
            // lblSegundoNumero
            // 
            lblSegundoNumero.AutoSize = true;
            lblSegundoNumero.Location = new Point(71, 163);
            lblSegundoNumero.Name = "lblSegundoNumero";
            lblSegundoNumero.Size = new Size(179, 20);
            lblSegundoNumero.TabIndex = 2;
            lblSegundoNumero.Text = "Digite o segundo número";
            // 
            // txbPrimeiroNumero
            // 
            txbPrimeiroNumero.Location = new Point(71, 88);
            txbPrimeiroNumero.Name = "txbPrimeiroNumero";
            txbPrimeiroNumero.Size = new Size(179, 27);
            txbPrimeiroNumero.TabIndex = 3;
            // 
            // txbSegundoNumero
            // 
            txbSegundoNumero.Location = new Point(71, 195);
            txbSegundoNumero.Name = "txbSegundoNumero";
            txbSegundoNumero.Size = new Size(179, 27);
            txbSegundoNumero.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(123, 372);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(165, 264);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(85, 29);
            btnSubtrair.TabIndex = 6;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(71, 304);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(85, 29);
            btnMultiplicar.TabIndex = 7;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(165, 304);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(85, 29);
            btnDividir.TabIndex = 8;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 495);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(lblResultado);
            Controls.Add(txbSegundoNumero);
            Controls.Add(txbPrimeiroNumero);
            Controls.Add(lblSegundoNumero);
            Controls.Add(lblPrimeiroNumero);
            Controls.Add(btnSomar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSomar;
        private Label lblPrimeiroNumero;
        private Label lblSegundoNumero;
        private TextBox txbPrimeiroNumero;
        private TextBox txbSegundoNumero;
        private Label lblResultado;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}
