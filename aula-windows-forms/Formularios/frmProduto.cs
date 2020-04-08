using aula_windows_forms.Entidades;
using aula_windows_forms.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_windows_forms.Formularios
{
    public partial class frmProduto : Form
    {
        private Produto _produto;
        private RepositorioProduto _repositorio;

        private frmProduto(RepositorioProduto repositorio)
        {
            InitializeComponent();
            _repositorio = repositorio;
        }

        private frmProduto(RepositorioProduto repositorio, Produto produto)
        {
            InitializeComponent();
            _repositorio = repositorio;
            _produto = produto;
            txbDescricao.Text = produto.Descricao;
            txbValor.Text = produto.Valor.ToString();
        }

        public static void Cadastrar(RepositorioProduto repositorio)
        {
            var formulario = new frmProduto(repositorio);
            formulario.ShowDialog();
        }

        public static void Editar(RepositorioProduto repositorio, Produto produto)
        {
            var formulario = new frmProduto(repositorio, produto);
            formulario.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_produto == null)
                    CadastrarProduto();
                else
                    AtualizarProduto();
                Close();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CadastrarProduto()
            => _repositorio.Add(new Produto(txbDescricao.Text, GetValorProduto()));

        private void AtualizarProduto()
        {
            _produto.AlterarDescricao(txbDescricao.Text);
            _produto.AlterarValor(GetValorProduto());
            _repositorio.Update(_produto);
        }

        private decimal GetValorProduto()
        {
            decimal.TryParse(txbValor.Text, out decimal result);
            return result;
        }
    }
}