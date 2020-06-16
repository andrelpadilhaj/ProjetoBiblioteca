using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Biblioteca.Classes
{
    class Funcionario
    {
        public int Codigo { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string getData
        {
            get
            {
                return $"{ Codigo };{ Rg };{ Cpf };{ Nome };{ Email };{ Uf };{ Cep };{ Cidade };{ Bairro };{ Logradouro };{ Numero };{ Complemento }";
            }
        }
        public string getCoreData
        {
            get
            {
                return $"{ Codigo };{ Rg };{ Cpf };{ Nome };{ Email }";
            }
        }

        public void saveOnBase()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"insert into Funcionario (Rg, Cpf, Nome, Email, Uf, Cep, Cidade, Bairro, Logradouro, Numero, Complemento) " +
                                   $"values ('{ Rg }', '{ Cpf }', '{ Nome }', '{ Email }', '{ Uf }', '{ Cep }', '{ Cidade }', '{ Bairro }', '{ Logradouro }', '{ Numero }', '{ Complemento }');");
            }
        }

        public void update()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"update Funcionario " +
                                   $"set Rg = '{ Rg }', " +
                                   $"Cpf = '{ Cpf }', " +
                                   $"Nome = '{ Nome }', " +
                                   $"Email = '{ Email }', " +
                                   $"Uf = '{ Uf }', " +
                                   $"Cep = '{ Cep }', " +
                                   $"Cidade = '{ Cidade }', " +
                                   $"Bairro = '{ Bairro }', " +
                                   $"Logradouro = '{ Logradouro }', " +
                                   $"Numero = '{ Numero }', " +
                                   $"Complemento = '{ Complemento }' " +
                                   $"where Codigo = { Codigo };");
            }
        }

        public void delete()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"delete from Telefone_Funcionario " +
                                   $"where Cod_Funcionario like '%{ Codigo }%';");
                connection.Execute($"delete from Funcionario " +
                                   $"where Codigo like '%{ Codigo }%';");
            }
        }

        public List<Funcionario> getFuncionarios(string tipo, string pesquisa)
        {
            List<Funcionario> temp;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                temp = connection.Query<Funcionario>($"select f.Codigo, f.Rg, f.Cpf, f.Nome, f.Email, f.Uf, f.Cep, f.Cidade, f.Bairro, f.Logradouro, f.Numero, f.Complemento " +
                                        $"from Funcionario f " +
                                        $"where { tipo } like '%{ pesquisa }%';").ToList();
            }

            return temp;
        }
    }
}
