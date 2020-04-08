using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_windows_forms.Interfaces
{
    public interface IRepositorioGenerico<T>
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        ICollection<T> GetAll();
    }
}