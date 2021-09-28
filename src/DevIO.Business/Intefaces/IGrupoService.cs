using System;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Intefaces
{
    public interface IGrupoService : IDisposable
    {
        Task Adicionar(Grupo grupo);
        Task Atualizar(Grupo Grupo);
        Task Remover(Guid id);
    }
}