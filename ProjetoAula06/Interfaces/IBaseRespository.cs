using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06.Interfaces
{
    /// <summary>
    /// Interface de repositório genérico
    /// </summary>
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        void Exportar(TEntity obj);
        TEntity Importar();
    }
}
