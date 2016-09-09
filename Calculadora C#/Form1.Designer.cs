namespace Calcauladora
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.brSomar = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btSubtrair = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.mtbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btNumero);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btNumero);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btNumero);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Location = new System.Drawing.Point(272, 62);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(43, 23);
            this.btMultiplicar.TabIndex = 3;
            this.btMultiplicar.Text = "X";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.Operacao);
            // 
            // btDividir
            // 
            this.btDividir.Location = new System.Drawing.Point(272, 105);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(43, 23);
            this.btDividir.TabIndex = 7;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.Operacao);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(191, 105);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btNumero);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(110, 105);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btNumero);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(29, 105);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btNumero);
            // 
            // brSomar
            // 
            this.brSomar.Location = new System.Drawing.Point(272, 145);
            this.brSomar.Name = "brSomar";
            this.brSomar.Size = new System.Drawing.Size(43, 23);
            this.brSomar.TabIndex = 11;
            this.brSomar.Text = "+";
            this.brSomar.UseVisualStyleBackColor = true;
            this.brSomar.Click += new System.EventHandler(this.Operacao);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(191, 145);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btNumero);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(110, 145);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 9;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btNumero);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(29, 145);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 8;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btNumero);
            // 
            // btSubtrair
            // 
            this.btSubtrair.Location = new System.Drawing.Point(272, 181);
            this.btSubtrair.Name = "btSubtrair";
            this.btSubtrair.Size = new System.Drawing.Size(43, 23);
            this.btSubtrair.TabIndex = 15;
            this.btSubtrair.Text = "-";
            this.btSubtrair.UseVisualStyleBackColor = true;
            this.btSubtrair.Click += new System.EventHandler(this.Operacao);
            // 
            // btIgual
            // 
            this.btIgual.Location = new System.Drawing.Point(191, 181);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(75, 23);
            this.btIgual.TabIndex = 14;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(110, 181);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 13;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btNumero);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(29, 181);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // mtbResultado
            // 
            this.mtbResultado.Location = new System.Drawing.Point(29, 27);
            this.mtbResultado.Name = "mtbResultado";
            this.mtbResultado.Size = new System.Drawing.Size(286, 20);
            this.mtbResultado.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(347, 223);
            this.Controls.Add(this.mtbResultado);
            this.Controls.Add(this.btSubtrair);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.brSomar);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Form1";
            this.Text = "Calculadora - Taila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button brSomar;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btSubtrair;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.TextBox mtbResultado;
    }
}

