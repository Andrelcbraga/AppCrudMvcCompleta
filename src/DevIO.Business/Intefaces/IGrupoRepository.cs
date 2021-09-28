using System;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Intefaces
{
    public interface IGrupoRepository : IRepository<Grupo>
    {
        Task<Grupo> ObterProdutoGrupo(Guid id);
        //Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}