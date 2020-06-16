namespace Biblioteca.Forms.formFuncionarios
{
    partial class InformacaoFuncionario
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtAdicionarTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnRemoverTelefone = new System.Windows.Forms.Button();
            this.btnAdicionarTelefone = new System.Windows.Forms.Button();
            this.lblTelefones = new System.Windows.Forms.Label();
            this.listaTelefones = new System.Windows.Forms.ListBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupEndereco = new System.Windows.Forms.GroupBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.MaskedTextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(180, 312);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(159, 23);
            this.btnRemover.TabIndex = 39;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtAdicionarTelefone
            // 
            this.txtAdicionarTelefone.Location = new System.Drawing.Point(180, 107);
            this.txtAdicionarTelefone.Mask = "(99) 9 9999-9999";
            this.txtAdicionarTelefone.Name = "txtAdicionarTelefone";
            this.txtAdicionarTelefone.Size = new System.Drawing.Size(88, 20);
            this.txtAdicionarTelefone.TabIndex = 38;
            // 
            // btnRemoverTelefone
            // 
            this.btnRemoverTelefone.Location = new System.Drawing.Point(180, 140);
            this.btnRemoverTelefone.Name = "btnRemoverTelefone";
            this.btnRemoverTelefone.Size = new System.Drawing.Size(84, 23);
            this.btnRemoverTelefone.TabIndex = 37;
            this.btnRemoverTelefone.Text = "Remover";
            this.btnRemoverTelefone.UseVisualStyleBackColor = true;
            this.btnRemoverTelefone.Click += new System.EventHandler(this.btnRemoverTelefone_Click);
            // 
            // btnAdicionarTelefone
            // 
            this.btnAdicionarTelefone.Location = new System.Drawing.Point(274, 107);
            this.btnAdicionarTelefone.Name = "btnAdicionarTelefone";
            this.btnAdicionarTelefone.Size = new System.Drawing.Size(65, 23);
            this.btnAdicionarTelefone.TabIndex = 36;
            this.btnAdicionarTelefone.Text = "Adicionar";
            this.btnAdicionarTelefone.UseVisualStyleBackColor = true;
            this.btnAdicionarTelefone.Click += new System.EventHandler(this.btnAdicionarTelefone_Click);
            // 
            // lblTelefones
            // 
            this.lblTelefones.AutoSize = true;
            this.lblTelefones.Location = new System.Drawing.Point(12, 91);
            this.lblTelefones.Name = "lblTelefones";
            this.lblTelefones.Size = new System.Drawing.Size(54, 13);
            this.lblTelefones.TabIndex = 35;
            this.lblTelefones.Text = "Telefones";
            // 
            // listaTelefones
            // 
            this.listaTelefones.FormattingEnabled = true;
            this.listaTelefones.Location = new System.Drawing.Point(15, 107);
            this.listaTelefones.Name = "listaTelefones";
            this.listaTelefones.Size = new System.Drawing.Size(159, 56);
            this.listaTelefones.TabIndex = 34;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(15, 312);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(159, 23);
            this.btnAlterar.TabIndex = 33;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // groupEndereco
            // 
            this.groupEndereco.Controls.Add(this.txtComplemento);
            this.groupEndereco.Controls.Add(this.lblComplemento);
            this.groupEndereco.Controls.Add(this.lblNumero);
            this.groupEndereco.Controls.Add(this.txtNumero);
            this.groupEndereco.Controls.Add(this.txtLogradouro);
            this.groupEndereco.Controls.Add(this.lblLogradouro);
            this.groupEndereco.Controls.Add(this.lblBairro);
            this.groupEndereco.Controls.Add(this.txtBairro);
            this.groupEndereco.Controls.Add(this.txtCidade);
            this.groupEndereco.Controls.Add(this.lblCidade);
            this.groupEndereco.Controls.Add(this.txtCep);
            this.groupEndereco.Controls.Add(this.lblCep);
            this.groupEndereco.Controls.Add(this.txtUf);
            this.groupEndereco.Controls.Add(this.lblUf);
            this.groupEndereco.Location = new System.Drawing.Point(15, 169);
            this.groupEndereco.Name = "groupEndereco";
            this.groupEndereco.Size = new System.Drawing.Size(324, 137);
            this.groupEndereco.TabIndex = 32;
            this.groupEndereco.TabStop = false;
            this.groupEndereco.Text = "Endereço";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(6, 110);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(312, 20);
            this.txtComplemento.TabIndex = 19;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(3, 94);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 18;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(256, 55);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(259, 71);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(59, 20);
            this.txtNumero.TabIndex = 17;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(6, 71);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(247, 20);
            this.txtLogradouro.TabIndex = 16;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(3, 55);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 15;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(215, 16);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 14;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(218, 32);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(99, 32);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(113, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(96, 16);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 11;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(31, 32);
            this.txtCep.Mask = "99,999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(62, 20);
            this.txtCep.TabIndex = 10;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(28, 16);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(26, 13);
            this.lblCep.TabIndex = 2;
            this.lblCep.Text = "Cep";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(6, 32);
            this.txtUf.Mask = "aa";
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(19, 20);
            this.txtUf.TabIndex = 1;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(6, 16);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(18, 13);
            this.lblUf.TabIndex = 0;
            this.lblUf.Text = "Uf";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(180, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 31;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(177, 48);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 20);
            this.txtNome.TabIndex = 29;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Nome";
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Location = new System.Drawing.Point(198, 25);
            this.txtCpf.Mask = "999,999,999-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(83, 20);
            this.txtCpf.TabIndex = 27;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(195, 9);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(23, 13);
            this.lblCpf.TabIndex = 26;
            this.lblCpf.Text = "Cpf";
            // 
            // txtRg
            // 
            this.txtRg.Enabled = false;
            this.txtRg.Location = new System.Drawing.Point(121, 25);
            this.txtRg.Mask = "99,999,999-9";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(71, 20);
            this.txtRg.TabIndex = 40;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(15, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 41;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(118, 9);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(21, 13);
            this.lblRg.TabIndex = 42;
            this.lblRg.Text = "Rg";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 43;
            this.lblCodigo.Text = "Codigo";
            // 
            // InformacaoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 349);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtAdicionarTelefone);
            this.Controls.Add(this.btnRemoverTelefone);
            this.Controls.Add(this.btnAdicionarTelefone);
            this.Controls.Add(this.lblTelefones);
            this.Controls.Add(this.listaTelefones);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf);
            this.MaximumSize = new System.Drawing.Size(373, 388);
            this.MinimumSize = new System.Drawing.Size(373, 388);
            this.Name = "InformacaoFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InformacaoFuncionario";
            this.groupEndereco.ResumeLayout(false);
            this.groupEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.MaskedTextBox txtAdicionarTelefone;
        private System.Windows.Forms.Button btnRemoverTelefone;
        private System.Windows.Forms.Button btnAdicionarTelefone;
        private System.Windows.Forms.Label lblTelefones;
        private System.Windows.Forms.ListBox listaTelefones;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox groupEndereco;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.MaskedTextBox txtUf;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCodigo;
    }
}