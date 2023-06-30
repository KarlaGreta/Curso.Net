using Teoria8;

/* var vector = new Empleado[] {
               new Empleado("Juan"),
               new Empleado("Adriana"),
               new Empleado("Diego")
             };
Array.Sort(vector);
foreach (Empleado e in vector)
{
   e.Imprimir();
} 
---------------------------------------
Pyme miPyme = new Pyme(new Empleado("Juan"),
new Empleado("Adriana"),
new Empleado("Diego"));

foreach (Empleado e in miPyme)
{
   e.Imprimir();
}*/

using System.Collections;

/* IEnumerator e = new EnumeradorEstaciones();
while (e.MoveNext())
{
   Console.WriteLine(e.Current);
} 

Estaciones estaciones = new Estaciones();
foreach (string st in estaciones)
{
Console.WriteLine(st);
}

-----------------------------------------
IEnumerator enumerador = colores();
while (enumerador.MoveNext())
{
Console.WriteLine(enumerador.Current);
}

IEnumerator colores()
{
yield return "rojo";
yield return "verde";
yield return "azul";
}
-----------------------------------------

Auxiliar aux = new Auxiliar();
aux.Procesar();

-----------------------------------------*/

Trabajador t= new Trabajador();
t.TrabajoFinalizado= ManejadorDelEvento;
t.Trabajar();

void ManejadorDelEvento()=>Console.WriteLine("trabajo finalizado");
