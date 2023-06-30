namespace Escuela;
public class Curso
{
public double CursoId { get; set; }

public string Titulo { get; set;}

public List<Examen>? Examenes { get; set; }
}