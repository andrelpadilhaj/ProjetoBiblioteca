using Biblioteca.Classes;
using Biblioteca.Forms.formFuncionarios;
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
    public partial class Funcionarios : Form
    {
        List<Funcionario> lstFuncionario;
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void upateFuncionarios()
        {
            listFuncionarios.DataSource = lstFuncionario;
            listFuncionarios.DisplayMember = "getCoreData";
        }

        private void btnAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario funcionario = new AdicionarFuncionario();
            funcionario.ShowDialog();
        }

        private void btnConsultarFuncionarios_Click(object sender, EventArgs e)
        {
            if (comboConsulta.SelectedItem == null)
            {
                comboConsulta.SelectedIndex = 0;
            }

            switch (comboConsulta.SelectedIndex)
            {
                case 0:
                    lstFuncionario = new Funcionario().getFuncionarios("Codigo", txtConsulta.Text);
                    break;
                case 1:
                    lstFuncionario = new Funcionario().getFuncionarios("Rg", txtConsulta.Text);
                    break;
                case 2:
                    lstFuncionario = new Funcionario().getFuncionarios("Cpf", txtConsulta.Text);
                    break;
                case 3:
                    lstFuncionario = new Funcionario().getFuncionarios("Nome", txtConsulta.Text);
                    break;
                case 4:
                    lstFuncionario = new Funcionario().getFuncionarios("Email", txtConsulta.Text);
                    break;
            }

            this.upateFuncionarios();
        }

        private void listFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            int i = listFuncionarios.SelectedIndex;
            InformacaoFuncionario infoFc = new InformacaoFuncionario(lstFuncionario[i].Codigo,
                                                                     lstFuncionario[i].Rg,
                                                                     lstFuncionario[i].Cpf,
                                                                     lstFuncionario[i].Nome,
                                                                     lstFuncionario[i].Email,
                                                                     lstFuncionario[i].Uf,
                                                                     lstFuncionario[i].Cep,
                                                                     lstFuncionario[i].Cidade,
                                                                     lstFuncionario[i].Bairro,
                                                                     lstFuncionario[i].Logradouro,
                                                                     lstFuncionario[i].Numero,
                                                                     lstFuncionario[i].Complemento);
            infoFc.ShowDialog();
        }
    }
}
