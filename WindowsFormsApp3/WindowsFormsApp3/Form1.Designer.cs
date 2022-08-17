namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResDiferenca = new System.Windows.Forms.Label();
            this.lblResEntre = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnDif = new System.Windows.Forms.RadioButton();
            this.btnEntre = new System.Windows.Forms.RadioButton();
            this.btnMaior = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(152, 58);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(50, 13);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Numero1";
            this.lblNumero1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(152, 92);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(50, 13);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Numero2";
            this.lblNumero2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(208, 51);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(129, 20);
            this.txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(208, 86);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(129, 20);
            this.txtNumero2.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(208, 109);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(347, 49);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // lblResDiferenca
            // 
            this.lblResDiferenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResDiferenca.Location = new System.Drawing.Point(208, 172);
            this.lblResDiferenca.Name = "lblResDiferenca";
            this.lblResDiferenca.Size = new System.Drawing.Size(347, 49);
            this.lblResDiferenca.TabIndex = 5;
            this.lblResDiferenca.Text = "Diferença";
            this.lblResDiferenca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResEntre
            // 
            this.lblResEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResEntre.Location = new System.Drawing.Point(208, 230);
            this.lblResEntre.Name = "lblResEntre";
            this.lblResEntre.Size = new System.Drawing.Size(347, 59);
            this.lblResEntre.TabIndex = 6;
            this.lblResEntre.Text = "Resultado";
            this.lblResEntre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResEntre.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(578, 133);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(151, 88);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnDif
            // 
            this.btnDif.AutoSize = true;
            this.btnDif.Location = new System.Drawing.Point(131, 194);
            this.btnDif.Name = "btnDif";
            this.btnDif.Size = new System.Drawing.Size(71, 17);
            this.btnDif.TabIndex = 12;
            this.btnDif.TabStop = true;
            this.btnDif.Text = "Diferença";
            this.btnDif.UseVisualStyleBackColor = true;
            // 
            // btnEntre
            // 
            this.btnEntre.AutoSize = true;
            this.btnEntre.Location = new System.Drawing.Point(108, 248);
            this.btnEntre.Name = "btnEntre";
            this.btnEntre.Size = new System.Drawing.Size(94, 17);
            this.btnEntre.TabIndex = 13;
            this.btnEntre.TabStop = true;
            this.btnEntre.Text = "Numeros entre";
            this.btnEntre.UseVisualStyleBackColor = true;
            // 
            // btnMaior
            // 
            this.btnMaior.AutoSize = true;
            this.btnMaior.Location = new System.Drawing.Point(117, 131);
            this.btnMaior.Name = "btnMaior";
            this.btnMaior.Size = new System.Drawing.Size(91, 17);
            this.btnMaior.TabIndex = 14;
            this.btnMaior.TabStop = true;
            this.btnMaior.Text = "Maior ou igual";
            this.btnMaior.UseVisualStyleBackColor = true;
            this.btnMaior.CheckedChanged += new System.EventHandler(this.btnMaior_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaior);
            this.Controls.Add(this.btnEntre);
            this.Controls.Add(this.btnDif);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResEntre);
            this.Controls.Add(this.lblResDiferenca);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Name = "Form1";
            this.Text = "Maior ou igual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResDiferenca;
        private System.Windows.Forms.Label lblResEntre;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton btnDif;
        private System.Windows.Forms.RadioButton btnEntre;
        private System.Windows.Forms.RadioButton btnMaior;
    }
}

