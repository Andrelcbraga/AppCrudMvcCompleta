using System;
using System.Threading.Tasks;
using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Data.Repository
{
    public class GrupoRepository : Repository<Grupo>, IGrupoRepository
    {
        public GrupoRepository(MeuDbContext context) : base(context)
        {

        }

        public async Task<Grupo> ObterProdutoGrupo(Guid id)
        {
            return await Db.Grupos.AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);
        }

    }
}