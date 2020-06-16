namespace Biblioteca.Forms.formLivros
{
    partial class InformacaoLivro
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.dtPublicacao = new System.Windows.Forms.DateTimePicker();
            this.lblPublicacao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAutor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.listEditoras = new System.Windows.Forms.ListBox();
            this.btnExcluirEditora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(180, 179);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(159, 20);
            this.txtValor.TabIndex = 45;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(177, 163);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 44;
            this.lblValor.Text = "Valor";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Enabled = false;
            this.txtPaginas.Location = new System.Drawing.Point(15, 179);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(159, 20);
            this.txtPaginas.TabIndex = 43;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(12, 163);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(45, 13);
            this.lblPaginas.TabIndex = 42;
            this.lblPaginas.Text = "Paginas";
            // 
            // dtPublicacao
            // 
            this.dtPublicacao.CustomFormat = "yyyy-MM-dd";
            this.dtPublicacao.Enabled = false;
            this.dtPublicacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPublicacao.Location = new System.Drawing.Point(180, 104);
            this.dtPublicacao.Name = "dtPublicacao";
            this.dtPublicacao.Size = new System.Drawing.Size(159, 20);
            this.dtPublicacao.TabIndex = 41;
            // 
            // lblPublicacao
            // 
            this.lblPublicacao.AutoSize = true;
            this.lblPublicacao.Location = new System.Drawing.Point(177, 88);
            this.lblPublicacao.Name = "lblPublicacao";
            this.lblPublicacao.Size = new System.Drawing.Size(101, 13);
            this.lblPublicacao.TabIndex = 40;
            this.lblPublicacao.Text = "Data de Publicacao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Editora";
            // 
            // comboAutor
            // 
            this.comboAutor.Enabled = false;
            this.comboAutor.FormattingEnabled = true;
            this.comboAutor.Location = new System.Drawing.Point(180, 64);
            this.comboAutor.Name = "comboAutor";
            this.comboAutor.Size = new System.Drawing.Size(159, 21);
            this.comboAutor.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Autor";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(15, 205);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(159, 23);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(15, 65);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(159, 20);
            this.txtGenero.TabIndex = 34;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 48);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Genero";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(180, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 20);
            this.txtNome.TabIndex = 32;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(177, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 31;
            this.lblNome.Text = "Nome";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(180, 205);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(161, 23);
            this.btnExcluir.TabIndex = 46;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(15, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(159, 20);
            this.txtCodigo.TabIndex = 47;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 48;
            this.lblCodigo.Text = "Codigo";
            // 
            // listEditoras
            // 
            this.listEditoras.FormattingEnabled = true;
            this.listEditoras.Location = new System.Drawing.Point(15, 104);
            this.listEditoras.Name = "listEditoras";
            this.listEditoras.Size = new System.Drawing.Size(159, 56);
            this.listEditoras.TabIndex = 49;
            // 
            // btnExcluirEditora
            // 
            this.btnExcluirEditora.Location = new System.Drawing.Point(180, 137);
            this.btnExcluirEditora.Name = "btnExcluirEditora";
            this.btnExcluirEditora.Size = new System.Drawing.Size(159, 23);
            this.btnExcluirEditora.TabIndex = 50;
            this.btnExcluirEditora.Text = "Excluir Editora";
            this.btnExcluirEditora.UseVisualStyleBackColor = true;
            this.btnExcluirEditora.Click += new System.EventHandler(this.btnExcluirEditora_Click);
            // 
            // InformacaoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 243);
            this.Controls.Add(this.btnExcluirEditora);
            this.Controls.Add(this.listEditoras);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.dtPublicacao);
            this.Controls.Add(this.lblPublicacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "InformacaoLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InformacaoLivro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.DateTimePicker dtPublicacao;
        private System.Windows.Forms.Label lblPublicacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ListBox listEditoras;
        private System.Windows.Forms.Button btnExcluirEditora;
    }
}