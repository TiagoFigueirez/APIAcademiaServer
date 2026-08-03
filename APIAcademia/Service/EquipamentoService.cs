using APIAcademia.Model;
using APIAcademia.Repositories.Interface;
using APIAcademia.Service.Interface;

namespace APIAcademia.Service
{
    public class EquipamentoService : IEquipamentoService
    {
        private readonly IUnitOfWork _wof;

        public EquipamentoService(IUnitOfWork wof)
        {
            _wof = wof;
        }

        public async Task<IEnumerable<Equipamento>> GetAllEquipamento()
        {
            return await _wof.EquipamentosRepository.GetAllAvailableAsync();
        }

        public async Task<Equipamento> GetEquipamento(int id)
        {
            var equipamento = await _wof.EquipamentosRepository.GetAsync(e => e.Id == id);

            if (equipamento == null)
                throw new KeyNotFoundException("Equipamento não encontrado");

            return equipamento;
        }
        public async Task<Equipamento> EquipamentoCreate(Equipamento equipamento)
        {
            var equipamentoCriado = _wof.EquipamentosRepository.Create(equipamento);
            await _wof.Commit();

            return equipamentoCriado;
        }
        public async Task<Equipamento> EquipamentoUpdate(int id, Equipamento equipamento)
        {
            var equipamentoUpdate = await _wof.EquipamentosRepository.GetAsync(e => e.Id==id);

            if (equipamento == null)
                throw new KeyNotFoundException("Equipamento não encontrado");

            var equipamentoUpdated = _wof.EquipamentosRepository.Update(equipamento);
            await _wof.Commit();

            return equipamentoUpdated;
        }

        public async Task<Equipamento> EquipamentoDelete(int id)
        {
            var equipamentoDelete = await _wof.EquipamentosRepository.GetAsync(a => a.Id == id);

            if (equipamentoDelete == null)
                throw new KeyNotFoundException("Aluno não encontrado para deletar");

            _wof.EquipamentosRepository.Delete(equipamentoDelete);
            await _wof.Commit();

            return equipamentoDelete;
        }
    }
}
