using Biblioteca.Classes;
using Biblioteca.Forms.formEditoras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class Editoras : Form
    {
        List<Classes.Editora> lstEditora;
        public Editoras()
        {
            InitializeComponent();
        }

        private void updateEditoras()
        {
            listEditoras.DataSource = lstEditora;
            listEditoras.DisplayMember = "getCoreData";
        }

        private void btnAdicionarEditora_Click(object sender, EventArgs e)
        {
            AdicionarEditora ae = new AdicionarEditora();
            ae.ShowDialog();
        }

        private void btnConsultarEditoras_Click(object sender, EventArgs e)
        {
            if (comboConsulta.SelectedItem == null)
            {
                comboConsulta.SelectedIndex = 0;
            }


            Editora editora = new Editora();
            switch (comboConsulta.SelectedIndex)
            {
                case 0:
                    lstEditora = editora.getEditoras("Codigo", txtConsulta.Text);
                    break;
                case 1:
                    lstEditora = editora.getEditoras("Nome", txtConsulta.Text);
                    break;
                case 2:
                    lstEditora = editora.getEditoras("Email", txtConsulta.Text);
                    break;
            }

            updateEditoras();
        }

        private void listEditoras_DoubleClick(object sender, EventArgs e)
        {
            int i = listEditoras.SelectedIndex;
            InformacaoEditora infoEd = new InformacaoEditora(lstEditora[i].Codigo,
                                                             lstEditora[i].Nome,
                                                             lstEditora[i].Email,
                                                             lstEditora[i].Uf,
                                                             lstEditora[i].Cep,
                                                             lstEditora[i].Cidade,
                                                             lstEditora[i].Bairro,
                                                             lstEditora[i].Logradouro,
                                                             lstEditora[i].Numero,
                                                             lstEditora[i].Complemento);
            infoEd.ShowDialog();
        }
    }
}
