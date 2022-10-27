namespace WF_BuscaCep
{
    partial class BuscaCep
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
            this.CEP = new System.Windows.Forms.Label();
            this.TextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.TextBoxEndereco = new System.Windows.Forms.TextBox();
            this.TextBoxComplemento = new System.Windows.Forms.TextBox();
            this.TextBoxBairro = new System.Windows.Forms.TextBox();
            this.TextBoxCidade = new System.Windows.Forms.TextBox();
            this.TextBoxEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CEP
            // 
            this.CEP.AutoSize = true;
            this.CEP.Location = new System.Drawing.Point(33, 26);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(37, 16);
            this.CEP.TabIndex = 1;
            this.CEP.Text = " CEP";
            // 
            // TextBoxCep
            // 
            this.TextBoxCep.Location = new System.Drawing.Point(36, 54);
            this.TextBoxCep.Mask = "00000-000";
            this.TextBoxCep.Name = "TextBoxCep";
            this.TextBoxCep.Size = new System.Drawing.Size(159, 22);
            this.TextBoxCep.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(217, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(221, 30);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextBoxEndereco
            // 
            this.TextBoxEndereco.Location = new System.Drawing.Point(34, 122);
            this.TextBoxEndereco.Name = "TextBoxEndereco";
            this.TextBoxEndereco.Size = new System.Drawing.Size(404, 22);
            this.TextBoxEndereco.TabIndex = 4;
            // 
            // TextBoxComplemento
            // 
            this.TextBoxComplemento.Location = new System.Drawing.Point(36, 176);
            this.TextBoxComplemento.Name = "TextBoxComplemento";
            this.TextBoxComplemento.Size = new System.Drawing.Size(404, 22);
            this.TextBoxComplemento.TabIndex = 5;
            // 
            // TextBoxBairro
            // 
            this.TextBoxBairro.Location = new System.Drawing.Point(36, 232);
            this.TextBoxBairro.Name = "TextBoxBairro";
            this.TextBoxBairro.Size = new System.Drawing.Size(404, 22);
            this.TextBoxBairro.TabIndex = 7;
            // 
            // TextBoxCidade
            // 
            this.TextBoxCidade.Location = new System.Drawing.Point(36, 283);
            this.TextBoxCidade.Name = "TextBoxCidade";
            this.TextBoxCidade.Size = new System.Drawing.Size(404, 22);
            this.TextBoxCidade.TabIndex = 8;
            // 
            // TextBoxEstado
            // 
            this.TextBoxEstado.Location = new System.Drawing.Point(36, 338);
            this.TextBoxEstado.Name = "TextBoxEstado";
            this.TextBoxEstado.Size = new System.Drawing.Size(404, 22);
            this.TextBoxEstado.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = " Complemento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estado";
            // 
            // BuscaCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 396);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxEstado);
            this.Controls.Add(this.TextBoxCidade);
            this.Controls.Add(this.TextBoxBairro);
            this.Controls.Add(this.TextBoxComplemento);
            this.Controls.Add(this.TextBoxEndereco);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.TextBoxCep);
            this.Controls.Add(this.CEP);
            this.Name = "BuscaCep";
            this.Text = "Busca CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CEP;
        private System.Windows.Forms.MaskedTextBox TextBoxCep;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox TextBoxEndereco;
        private System.Windows.Forms.TextBox TextBoxComplemento;
        private System.Windows.Forms.TextBox TextBoxBairro;
        private System.Windows.Forms.TextBox TextBoxCidade;
        private System.Windows.Forms.TextBox TextBoxEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

