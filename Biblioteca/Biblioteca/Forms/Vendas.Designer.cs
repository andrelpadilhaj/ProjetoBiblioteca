namespace Biblioteca.Forms
{
    partial class Vendas
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
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnHistoricoVendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(12, 12);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(265, 36);
            this.btnNovaVenda.TabIndex = 0;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            // 
            // btnHistoricoVendas
            // 
            this.btnHistoricoVendas.Location = new System.Drawing.Point(12, 54);
            this.btnHistoricoVendas.Name = "btnHistoricoVendas";
            this.btnHistoricoVendas.Size = new System.Drawing.Size(265, 36);
            this.btnHistoricoVendas.TabIndex = 1;
            this.btnHistoricoVendas.Text = "Histórico de Vendas";
            this.btnHistoricoVendas.UseVisualStyleBackColor = true;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 101);
            this.Controls.Add(this.btnHistoricoVendas);
            this.Controls.Add(this.btnNovaVenda);
            this.MaximumSize = new System.Drawing.Size(305, 140);
            this.MinimumSize = new System.Drawing.Size(305, 140);
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Button btnHistoricoVendas;
    }
}