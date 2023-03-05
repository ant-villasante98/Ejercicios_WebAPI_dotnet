using Microsoft.EntityFrameworkCore;
using Ejercicios.Models.DataModels;

namespace Ejercicios.DataAcces;
public class UniversityContext : DbContext
{
    public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
    { }

    // add DBSets
    public DbSet<Curso>? Cursos { get; set; }
}
