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
    }
}
