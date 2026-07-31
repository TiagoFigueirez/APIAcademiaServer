using APIAcademia.Model;

namespace APIAcademia.Service.Interface
{
    public interface IEquipamentoService
    {
        Task<IEnumerable<Equipamento>> GetAllEquipamento();
        Task<Equipamento> GetEquipamento(int id);
        Task<Equipamento> EquipamentoCreate(Equipamento equipamento);
        Task<Equipamento> EquipamentoUpdate(int id, Equipamento equipamento);
        Task<Equipamento> EquipamentoDelete(int id);
    }
}
