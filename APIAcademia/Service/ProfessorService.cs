using APIAcademia.Model;
using APIAcademia.Repositories.Interface;
using APIAcademia.Service.Interface;

namespace APIAcademia.Service
{
    public class ProfessorService : IProfessorService
    {
        private readonly IUnitOfWork _wof;

        public ProfessorService(IUnitOfWork wof)
        {
            _wof = wof;
        }

        public Task<IEnumerable<Professor>> GetAllProfessor()
        {
            return _wof.ProfessorRepository.GetAllAvailableAsync();
        }

        public async Task<Professor> GetProfessor(int id)
        {
            var professor = await _wof.ProfessorRepository.GetAsync(p => p.Id == id);

            if (professor == null)
                throw new KeyNotFoundException("professor não encontrado");

            return professor;
        }

        public async Task<Professor> ProfessorCreate(Professor professor)
        {
            var professorCriado = _wof.ProfessorRepository.Create(professor);
            await _wof.Commit();

            return professorCriado;
        }

        public async Task<Professor> ProfessorUpdate(int id, Professor professor)
        {
            var professorUpdate = await _wof.ProfessorRepository.GetAsync(p => p.Id == id);

            if (professorUpdate == null)
                throw new KeyNotFoundException("professor não encontrado");

            var exercicioTreinoUpdated = _wof.ProfessorRepository.Update(professorUpdate);
            await _wof.Commit();

            return professorUpdate;
        }
        public async Task<Professor> ProfessorDelete(int id)
        {
            var professorDelete = await _wof.ProfessorRepository.GetAsync(e => e.Id == id);

            if (professorDelete == null)
                throw new KeyNotFoundException("professor não encontrado para deletar");

            _wof.ProfessorRepository.Delete(professorDelete);
            await _wof.Commit();

            return professorDelete;
        }
    }
}
