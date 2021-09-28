using System;
using System.Threading.Tasks;
using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using DevIO.Business.Models.Validations;

namespace DevIO.Business.Services
{
    public class GrupoService : BaseService, IGrupoService
    {
        private readonly IGrupoRepository _grupoRepository;

        public GrupoService(IGrupoRepository grupoRepository,
                              INotificador notificador) : base(notificador)
        {
            _grupoRepository = grupoRepository;
        }

        public async Task Adicionar(Grupo grupo)
        {
            if (!ExecutarValidacao(new GrupoValidation(), grupo)) return;

            await _grupoRepository.Adicionar(grupo);
        }

        public async Task Atualizar(Grupo grupo)
        {
            if (!ExecutarValidacao(new GrupoValidation(), grupo)) return;

            await _grupoRepository.Atualizar(grupo);
        }

        public async Task Remover(Guid id)
        {
            await _grupoRepository.Remover(id);
        }

        public void Dispose()
        {
            _grupoRepository?.Dispose();
        }
    }
}