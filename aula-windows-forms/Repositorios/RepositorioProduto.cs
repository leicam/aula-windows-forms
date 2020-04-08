using aula_windows_forms.Entidades;
using aula_windows_forms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_windows_forms.Repositorios
{
    public class RepositorioProduto : IRepositorioGenerico<Produto>
    {
        private List<Produto> _produtos = new List<Produto>();

        public void Add(Produto entity) => _produtos.Add(entity);
        public ICollection<Produto> GetAll() => _produtos;
        public void Remove(Produto entity) => _produtos.Remove(entity);

        public void Update(Produto entity)
        {
            Remove(GetAll().FirstOrDefault(x => x.Id.Equals(entity.Id)));
            Add(entity);
        }
    }
}