namespace ConsumoRacaoApp
{
    partial class frmCalculoRacao
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
            label1 = new Label();
            panel1 = new Panel();
            BtnCalculo = new Button();
            NumDias = new NumericUpDown();
            label4 = new Label();
            NumMedRacao = new NumericUpDown();
            label3 = new Label();
            NumAnimais = new NumericUpDown();
            label2 = new Label();
            label5 = new Label();
            Resultado = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumDias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumMedRacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumAnimais).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 45);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 0;
            label1.Text = "Cálculo de quantidade";
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCalculo);
            panel1.Controls.Add(NumDias);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(NumMedRacao);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(NumAnimais);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 451);
            panel1.TabIndex = 0;
            // 
            // BtnCalculo
            // 
            BtnCalculo.Location = new Point(211, 375);
            BtnCalculo.Name = "BtnCalculo";
            BtnCalculo.Size = new Size(112, 34);
            BtnCalculo.TabIndex = 7;
            BtnCalculo.Text = "Calcular";
            BtnCalculo.UseVisualStyleBackColor = true;
            BtnCalculo.Click += BtnCalculo_Click;
            // 
            // NumDias
            // 
            NumDias.Location = new Point(37, 308);
            NumDias.Name = "NumDias";
            NumDias.Size = new Size(140, 31);
            NumDias.TabIndex = 6;
            NumDias.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 280);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 5;
            label4.Text = "Num de Dias:";
            // 
            // NumMedRacao
            // 
            NumMedRacao.DecimalPlaces = 2;
            NumMedRacao.Location = new Point(37, 212);
            NumMedRacao.Name = "NumMedRacao";
            NumMedRacao.Size = new Size(140, 31);
            NumMedRacao.TabIndex = 4;
            NumMedRacao.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 184);
            label3.Name = "label3";
            label3.Size = new Size(210, 25);
            label3.TabIndex = 3;
            label3.Text = "Qtd Média de Ração(Kg):";
            // 
            // NumAnimais
            // 
            NumAnimais.Location = new Point(37, 122);
            NumAnimais.Name = "NumAnimais";
            NumAnimais.Size = new Size(140, 31);
            NumAnimais.TabIndex = 2;
            NumAnimais.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 94);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 1;
            label2.Text = "Qtd de Animais:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(530, 118);
            label5.Name = "label5";
            label5.Size = new Size(187, 25);
            label5.TabIndex = 1;
            label5.Text = "Quantidade de Ração:";
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Resultado.Location = new Point(611, 180);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(23, 25);
            Resultado.TabIndex = 2;
            Resultado.Text = "0";
            // 
            // frmCalculoRacao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Resultado);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "frmCalculoRacao";
            Text = "l";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumDias).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumMedRacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumAnimais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private NumericUpDown NumDias;
        private Label label4;
        private NumericUpDown NumMedRacao;
        private Label label3;
        private NumericUpDown NumAnimais;
        private Label label2;
        private Button BtnCalculo;
        private Label label5;
        private Label Resultado;
    }
}