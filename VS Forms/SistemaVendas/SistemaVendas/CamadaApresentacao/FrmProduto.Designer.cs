namespace SistemaVendas.CamadaApresentacao
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new FontAwesome.Sharp.IconButton();
            this.btnAlterar = new FontAwesome.Sharp.IconButton();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInserir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tituloSistema = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFechar = new FontAwesome.Sharp.IconButton();
            this.txtLinhasTabela = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalProdutos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(300, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(947, 470);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnExcluir.IconColor = System.Drawing.Color.White;
            this.btnExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcluir.IconSize = 30;
            this.btnExcluir.Location = new System.Drawing.Point(1115, 562);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(132, 39);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAlterar.IconColor = System.Drawing.Color.Black;
            this.btnAlterar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlterar.Location = new System.Drawing.Point(300, 562);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(132, 39);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConsultar.IconColor = System.Drawing.Color.Black;
            this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultar.Location = new System.Drawing.Point(438, 562);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(132, 39);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.txtEstoque);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 613);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.btnInserir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 549);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 64);
            this.panel3.TabIndex = 19;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.White;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInserir.IconColor = System.Drawing.Color.Black;
            this.btnInserir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInserir.Location = new System.Drawing.Point(12, 13);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(247, 39);
            this.btnInserir.TabIndex = 17;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.tituloSistema);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 95);
            this.panel2.TabIndex = 18;
            // 
            // tituloSistema
            // 
            this.tituloSistema.AutoSize = true;
            this.tituloSistema.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloSistema.ForeColor = System.Drawing.Color.White;
            this.tituloSistema.Location = new System.Drawing.Point(38, 26);
            this.tituloSistema.Name = "tituloSistema";
            this.tituloSistema.Size = new System.Drawing.Size(199, 43);
            this.tituloSistema.TabIndex = 12;
            this.tituloSistema.Text = "WS.System";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(19, 367);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(240, 31);
            this.txtPreco.TabIndex = 15;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Location = new System.Drawing.Point(19, 296);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(240, 31);
            this.txtEstoque.TabIndex = 14;
            this.txtEstoque.TextChanged += new System.EventHandler(this.txtEstoque_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(19, 217);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 31);
            this.txtNome.TabIndex = 13;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(19, 144);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(240, 31);
            this.txtCodigo.TabIndex = 12;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preço unitário";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantidade de estoque";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome do produto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(295, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tabela de Produtos";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.IndianRed;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnFechar.IconColor = System.Drawing.Color.White;
            this.btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechar.IconSize = 20;
            this.btnFechar.Location = new System.Drawing.Point(1208, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(39, 39);
            this.btnFechar.TabIndex = 21;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtLinhasTabela
            // 
            this.txtLinhasTabela.AutoSize = true;
            this.txtLinhasTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinhasTabela.Location = new System.Drawing.Point(894, 567);
            this.txtLinhasTabela.Name = "txtLinhasTabela";
            this.txtLinhasTabela.Size = new System.Drawing.Size(0, 25);
            this.txtLinhasTabela.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(832, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total de Produtos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1026, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 24;
            // 
            // txtTotalProdutos
            // 
            this.txtTotalProdutos.AutoSize = true;
            this.txtTotalProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProdutos.Location = new System.Drawing.Point(1020, 567);
            this.txtTotalProdutos.Name = "txtTotalProdutos";
            this.txtTotalProdutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalProdutos.Size = new System.Drawing.Size(0, 25);
            this.txtTotalProdutos.TabIndex = 25;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 613);
            this.Controls.Add(this.txtTotalProdutos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLinhasTabela);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnExcluir;
        private FontAwesome.Sharp.IconButton btnAlterar;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tituloSistema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnInserir;
        private FontAwesome.Sharp.IconButton btnFechar;
        private System.Windows.Forms.Label txtLinhasTabela;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTotalProdutos;
    }
}