using APIAcademia.Model;

namespace APIAcademia.Service.Interface
{
    public interface IAlunoService
    {
        Task<IEnumerable<Aluno>> GetAllAluno();
        Task<Aluno> GetAluno(int id);
        Task<Aluno> AlunoCreate(Aluno aluno);
        Task<Aluno> AlunoUpdate(int id, Aluno aluno);
        Task<Aluno> AlunoDelete(int id);
    }
}
