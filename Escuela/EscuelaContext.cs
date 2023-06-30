using Microsoft.EntityFrameworkCore;

namespace Escuela;

public class EscuelaContext : DbContext
{
#nullable disable
    public DbSet<Alumno> Alumnos { get; set; }
    public DbSet<Examen> Examenes { get; set; }
#nullable disable

    #nullable disable
    public DbSet<Curso> Cursos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder
    optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Escuela.sqlite");
    }
}