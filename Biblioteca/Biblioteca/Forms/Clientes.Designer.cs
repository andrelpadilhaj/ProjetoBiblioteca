using System.Diagnostics.Tracing;

namespace Biblioteca.Forms
{
    partial class Clientes
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
            this.listClientes = new System.Windows.Forms.ListBox();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(255, 44);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(193, 20);
            this.txtConsulta.TabIndex = 10;
            // 
            // comboConsulta
            // 
            this.comboConsulta.FormattingEnabled = true;
            this.comboConsulta.Items.AddRange(new object[] {
            "Cpf",
            "Nome"});
            this.comboConsulta.Location = new System.Drawing.Point(123, 43);
            this.comboConsulta.Name = "comboConsulta";
            this.comboConsulta.Size = new System.Drawing.Size(126, 21);
            this.comboConsulta.TabIndex = 9;
            this.comboConsulta.Text = "<modo de consulta>";
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(12, 70);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(436, 95);
            this.listClientes.TabIndex = 8;
            this.listClientes.DoubleClick += new System.EventHandler(this.listClientes_SelectedCoubleClick);
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.Location = new System.Drawing.Point(12, 41);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(105, 23);
            this.btnConsultarClientes.TabIndex = 7;
            this.btnConsultarClientes.Text = "Consultar Clientes";
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.Location = new System.Drawing.Point(12, 12);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(98, 23);
            this.btnAdicionarCliente.TabIndex = 6;
            this.btnAdicionarCliente.Text = "Adicionar Cliente";
            this.btnAdicionarCliente.UseVisualStyleBackColor = true;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 180);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.comboConsulta);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.btnConsultarClientes);
            this.Controls.Add(this.btnAdicionarCliente);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes";
            this.Activated += new System.EventHandler(this.btnConsultarClientes_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtConsulta;
        private System.Windows.Forms.ComboBox comboConsulta;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.Button btnAdicionarCliente;
    }
}