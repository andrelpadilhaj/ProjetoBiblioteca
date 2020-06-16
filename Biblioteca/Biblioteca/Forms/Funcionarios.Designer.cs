namespace Biblioteca.Forms
{
    partial class Funcionarios
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
            this.txtConsulta = new System.Windows.Forms.MaskedTextBox();
            this.comboConsulta = new System.Windows.Forms.ComboBox();
            this.listFuncionarios = new System.Windows.Forms.ListBox();
            this.btnConsultarFuncionarios = new System.Windows.Forms.Button();
            this.btnAdicionarFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(271, 44);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(177, 20);
            this.txtConsulta.TabIndex = 15;
            // 
            // comboConsulta
            // 
            this.comboConsulta.FormattingEnabled = true;
            this.comboConsulta.Items.AddRange(new object[] {
            "Codigo",
            "Rg",
            "Cpf",
            "Nome",
            "Email"});
            this.comboConsulta.Location = new System.Drawing.Point(141, 43);
            this.comboConsulta.Name = "comboConsulta";
            this.comboConsulta.Size = new System.Drawing.Size(124, 21);
            this.comboConsulta.TabIndex = 14;
            this.comboConsulta.Text = "<modo de consulta>";
            // 
            // listFuncionarios
            // 
            this.listFuncionarios.FormattingEnabled = true;
            this.listFuncionarios.Location = new System.Drawing.Point(12, 70);
            this.listFuncionarios.Name = "listFuncionarios";
            this.listFuncionarios.Size = new System.Drawing.Size(436, 95);
            this.listFuncionarios.TabIndex = 13;
            this.listFuncionarios.DoubleClick += new System.EventHandler(this.listFuncionarios_DoubleClick);
            // 
            // btnConsultarFuncionarios
            // 
            this.btnConsultarFuncionarios.Location = new System.Drawing.Point(12, 41);
            this.btnConsultarFuncionarios.Name = "btnConsultarFuncionarios";
            this.btnConsultarFuncionarios.Size = new System.Drawing.Size(123, 23);
            this.btnConsultarFuncionarios.TabIndex = 12;
            this.btnConsultarFuncionarios.Text = "Consultar Funcionários";
            this.btnConsultarFuncionarios.UseVisualStyleBackColor = true;
            this.btnConsultarFuncionarios.Click += new System.EventHandler(this.btnConsultarFuncionarios_Click);
            // 
            // btnAdicionarFuncionario
            // 
            this.btnAdicionarFuncionario.Location = new System.Drawing.Point(12, 12);
            this.btnAdicionarFuncionario.Name = "btnAdicionarFuncionario";
            this.btnAdicionarFuncionario.Size = new System.Drawing.Size(123, 23);
            this.btnAdicionarFuncionario.TabIndex = 11;
            this.btnAdicionarFuncionario.Text = "Adicionar Funcionario";
            this.btnAdicionarFuncionario.UseVisualStyleBackColor = true;
            this.btnAdicionarFuncionario.Click += new System.EventHandler(this.btnAdicionarFuncionario_Click);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 179);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.comboConsulta);
            this.Controls.Add(this.listFuncionarios);
            this.Controls.Add(this.btnConsultarFuncionarios);
            this.Controls.Add(this.btnAdicionarFuncionario);
            this.Name = "Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Funcionarios";
            this.Activated += new System.EventHandler(this.btnConsultarFuncionarios_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtConsulta;
        private System.Windows.Forms.ComboBox comboConsulta;
        private System.Windows.Forms.ListBox listFuncionarios;
        private System.Windows.Forms.Button btnConsultarFuncionarios;
        private System.Windows.Forms.Button btnAdicionarFuncionario;
    }
}