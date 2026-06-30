using APIAcademia.Model;
using Microsoft.EntityFrameworkCore;

namespace APIAcademia.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base (options)
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasOne(u => u.Grupo)
                .WithMany(g => g.Usuarios)
                .HasForeignKey(u => u.GrupoAcessoId)
                .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(u => u.Funcionario)
                .WithOne(f => f.Usuario)
                .HasForeignKey<Usuario>(u => u.FuncionarioId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasOne(a => a.Unidade)
                .WithMany(u => u.Alunos)
                .HasForeignKey(a => a.UnidadeId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.HasOne(a => a.Unidade)
                .WithMany(u => u.Equipamentos)
                .HasForeignKey(a => a.UnidadeId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Exercicio>(entity =>
            {
                entity.HasOne(e => e.Equipamento)
                .WithMany(e => e.Exercicios)
                .HasForeignKey(e => e.EquipamentoId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<ExercicioTreino>(entity =>
            {
                entity.HasOne(e => e.Exercicio)
                .WithOne(e => e.EquipamentoTreino)
                .HasForeignKey<ExercicioTreino>(e => e.ExercicioId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Treino>(entity =>
            {
                entity.HasOne(a => a.Aluno)
                .WithMany(t => t.Treinos)
                .HasForeignKey(e => e.AlunoId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasOne(f => f.Unidade)
                .WithMany(u => u.Funcionarios)
                .HasForeignKey(f => f.UnidadeId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Professor>(entity =>
            {
                entity.HasOne(p => p.Funcionario)
                .WithOne(f => f.Professor)
                .HasForeignKey<Professor>(p => p.funcionarioId)
                .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
