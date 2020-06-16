namespace Biblioteca.Forms
{
    partial class Editoras
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
            this.listEditoras = new System.Windows.Forms.ListBox();
            this.btnConsultarEditoras = new System.Windows.Forms.Button();
            this.btnAdicionarEditora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(271, 44);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(177, 20);
            this.txtConsulta.TabIndex = 20;
            // 
            // comboConsulta
            // 
            this.comboConsulta.FormattingEnabled = true;
            this.comboConsulta.Items.AddRange(new object[] {
            "Codigo",
            "Email"});
            this.comboConsulta.Location = new System.Drawing.Point(141, 43);
            this.comboConsulta.Name = "comboConsulta";
            this.comboConsulta.Size = new System.Drawing.Size(124, 21);
            this.comboConsulta.TabIndex = 19;
            this.comboConsulta.Text = "<modo de consulta>";
            // 
            // listEditoras
            // 
            this.listEditoras.FormattingEnabled = true;
            this.listEditoras.Location = new System.Drawing.Point(12, 70);
            this.listEditoras.Name = "listEditoras";
            this.listEditoras.Size = new System.Drawing.Size(436, 95);
            this.listEditoras.TabIndex = 18;
            this.listEditoras.DoubleClick += new System.EventHandler(this.listEditoras_DoubleClick);
            // 
            // btnConsultarEditoras
            // 
            this.btnConsultarEditoras.Location = new System.Drawing.Point(12, 41);
            this.btnConsultarEditoras.Name = "btnConsultarEditoras";
            this.btnConsultarEditoras.Size = new System.Drawing.Size(123, 23);
            this.btnConsultarEditoras.TabIndex = 17;
            this.btnConsultarEditoras.Text = "Consultar Editoras";
            this.btnConsultarEditoras.UseVisualStyleBackColor = true;
            this.btnConsultarEditoras.Click += new System.EventHandler(this.btnConsultarEditoras_Click);
            // 
            // btnAdicionarEditora
            // 
            this.btnAdicionarEditora.Location = new System.Drawing.Point(12, 12);
            this.btnAdicionarEditora.Name = "btnAdicionarEditora";
            this.btnAdicionarEditora.Size = new System.Drawing.Size(123, 23);
            this.btnAdicionarEditora.TabIndex = 16;
            this.btnAdicionarEditora.Text = "Adicionar Editora";
            this.btnAdicionarEditora.UseVisualStyleBackColor = true;
            this.btnAdicionarEditora.Click += new System.EventHandler(this.btnAdicionarEditora_Click);
            // 
            // Editoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 176);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.comboConsulta);
            this.Controls.Add(this.listEditoras);
            this.Controls.Add(this.btnConsultarEditoras);
            this.Controls.Add(this.btnAdicionarEditora);
            this.MaximumSize = new System.Drawing.Size(478, 215);
            this.MinimumSize = new System.Drawing.Size(478, 215);
            this.Name = "Editoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editoras";
            this.Activated += new System.EventHandler(this.btnConsultarEditoras_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtConsulta;
        private System.Windows.Forms.ComboBox comboConsulta;
        private System.Windows.Forms.ListBox listEditoras;
        private System.Windows.Forms.Button btnConsultarEditoras;
        private System.Windows.Forms.Button btnAdicionarEditora;
    }
}