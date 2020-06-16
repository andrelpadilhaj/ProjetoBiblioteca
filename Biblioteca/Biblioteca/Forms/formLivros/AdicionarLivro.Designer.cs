namespace Biblioteca.Forms.formLivros
{
    partial class AdicionarLivro
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboAutor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboEditora = new System.Windows.Forms.ComboBox();
            this.lblPublicacao = new System.Windows.Forms.Label();
            this.dtPublicacao = new System.Windows.Forms.DateTimePicker();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(15, 169);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(324, 23);
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(180, 25);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(159, 20);
            this.txtGenero.TabIndex = 19;
            this.txtGenero.TextChanged += new System.EventHandler(this.txtGenero_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(177, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Genero";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 20);
            this.txtNome.TabIndex = 17;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Autor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboAutor
            // 
            this.comboAutor.FormattingEnabled = true;
            this.comboAutor.Location = new System.Drawing.Point(15, 64);
            this.comboAutor.Name = "comboAutor";
            this.comboAutor.Size = new System.Drawing.Size(159, 21);
            this.comboAutor.TabIndex = 22;
            this.comboAutor.SelectedIndexChanged += new System.EventHandler(this.comboAutor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Editora";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboEditora
            // 
            this.comboEditora.FormattingEnabled = true;
            this.comboEditora.Location = new System.Drawing.Point(180, 64);
            this.comboEditora.Name = "comboEditora";
            this.comboEditora.Size = new System.Drawing.Size(159, 21);
            this.comboEditora.TabIndex = 24;
            this.comboEditora.SelectedIndexChanged += new System.EventHandler(this.comboEditora_SelectedIndexChanged);
            // 
            // lblPublicacao
            // 
            this.lblPublicacao.AutoSize = true;
            this.lblPublicacao.Location = new System.Drawing.Point(12, 88);
            this.lblPublicacao.Name = "lblPublicacao";
            this.lblPublicacao.Size = new System.Drawing.Size(101, 13);
            this.lblPublicacao.TabIndex = 25;
            this.lblPublicacao.Text = "Data de Publicacao";
            this.lblPublicacao.Click += new System.EventHandler(this.lblPublicacao_Click);
            // 
            // dtPublicacao
            // 
            this.dtPublicacao.CustomFormat = "yyyy-MM-dd";
            this.dtPublicacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPublicacao.Location = new System.Drawing.Point(15, 104);
            this.dtPublicacao.Name = "dtPublicacao";
            this.dtPublicacao.Size = new System.Drawing.Size(159, 20);
            this.dtPublicacao.TabIndex = 26;
            this.dtPublicacao.ValueChanged += new System.EventHandler(this.dtPublicacao_ValueChanged);
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(177, 88);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(45, 13);
            this.lblPaginas.TabIndex = 27;
            this.lblPaginas.Text = "Paginas";
            this.lblPaginas.Click += new System.EventHandler(this.lblPaginas_Click);
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(180, 104);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(159, 20);
            this.txtPaginas.TabIndex = 28;
            this.txtPaginas.TextChanged += new System.EventHandler(this.txtPaginas_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 127);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 29;
            this.lblValor.Text = "Valor";
            this.lblValor.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(15, 143);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(159, 20);
            this.txtValor.TabIndex = 30;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // AdicionarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 210);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.dtPublicacao);
            this.Controls.Add(this.lblPublicacao);
            this.Controls.Add(this.comboEditora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.MaximumSize = new System.Drawing.Size(372, 249);
            this.MinimumSize = new System.Drawing.Size(372, 249);
            this.Name = "AdicionarLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdicionarLivro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboEditora;
        private System.Windows.Forms.Label lblPublicacao;
        private System.Windows.Forms.DateTimePicker dtPublicacao;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
    }
}