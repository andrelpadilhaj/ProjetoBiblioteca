namespace Biblioteca.Forms
{
    partial class Autores
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
            this.btnAdicionarAutor = new System.Windows.Forms.Button();
            this.btnConsultarAutores = new System.Windows.Forms.Button();
            this.listAutores = new System.Windows.Forms.ListBox();
            this.comboConsulta = new System.Windows.Forms.ComboBox();
            this.txtConsulta = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnAdicionarAutor
            // 
            this.btnAdicionarAutor.Location = new System.Drawing.Point(12, 12);
            this.btnAdicionarAutor.Name = "btnAdicionarAutor";
            this.btnAdicionarAutor.Size = new System.Drawing.Size(98, 23);
            this.btnAdicionarAutor.TabIndex = 0;
            this.btnAdicionarAutor.Text = "Adicionar Autor";
            this.btnAdicionarAutor.UseVisualStyleBackColor = true;
            this.btnAdicionarAutor.Click += new System.EventHandler(this.btnAdicionarAutor_Click);
            // 
            // btnConsultarAutores
            // 
            this.btnConsultarAutores.Location = new System.Drawing.Point(12, 41);
            this.btnConsultarAutores.Name = "btnConsultarAutores";
            this.btnConsultarAutores.Size = new System.Drawing.Size(98, 23);
            this.btnConsultarAutores.TabIndex = 1;
            this.btnConsultarAutores.Text = "Consultar Autores";
            this.btnConsultarAutores.UseVisualStyleBackColor = true;
            this.btnConsultarAutores.Click += new System.EventHandler(this.btnConsultarAutores_Click);
            // 
            // listAutores
            // 
            this.listAutores.FormattingEnabled = true;
            this.listAutores.Location = new System.Drawing.Point(12, 70);
            this.listAutores.Name = "listAutores";
            this.listAutores.Size = new System.Drawing.Size(436, 95);
            this.listAutores.TabIndex = 2;
            this.listAutores.DoubleClick += new System.EventHandler(this.listAutores_DoubleClick);
            // 
            // comboConsulta
            // 
            this.comboConsulta.FormattingEnabled = true;
            this.comboConsulta.Items.AddRange(new object[] {
            "Codigo",
            "Nome",
            "Nascimento"});
            this.comboConsulta.Location = new System.Drawing.Point(116, 43);
            this.comboConsulta.Name = "comboConsulta";
            this.comboConsulta.Size = new System.Drawing.Size(123, 21);
            this.comboConsulta.TabIndex = 3;
            this.comboConsulta.Text = "<modo de consulta>";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(245, 44);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(203, 20);
            this.txtConsulta.TabIndex = 5;
            // 
            // Autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 177);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.comboConsulta);
            this.Controls.Add(this.listAutores);
            this.Controls.Add(this.btnConsultarAutores);
            this.Controls.Add(this.btnAdicionarAutor);
            this.MaximumSize = new System.Drawing.Size(476, 216);
            this.MinimumSize = new System.Drawing.Size(476, 216);
            this.Name = "Autores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autores";
            this.Activated += new System.EventHandler(this.btnConsultarAutores_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarAutor;
        private System.Windows.Forms.Button btnConsultarAutores;
        private System.Windows.Forms.ListBox listAutores;
        private System.Windows.Forms.ComboBox comboConsulta;
        private System.Windows.Forms.MaskedTextBox txtConsulta;
    }
}