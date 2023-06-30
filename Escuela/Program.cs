using Escuela;
/* using (var context = new EscuelaContext())
{
    context.Database.EnsureCreated();
    EscuelaInit.Inicializar(context);
}
using (var context = new EscuelaContext())
{
    Console.WriteLine("-- Tabla Alumnos --");
    foreach (var a in context.Alumnos)
    {
        Console.WriteLine($"{a.Id} {a.Nombre}");
    }

    Console.WriteLine("-- Tabla Exámenes --");
    foreach (var ex in context.Examenes)
    {
        Console.WriteLine($"{ex.Id} {ex.Materia} {ex.Nota}");
    }
} 

//------AGREGANDO EN BD---------------------
using (var db = new EscuelaContext())
{
    
    var alumno = new Alumno() { Nombre = "Pablo" }; // el Id será establecido por SQLite
    db.Add(alumno); // se agregará realmente con el db.SaveChanges()
    db.SaveChanges(); //actualiza la base de datos. SQlite establece el valor de alumno.Id
                      // Agregamos un examen para el nuevo alumno
    var examen = new Examen()
    {
        AlumnoId = alumno.Id,
        Materia = "Historia",
        Nota = 9.5
    };
    db.Add(examen);
    db.SaveChanges();
}

 -----------------  BORRAR Y MODIFICAR --------------------
using (var db = new EscuelaContext())
{
    //borramos de la tabla Alumnos el registro con Id=3
    var alumnoBorrar = db.Alumnos.Where(a => a.Id == 3).SingleOrDefault();
    if (alumnoBorrar != null)
    {
        db.Remove(alumnoBorrar); //se borra realmente con el db.SaveChanges()
    }
    //La nota en Inglés del alumno id=1 es un 5. La cambiamos a 7.5
    var examenModificar = db.Examenes.Where(
    e => e.AlumnoId == 1 && e.Materia == "Inglés").SingleOrDefault();
    if (examenModificar != null)
    {
        examenModificar.Nota = 7.5; //se modifica el registro en memoria
    }
    db.SaveChanges(); //actualiza la base de datos.
}

-------------------  WRITE ID EQUUAL    ----------------------------------

using (var context = new EscuelaContext())
{
    var query = context.Alumnos.Join(context.Examenes,
    a => a.Id,
    e => e.AlumnoId,
    (a, e) => new
    {
        Alumno = a.Nombre,
        Materia = e.Materia,
        Nota = e.Nota
    });
    foreach (var obj in query)
    {
        Console.WriteLine(obj);
    }
}
----------------- cargando base de datos desde visual ------


using (var db = new EscuelaContext())
{
    Alumno nuevo = new Alumno()
    {
        Nombre = "Andrés",
        Examenes = new List<Examen>() {
            new Examen(){Materia="Lengua",Nota=7,Fecha = DateTime.Parse("5/5/2022") },
            new Examen(){Materia="Matemática",Nota=6,Fecha = DateTime.Parse("6/5/2022") }
            }
    };
    db.Add(nuevo);
    db.SaveChanges();
    foreach (Alumno a in db.Alumnos.Include(a => a.Examenes))
    {
        Console.WriteLine(a.Nombre);
        a.Examenes?.ToList()
        .ForEach(ex => Console.WriteLine($" - {ex.Materia} {ex.Nota}"));
    }
}   */
 
//         EJERCCIO 2 PARTE A

/* using Microsoft.EntityFrameworkCore;
using Escuela;

using(var db = new EscuelaContext())
{
    var query = db.Alumnos.Join(db.Examenes,
    a => a.Id,
    e => e.AlumnoId,
    (a, e) => new
    {
        Alumno = a.Nombre,
        //Materia = e.Materia,
        //Nota = e.Nota
    }).Distinct();
    
    foreach (var obj in query)
    {
        Console.WriteLine(obj.Alumno);
    } 
} */

//         EJERCCIO 2 PARTE B

/* using Microsoft.EntityFrameworkCore;
using Escuela;

using(var db = new EscuelaContext())
{
     var query = db.Cursos.GroupJoin(db.Examenes,
    a => a.CursoId,
    e => e.CursoId,
    (a,e) => new
    {
        titulo = a.Titulo,
        
        //Materia = e.Materia,
        Cantidad=e.Count()
    });
    
     foreach (var obj in query)
    {
        if(obj.Cantidad!=0)Console.WriteLine(obj);
    }   
} 
 */

  //         EJERCCIO 2 PARTE C

/* using Microsoft.EntityFrameworkCore;
using Escuela;

using(var db = new EscuelaContext())
{
    var query = db.Alumnos.Join(db.Examenes,
    a => a.Id,
    e => e.AlumnoId,
    (a, e) => new
    {
        Alumno = a.Nombre,
        Curso = e.CursoId,
        Nota = e.Nota
    }).Join(db.Cursos,
        a=>a.Curso,
        e=>e.CursoId,
        (a,e)=>new{
            Alumno = a.Alumno,
            Curso = e.Titulo,
            Nota = a.Nota
        });
    
    foreach (var obj in query)
    {
        Console.WriteLine(obj);
    } 
}  */

  //         EJERCCIO 2 PARTE D

/* using Microsoft.EntityFrameworkCore;
using Escuela;

using(var db = new EscuelaContext())
{
    var query = db.Alumnos.Join(db.Examenes,
    a => a.Id,
    e => e.AlumnoId,
    (a, e) => new
    {
        Alumno = a.Nombre,
        Curso = e.CursoId,
        Nota = e.Nota
    }).Join(db.Cursos,
        a=>a.Curso,
        e=>e.CursoId,
        (a,e)=>new{
            Alumno = a.Alumno,
            Curso = e.Titulo,
            Nota = a.Nota
        }).Where(a=>a.Nota>=6);
    
    foreach (var obj in query)
    {
        Console.WriteLine(obj);
    } 
} */ 

  //         EJERCCIO 2 PARTE e

/* using Microsoft.EntityFrameworkCore;
using Escuela;

using(var db = new EscuelaContext())
{
    var query = db.Alumnos.GroupJoin(db.Examenes,
    a => a.Id,
    e => e.AlumnoId,
    (a,e) => new
    {
        Alumno = a.Nombre,
        
        //Materia = e.Materia,
        Cantidad=e.Count()
    }).Where(n=>n.Cantidad==0);
    
     foreach (var obj in query)
    {
        Console.WriteLine(obj.Alumno);
    }   
}  */
 
   //         EJERCCIO 2 PARTE F

using Microsoft.EntityFrameworkCore;
using Escuela;

using(var db = new EscuelaContext())
{
   // var examenes = db.Examenes.GroupBy(a=>a.AlumnoId).ToList();
    var query = db.Examenes.Join(db.Alumnos,
        a => a.AlumnoId,
        e => e.Id,
        (a,e) => new
        {
            Alumno = e.Nombre,
            Curso=a.CursoId,
            nota=a.Nota
        }
    );
    query.GroupBy(p=>p.Alumno).ToList().ForEach(group=>
            {
                Console.WriteLine(group.Average(e=>e.nota));
            });
 
}
