using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
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
            Console.WriteLine("\nInserindo Produto..........\n");
            this.Nomeproduto = prodStruct.Nome;
            this.Precounitario = prodStruct.Preco;
            this.QtdeEstoque = prodStruct.QtdeEstoque;
            return ProdutoDAO.Inserir(this);
        }

        public DataTable Mostrar()
        {
            return new ProdutoDAO().Mostrar();
        }

        public string Editar(ProdutoStruct prodStruct)
        {
            this.Idproduto = prodStruct.IdProduto;
            this.Nomeproduto = prodStruct.Nome;
            this.Precounitario = prodStruct.Preco;
            this.QtdeEstoque = prodStruct.QtdeEstoque;
            return ProdutoDAO.Editar(this);
        }
        public string Excluir(int idproduto)
        {
            this.Idproduto = idproduto;
            return ProdutoDAO.Excluir(this);
        }

    }
}
