/* object obj =7.3;
Console.WriteLine(obj.GetType());
obj="casa";
Console.WriteLine(obj.GetType());
obj=4;
Console.WriteLine(obj.GetType()); */

/* object obj =4;
Console.WriteLine((int)obj+1); */

/* object obj = 1 + "A";
Console.WriteLine(obj.GetType());
Console.WriteLine(obj); */

/* object obj = "CAS" + 'A';
Console.WriteLine(obj.GetType());
Console.WriteLine(obj); */

/* object obj = "Área" + 5 + 1;
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);

object obj2 =  5 + 1 + "Área" ;
Console.WriteLine(obj2.GetType());
Console.WriteLine(obj2); */

/* int? i1 = null;

string? st1 = null;

int i2 = null;

string st2 = null; */

/*int? i1 = 10;
int? i2 = null;
bool a= i1.HasValue;
Console.WriteLine(a);
 i1.Value;
i2.HasValue;
i2.Value; */

/* char c1 = 'A';
char c2 = c1; //se copia el valor 'A'
c1 = 'B';
Console.WriteLine("c1=" + c1 + " y c2=" + c2);
char[] v1 = new char[] {'A'};
char[] v2 = v1; //se copia la referencia
v1[0] = 'B';
Console.WriteLine("v1[0]=" + v1[0] + " y v2[0]=" +
v2[0]); */

/* DiaDeSemana diaDeReunion = DiaDeSemana.Martes;
for (DiaDeSemana d = DiaDeSemana.Lunes; d <= DiaDeSemana.Viernes; d++)
{
if (d == diaDeReunion)
{
Console.WriteLine("El " + d + " es día de reunión" );
}
}

enum DiaDeSemana
{
Domingo, Lunes, Martes,
Miércoles, Jueves,
Viernes, Sábado
}
 */

/*  object o1='a';
 object o2=o1;

 Console.WriteLine(o1==o2);
 o2='z';
 Console.WriteLine(o1+" "+o2); */

 /* int suma=0;
 int i=1;
 while(i<10){
    suma+=i++;
    Console.WriteLine(suma+" / "+i);
 } */

/*  Console.WriteLine(args);
 Console.WriteLine(args.Length); */

/*  int[]? vector= new int[1] ;
 int? i=null;
 vector[0]=null; // no se puede 
 Console.WriteLine(i); *//* 

 Console.WriteLine("!Hola {0}",args[0]); */

/*  char c;
char? c2;
string? st;
//c = ""; comillas dobles para string
//c = '';  caracter vacio 
//c = null;
c2 = null;
c2 = (65 as char?);
st = "";
//st = '';  de tirpo char
st = null;
//st = (char)65; No se puee convertir el char en string
st = (string)65;//  No se puede convertir el int en strig
st = 47.89.ToString(); */

/* String[] nombres = {"juana","lorena","marta"};
 int i=0;
for(;i<nombres.Length;i++){
    Console.WriteLine(nombres[i]);
} 
foreach(String x in nombres){
     Console.WriteLine(x);
}

FAlata desde la 9 en adelante */