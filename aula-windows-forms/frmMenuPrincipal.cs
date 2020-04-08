using aula_windows_forms.Formularios;
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

namespace aula_windows_forms
{
    public partial class frmMenuPrincipal : Form
    {
        private readonly RepositorioProduto _repositorioProduto = new RepositorioProduto();

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
            => frmListarProdutos.Listar(_repositorioProduto);
    }
}