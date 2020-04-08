using aula_windows_forms.Entidades;
using aula_windows_forms.Repositorios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_windows_forms.Formularios
{
    public partial class frmListarProdutos : Form
    {
        private readonly RepositorioProduto _repositorioProduto;

        private frmListarProdutos(RepositorioProduto repositorio)
        {
            InitializeComponent();
            _repositorioProduto = repositorio;
        }

        public static void Listar(RepositorioProduto repositorio)
        {
            var listagem = new frmListarProdutos(repositorio);
            listagem.ShowDialog();
        }

        private void frmListarProdutos_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmProduto.Cadastrar(_repositorioProduto);
            CarregarProdutos();
        }

        private void CarregarProdutos() 
            => dgvProduto.DataSource = _repositorioProduto.GetAll().ToList();

        private void RecarregarProdutos()
            => dgvProduto.Refresh();

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmProduto.Editar(_repositorioProduto, dgvProduto.CurrentRow.DataBoundItem as Produto);
            RecarregarProdutos();
        }
    }
}
