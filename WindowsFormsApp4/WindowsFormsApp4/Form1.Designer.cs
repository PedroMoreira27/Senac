namespace WindowsFormsApp4
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtInserir = new System.Windows.Forms.TextBox();
            this.cmbTexto = new System.Windows.Forms.ComboBox();
            this.ptbImagem = new System.Windows.Forms.PictureBox();
            this.btnImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(414, 59);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(414, 106);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtInserir
            // 
            this.txtInserir.Location = new System.Drawing.Point(120, 62);
            this.txtInserir.Name = "txtInserir";
            this.txtInserir.Size = new System.Drawing.Size(256, 20);
            this.txtInserir.TabIndex = 2;
            this.txtInserir.TextChanged += new System.EventHandler(this.txtInserir_TextChanged);
            this.txtInserir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInserir_KeyPress);
            // 
            // cmbTexto
            // 
            this.cmbTexto.FormattingEnabled = true;
            this.cmbTexto.Location = new System.Drawing.Point(120, 107);
            this.cmbTexto.Name = "cmbTexto";
            this.cmbTexto.Size = new System.Drawing.Size(256, 21);
            this.cmbTexto.TabIndex = 3;
            this.cmbTexto.SelectedIndexChanged += new System.EventHandler(this.cmbTexto_SelectedIndexChanged);
            // 
            // ptbImagem
            // 
            this.ptbImagem.Location = new System.Drawing.Point(120, 242);
            this.ptbImagem.Name = "ptbImagem";
            this.ptbImagem.Size = new System.Drawing.Size(256, 144);
            this.ptbImagem.TabIndex = 4;
            this.ptbImagem.TabStop = false;
            this.ptbImagem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(414, 287);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(117, 57);
            this.btnImagem.TabIndex = 5;
            this.btnImagem.Text = "Carregar imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.ptbImagem);
            this.Controls.Add(this.cmbTexto);
            this.Controls.Add(this.txtInserir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnInserir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtInserir;
        private System.Windows.Forms.ComboBox cmbTexto;
        private System.Windows.Forms.PictureBox ptbImagem;
        private System.Windows.Forms.Button btnImagem;
    }
}

