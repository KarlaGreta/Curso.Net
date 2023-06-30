using Automotores;
/* 
Auto a = new Auto("Renault");
Console.WriteLine(a.ObtenerDescripcion()); 
 */

 Console.SetIn(new System.IO.StreamReader("out.txt"));
 string? l;
 Persona[] personas = new Persona[3];
 int i=0;
 while((l=Console.ReadLine())!=null){
   
    String[]? input=l.Split(",");
    personas[i]=new Persona(input[0],Convert.ToInt16(input[1]),Convert.ToInt32(input[2]));
    i++;
 }
 Console.WriteLine( $"{"Nro)"}  {"Nombre",-15} {"Edad",-10} {"DNI.",-10}");
 for( i=0;i<personas.Length;i++){
    Console.Write( $"{i})   ");
    Console.WriteLine(personas[i].imprimir());
 }
int min=0;
 for( i=0;i<personas.Length;i++)
  if(! personas[i].EsMayorQue(personas[min]))
    min=i;
  
  
  Console.WriteLine(personas[min].imprimir()); 

/* for (int i=0;i<4;i++){
    Console.WriteLine()
} */

 
/* string st1 = null;
string st2 = "chau";
string st = st1 ?? "hola";
Console.WriteLine(st);
st = st2 ?? "hola";
Console.WriteLine(st);
st = null ?? null ?? "ABC" ?? "123";
Console.WriteLine(st); */

// falta del 4 en adelante