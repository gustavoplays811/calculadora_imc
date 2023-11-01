namespace calculadora_imc
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
            this.lbnPeso = new System.Windows.Forms.Label();
            this.lbnaltura = new System.Windows.Forms.Label();
            this.lbnSituacao = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbnPeso
            // 
            this.lbnPeso.AutoSize = true;
            this.lbnPeso.Location = new System.Drawing.Point(142, 143);
            this.lbnPeso.Name = "lbnPeso";
            this.lbnPeso.Size = new System.Drawing.Size(31, 13);
            this.lbnPeso.TabIndex = 0;
            this.lbnPeso.Text = "Peso";
            // 
            // lbnaltura
            // 
            this.lbnaltura.AutoSize = true;
            this.lbnaltura.Location = new System.Drawing.Point(142, 178);
            this.lbnaltura.Name = "lbnaltura";
            this.lbnaltura.Size = new System.Drawing.Size(34, 13);
            this.lbnaltura.TabIndex = 1;
            this.lbnaltura.Text = "Altura";
            // 
            // lbnSituacao
            // 
            this.lbnSituacao.AutoSize = true;
            this.lbnSituacao.Location = new System.Drawing.Point(192, 280);
            this.lbnSituacao.Name = "lbnSituacao";
            this.lbnSituacao.Size = new System.Drawing.Size(0, 13);
            this.lbnSituacao.TabIndex = 2;
            this.lbnSituacao.Click += new System.EventHandler(this.lbnSituacao_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(195, 218);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(100, 23);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(195, 178);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(100, 20);
            this.TxtAltura.TabIndex = 4;
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(195, 140);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(100, 20);
            this.TxtPeso.TabIndex = 5;
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(195, 247);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(100, 20);
            this.TxtResultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.lbnSituacao);
            this.Controls.Add(this.lbnaltura);
            this.Controls.Add(this.lbnPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnPeso;
        private System.Windows.Forms.Label lbnaltura;
        private System.Windows.Forms.Label lbnSituacao;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.TextBox TxtResultado;
    }
}

