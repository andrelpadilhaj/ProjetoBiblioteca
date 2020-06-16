using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Biblioteca.Classes
{
    class Cliente
    {
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
                return $"{ Cpf };{ Nome };{ Email };{ Uf };{ Cep };{ Cidade };{ Bairro };{ Logradouro };{ Numero };{ Complemento }";
            }
        }

        public string getCoreData
        {
            get
            {
                return $"{ Cpf };{ Nome };{ Email }";
            }
        }

        public void saveOnBase()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"insert into Cliente (Cpf, Nome, Email, Uf, Cep, Cidade, Bairro, Logradouro, Numero, Complemento) " +
                                   $"values ('{ Cpf }', '{ Nome }', '{ Email }', '{ Uf }', '{ Cep }', '{ Cidade }', '{ Bairro }', '{ Logradouro }', '{ Numero }', '{ Complemento }');");
            }
        }

        public void update()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"update Cliente " +
                                   $"set Cpf = '{ Cpf }', " +
                                   $"Nome = '{ Nome }', " +
                                   $"Email = '{ Email }', " +
                                   $"Uf = '{ Uf }', " +
                                   $"Cep = '{ Cep }', " +
                                   $"Cidade = '{ Cidade }', " +
                                   $"Bairro = '{ Bairro }', " +
                                   $"Logradouro = '{ Logradouro }', " +
                                   $"Numero = '{ Numero }', " +
                                   $"Complemento = '{ Complemento }' " +
                                   $"where Cpf like '%{ Cpf }%';");
            }
        }

        public void delete()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"delete from Telefone_Cliente " +
                                   $"where Cpf_Cliente like '%{ Cpf }%';");
                connection.Execute($"delete from Cliente " +
                                   $"where Cpf like '%{ Cpf }%';");
            }
        }

        public List<Cliente> getClientes(string tipo, string pesquisa)
        {
            List<Cliente> temp;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                temp = connection.Query<Cliente>($"select c.Cpf, c.Nome, c.Email, c.Uf, c.Cep, c.Cidade, c.Bairro, c.Logradouro, c.Numero, c.Complemento " +
                                        $"from Cliente c " +
                                        $"where { tipo } like '%{ pesquisa }%';").ToList();
            }

            return temp;
        }
	}
}
