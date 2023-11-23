using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaVendas.CamadaNegocio;

namespace SistemaVendas.CamadaDados
{
    public class ProdutoDAO
    {
        public string Inserir(ProdutoBO dProduto)
        {
            string resp = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();
                string sqlInserir = "insert into produto (nome, preco, estoque) values ('" + dProduto.Nomeproduto + "', '" + dProduto.Precounitario + "', '" + dProduto.QtdeEstoque + "')";
                Console.WriteLine("SQL.....   " + sqlInserir);
                conexao.ExecutarComandoSql(sqlInserir);
            }
            catch (Exception ex)
            {
                resp = "Erro ao salvar!.... " + ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return resp;
        }


        public DataTable Mostrar()
        {
            //DataSet é um banco de dados em memória, retornado de uma fonte de dados 
            //e consiste de uma coleção de objetos, DataTable
            //MySqlDataAdapter usado para preencher um DataSet com linhas de uma 
            //consulta feita em um banco de dados, ou seja, é uma ponte entre o DataSet 
            //e o banco de dados MySQL para retornar e salvar dados

            DataTable DtResultado = new DataTable("Produto");
            Console.WriteLine("classe de D Mostrar..");
            MySqlConnection SqlCon = new MySqlConnection();
            DataSet dataSet;
            try
            {
                MySqlConnection conn = conn = new MySqlConnection("server = localhost; database = dbsiscomercio; uid = root; pwd =; ");
                string sqlConsultar = "select * from produto";
                Console.WriteLine("SQL.....   " + sqlConsultar);
                MySqlCommand comando = new MySqlCommand(sqlConsultar, conn);
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(comando);
                dataSet = new DataSet();
                sqlDat.Fill(dataSet);
                DtResultado = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                string resp = "Erro ao salvar!.... " + ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return DtResultado;
        }

        public string Editar(ProdutoBO dProduto)
        {
            string resp = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                //conexão objeto instanciado da classe Conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();
                string sqlEditar = "update produto set "
                 + "idproduto = '" + dProduto.Idproduto + "',"
                 + "nome = '" + dProduto.Nomeproduto + "',"
                 + "preco = '" + dProduto.Precounitario + "',"
                 + "estoque = '" + dProduto.QtdeEstoque + "' "
                 + "where idproduto = '" + dProduto.Idproduto + "'";
                Console.WriteLine("SQL.....   " + sqlEditar);
                conexao.ExecutarComandoSql(sqlEditar);
            }
            catch (Exception ex)
            {
                resp = "Erro ao salvar!.... " + ex.Message;
            }
            finally //finally sempre é executado
            {//verifica se a conexão esta aberta e fecha
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return resp;
        }

        public string Excluir(ProdutoBO dProduto)
        {
            string resp = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                //conexão objeto instanciado da classe Conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();
                string sqlDeletar = "delete from produto where idproduto = " + dProduto.Idproduto;
                Console.WriteLine("SQL.....   " + sqlDeletar);
                conexao.ExecutarComandoSql(sqlDeletar);
            }
            catch (Exception ex)
            {
                resp = "Erro ao salvar!.... " + ex.Message;
            }
            finally //finally sempre é executado
            {//verifica se a conexão esta aberta e fecha
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return resp;
        }

    }
}
