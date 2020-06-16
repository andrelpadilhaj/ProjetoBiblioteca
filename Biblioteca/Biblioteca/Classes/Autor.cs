using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;
using System;
using System.Windows.Forms;

namespace Biblioteca.Classes
{
    class Autor
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string dtNascimento { get; set; }

        public string getData
        {
            get
            {
                return $"Codigo: { codigo } - Nome: { nome } - Data de Nascimento: { dtNascimento }";
            }
        }

        public void saveOnBase()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"insert into Autor (Nome, Dt_Nascimento) " +
                                   $"values ('{ nome }', '{ dtNascimento }')");
            }
        }

        public List<Autor> getAutores(string tipo, string pesquisa)
        {
            List<Autor> temp;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                temp = connection.Query<Autor>($"select a.Codigo, a.Nome, a.Dt_Nascimento as dtNascimento " +
                                               $"from Autor a where { tipo } like '%{ pesquisa }%';").ToList();
            }

            return temp;
        }

        public void alterar()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"update Autor " +
                                   $"set nome = '{ nome }', " +
                                   $"dt_Nascimento = '{ dtNascimento }' " +
                                   $"where Codigo = { codigo };");
            }
        }

        internal void excluir()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"delete from Autor " +
                                   $"where codigo = { codigo }");
            }
        }
    }
}
