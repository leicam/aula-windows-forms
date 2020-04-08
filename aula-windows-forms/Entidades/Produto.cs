using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_windows_forms.Entidades
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }

        public Produto(string descricao, decimal valor)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            Valor = valor;
        }

        public void AlterarDescricao(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new ArgumentException("Descrição inválida!");

            Descricao = descricao;
        }

        public void AlterarValor(decimal valor)
        {
            if (valor <= 0.0m)
                throw new ArgumentException("Valor inválido!");

            Valor = valor;
        }
    }
}