using SistemaVendas.CamadaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.CamadaApresentacao
{
    public struct ProdutoStruct
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int QtdeEstoque { get; set; }
        public double Preco { get; set; }

        public ProdutoStruct(int id, string nome, double preco, int qtde)
        {
            this.IdProduto = id;
            this.Nome = nome;
            this.Preco = preco;
            this.QtdeEstoque = qtde;
        }

    }

    public partial class FrmProduto : Form
    {
        public ProdutoBO ItemProduto { get; set; }

        public FrmProduto()
        {
            ItemProduto = new ProdutoBO();
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            var id = txtCodigo.Text == " " ? Convert.ToInt32(txtCodigo.Text) : 0;
            ProdutoStruct ps = new ProdutoStruct(id, txtNome.Text, Convert.ToDouble(txtPreco.Text), Convert.ToInt32(txtEstoque.Text));
            ItemProduto.Inserir(ps);
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            var id = txtCodigo.Text == " " ? Convert.ToInt32(txtCodigo.Text) : 0;
            ProdutoStruct ps = new ProdutoStruct(id, txtNome.Text, Convert.ToDouble(txtPreco.Text), Convert.ToInt32(txtEstoque.Text));
            ItemProduto.Inserir(ps);
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
            txtEstoque.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ProdutoBO itemProduto = new ProdutoBO();
            this.dataGridView1.DataSource = itemProduto.Mostrar();
            txtTotalProdutos.Visible = true;
            txtTotalProdutos.Text = Convert.ToString(dataGridView1.Rows.Count);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ProdutoBO itemProduto = new ProdutoBO();
            ProdutoStruct ps = new ProdutoStruct(Convert.ToInt32(txtCodigo.Text), txtNome.Text, Convert.ToDouble(txtPreco.Text), Convert.ToInt32(txtEstoque.Text));
            itemProduto.Editar(ps);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ProdutoBO itemProduto = new ProdutoBO();
            itemProduto.Excluir(Convert.ToInt32(txtCodigo.Text));
        }
    }
}
