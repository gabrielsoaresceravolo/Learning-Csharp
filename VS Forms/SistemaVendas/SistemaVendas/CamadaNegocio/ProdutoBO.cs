using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVendas.CamadaApresentacao;
using SistemaVendas.CamadaDados;

namespace SistemaVendas.CamadaNegocio
{
    public class ProdutoBO
    {
        public int Idproduto { get; set; }
        public string Nomeproduto { get; set; }
        public double Precounitario { get; set; }
        public int QtdeEstoque { get; set; }
        public ProdutoDAO ProdutoDAO { get; set; }
        public ProdutoBO()
        {
            ProdutoDAO = new ProdutoDAO();
        }
        public string Inserir(ProdutoStruct prodStruct)
        {
            Console.WriteLine("nproduto inserir..........");
            this.Nomeproduto = prodStruct.Nome;
            this.Precounitario = prodStruct.Preco;
            this.QtdeEstoque = prodStruct.QtdeEstoque;
            return ProdutoDAO.Inserir(this);
        }

        public DataTable Mostrar()
        {
            return new ProdutoDAO().Mostrar();
        }
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Produto");
            Console.WriteLine("classe de D Mostrar..");
            MySqlConnection SqlCon = new MySqlConnection();
            DataSet dataSet;
            try
            {
                MySqlConnection conn = conn = new MySqlConnection("server = localhost; database = dbsiscomercio; uid = root; pwd =; ");
                //string sqlConsultar = "select * produto where nomeproduto like " + dProduto.Nomeproduto;// + "%'";
                string sqlConsultar = "select * from produto";
                Console.WriteLine("SQL.....   " + sqlConsultar);
                MySqlCommand comando = new MySqlCommand(sqlConsultar, conn);
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(comando);//passa o resultado para a grid
                dataSet = new DataSet();
                //médoto Fill adiciona ou atualiza linhas no DataSet
                sqlDat.Fill(dataSet);//preenche a grid DtResultado
                DtResultado = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                string resp = "Erro ao salvar!.... " + ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();

                }
            }
            return DtResultado;
        }

    }
}
