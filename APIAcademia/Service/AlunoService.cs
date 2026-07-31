using APIAcademia.Model;
using APIAcademia.Repositories.Interface;
using APIAcademia.Service.Interface;

namespace APIAcademia.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly IUnitOfWork _wof;

        public AlunoService(IUnitOfWork wof)
        {
            _wof = wof;
        }

        public async Task<IEnumerable<Aluno>> GetAllAluno()
        {
            return await _wof.AlunoRepository.GetAllAsync();
        }

        public async Task<Aluno> GetAluno(int id)
        {
            var aluno = await _wof.AlunoRepository.GetAsync(a => a.Id == id);

            if(aluno == null)
              throw new KeyNotFoundException("Aluno não encontrado");

            return aluno;
        }
        public async Task<Aluno> AlunoCreate(Aluno aluno)
        {

            var alunoCriado = _wof.AlunoRepository.Create(aluno);
            await _wof.Commit();

            return alunoCriado;
        }

        public async Task<Aluno> AlunoUpdate(int id, Aluno aluno)
        {
            var alunoUpdate = await _wof.AlunoRepository.GetAsync(a=> a.Id == id);

            if (alunoUpdate == null)
                throw new KeyNotFoundException("Aluno não encontrado");

           var alunoUpdated = _wof.AlunoRepository.Update(alunoUpdate);
            await _wof.Commit();

            return alunoUpdated;
        }

        public async Task<Aluno> AlunoDelete(int id)
        {
            var alunoDelete = await _wof.AlunoRepository.GetAsync(a => a.Id == id);

            if (alunoDelete == null)
                throw new KeyNotFoundException("Aluno não encontrado para deletar");

            _wof.AlunoRepository.Delete(alunoDelete);
            await _wof.Commit();

            return alunoDelete;
        }
    }
}
