using APIAcademia.Model;

namespace APIAcademia.Service.Interface
{
    public interface  IProfessorService
    {
        Task<IEnumerable<Professor>> GetAllProfessor();
        Task<Professor> GetProfessor(int id);
        Task<Professor> ProfessorCreate(Professor professor);
        Task<Professor> ProfessorUpdate(int id, Professor professor);
        Task<Professor> ProfessorDelete(int id);
    }
}
