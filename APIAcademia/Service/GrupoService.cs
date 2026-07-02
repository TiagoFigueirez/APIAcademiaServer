using APIAcademia.Model;
using APIAcademia.Repositories.Wof;
using APIAcademia.Service.Interface;

namespace APIAcademia.Service
{
    public class GrupoService : IGrupoService
    {
        private readonly IUnitOfWork _wof;

        public GrupoService(IUnitOfWork wof)
        {
            _wof = wof;
        }

        public async Task<IEnumerable<Grupo>> GetAllGrupo()
        {
            return await _wof.GrupoRepository.GetAllAsync();
        }

        public async Task<Grupo> GetGrupo(int id)
        {
            var grupoSelecionado = await _wof.GrupoRepository.GetAsync(g => g.Id == id);

            if (grupoSelecionado == null)
                throw new KeyNotFoundException("Grupo não encontrado");

            return grupoSelecionado;
        }

        public async Task<Grupo> GrupoCreate(Grupo grupo)
        {
            var grupoCreate = _wof.GrupoRepository.Create(grupo);
            await _wof.Commit();

            return grupoCreate;

        }

        public async Task<Grupo> GrupoUpdate(int id)
        {
            var grupoUpdate = await _wof.GrupoRepository.GetAsync(g => g.Id == id);

            if (grupoUpdate == null)
                throw new KeyNotFoundException("Grupo não encontrado para atualizar");

            var grupoUpdated = _wof.GrupoRepository.Update(grupoUpdate);
            await _wof.Commit();

            return grupoUpdated;
        }

        public async Task<Grupo> GrupoDelete(int id)
        {
            var grupoDelete = await _wof.GrupoRepository.GetAsync(g => g.Id == id);

            if (grupoDelete == null)
                throw new KeyNotFoundException("Grupo não encontrado para atualizar");

            grupoDelete.IsAti = false;

            var grupoDeleted = _wof.GrupoRepository.Update(grupoDelete);
            await _wof.Commit();

            return grupoDeleted;
        }
    }
}
