/* List<string> lista = new List<string>() { "uno", "dos", "tres" };
IEnumerable<string> secuencia = lista.Select(st => "(" + st.ToUpper() + ")");
Mostrar(secuencia);
IEnumerable<int> secuencia2 = secuencia.Select(st => st.Count());
Mostrar(secuencia2); 
----------------- palabre clave var para simplicidad ------
var lista = new List<string>() { "uno", "dos", "tres" };
var secuencia = lista.Select(st => "(" + st.ToUpper() + ")");
Mostrar(secuencia);
var secuencia2 = secuencia.Select(st => st.Length);
Mostrar(secuencia2);
var secuencia3 = secuencia2.Select(n => n / 2.0);
Mostrar(secuencia3);
---------------------- interfaz fluida de linq----------
var lista = new List<string>() { "uno", "dos", "tres" };
var secuencia = lista.Select(st => "(" + st.ToUpper() + ")")
.Select(st => st.Length)
.Select(n => n / 2.0);

-------------- metodo WHERE , REVERSE , ORDENBY , SUM, AVERANGE---------------

var numeros = new List<int>() { 1, 10, 7, 3, 11 };
Mostrar(numeros);
var mayores6 = numeros.Where(n => n > 6);
Mostrar(mayores6);
var reverso = mayores6.Reverse();
Mostrar(reverso);
var ordenados = reverso.OrderBy(n => n);
Mostrar(ordenados);
var suma = ordenados.Sum();
var promedio = ordenados.Average();
Console.WriteLine($"suma: {suma} promedio:{promedio:0.00}");

void Mostrar<T>(IEnumerable<T> secuencia)
{
foreach (T elemento in secuencia)
{
Console.Write(elemento + " ");
}
Console.WriteLine();
}
---------------   ejemplo --------------------

var personas = Persona.GetLista();
personas.ForEach(p => Console.WriteLine(p)); // lista todas las personas
Console.WriteLine();

personas.Where(n=> n.Edad>18).ToList()
                .ForEach(p=> Console.WriteLine(p));

personas.OrderBy(p => p.Edad)
        .Select(p => new { Nombre = p.Nombre, Condición = p.Edad < 18 ? "Menor" : "Mayor" })
        .ToList()
        .ForEach(obj => Console.WriteLine(obj));


----------------  FIRST LAST MAX MIN ALL ANY -----------------
var personas = Persona.GetLista();
Console.WriteLine($"Primero: {personas.First()}");
Console.WriteLine($"Último: {personas.Last()}");
Console.WriteLine($"Edad máxima: {personas.Max(p => p.Edad)}");
Console.WriteLine($"Edad mínima: {personas.Min(p => p.Edad)}");
Console.WriteLine($"Son todos mayores? {personas.All(p => p.Edad >= 18)}");//false
Console.WriteLine($"Hay algún mayor? {personas.Any(p => p.Edad >= 18)}");// true

-----------  GROUP -----------------
var personas = Persona.GetLista();
personas.GroupBy(p => p.Pais)
        .ToList()
        .ForEach(grup =>
            {
                Console.WriteLine($"{grup.Key} ({grup.Count()})");
                grup.ToList().ForEach(p => Console.WriteLine(" " + p.Nombre));
            });

using Linq;            
var personas = Persona.GetLista();
var agrupadas = personas.GroupBy(p=> p.Nombre.First() );
foreach(var grupo in agrupadas) {
    Console.WriteLine($"{grupo.Key}  {grupo.Count()}");
    grupo.ToList().ForEach(p => Console.WriteLine(" - " + p));
}          */
 

var alumnos = new List<Alumno>() {
    new Alumno(1,"Juan"),
    new Alumno(2,"Ana"),
    new Alumno(3,"Laura")
    };
var examenes = new List<Examen>() {
new Examen(2,"Inglés",9),
new Examen(1,"Inglés",5),
new Examen(1,"Álgebra",10)
};

var listado = alumnos.Join(examenes,
                a => a.Id, //clave de matching en alumnos
                e => e.AlumnoId, //clave de matching en notas
                (a, e) => new
                    {
                        Alumno = a.Nombre,
                        Materia = e.Materia,
                        Notas = e.Nota
                    });
listado.ToList().ForEach(obj => Console.WriteLine(obj));

class Alumno
{
    public int Id { get; private set; }
    public string Nombre { get; private set; }
    public Alumno(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }
}
class Examen
{
    public int AlumnoId { get; private set; }
    public string Materia { get; private set; }
    public double Nota { get; private set; }
    public Examen(int alumnoId, string materia, double nota)
    {
        AlumnoId = alumnoId;
        Materia = materia;
        Nota = nota;
    }
}