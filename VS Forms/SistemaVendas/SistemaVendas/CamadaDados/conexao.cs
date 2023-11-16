using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.CamadaDados
{
    public class Conexao
    {
        /*
             DROP DATABASE IF EXISTS `dbsiscomercio`;
             CREATE DATABASE IF NOT EXISTS `dbsiscomercio` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
             USE `dbsiscomercio`;
             DROP TABLE IF EXISTS `produto`;
             CREATE TABLE IF NOT EXISTS `produto` (
             `idproduto` int(11) NOT NULL AUTO_INCREMENT,
             `nome` varchar(30) NOT NULL,
             `preco` float NOT NULL,
             `estoque` int NOT NULL,
             PRIMARY KEY (`idproduto`)
             ) ENGINE=MyISAM DEFAULT CHARSET=latin1
        */

        private MySqlConnection conn;
        private DataTable data;
        MySqlDataAdapter da;
        private MySqlCommandBuilder cb;

        public void Conectar()
        {
            string caminho = "server = localhost; uid = root; database = dbsiscomercio; pwd=";

            if (conn != null)
            {
                conn.Close();
            }
            try
            {
                conn = new MySqlConnection(caminho);
                conn.Open();
                Console.WriteLine("Banco conectado e aberto");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("erro....." + ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public void ExecutarComandoSql(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            Console.WriteLine(comando.ExecuteNonQuery() == 1 ? "Operação executada com sucesso!" : "Registro não inserido");
            conn.Close();
        }
        public DataTable RetornoDataTable(string sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);
            return data;
        }
    }
}
