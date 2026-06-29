using APIAcademia.Model;
using Microsoft.EntityFrameworkCore;

namespace APIAcademia.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
    
        }

        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<ExercicioTreino> ExericiosTreino { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Manutencao> Manutencaoes { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<Unidade> Unidades { get; set; }  
    }
}
