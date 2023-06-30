/* //  MATRIZ

int[][] tabla = new int[2][];
tabla[0]=new int[2];
tabla[1]=new int[4];

// es igual a  

int[][] tabla2={new int[2], new int[3]};
// es igual a  
int[,] matriz = new int[,]
{ {1,2,3,4},
{5,6,7,8},
{9,10,11,12} };

// Acceso 
matriz[2, 2] = matriz[1, 1] + matriz[1, 2];

// creando una matriz del 1 al 10
int[,] mat = new int[3, 4];
for (int i = 0; i <= 11; i++)
{
// Console.WriteLine(i+"/"+i / 4+" "+i % 4);
    mat[i / 4, i % 4] = i;
}

var i2 = 15;
i2 = 140;
// i = 13.2; el var no permite cambio de tipo de variable

 dynamic dy = "hola mundo!";
 dy = 140; // si permite la asignacion de distintos tipos

// cadenas de formato compuesto
string marca="Ford";
int modelo=2000;
string st = string.Format("Es un {0} año {1}",marca,modelo);
//cadena de formato interpolacion
string st2= $"Es un {marca} año {modelo}";  
//Console.WriteLine(st);

string marca2 = "Ford";
int modelo2 = 2000;
// alineacion a la derecha
Console.WriteLine($"Es un {marca2,7} año {modelo2}");
Console.WriteLine($"Es un {"Nissan", 7} año {2020}");
// alineacion a la izquierda
Console.WriteLine($"Es un {marca2,-7} año {modelo2}");
Console.WriteLine($"Es un {"Nissan",-7} año {2020}");
// redondea 
double r = 2.417;
Console.WriteLine($"Valor = {r:0.0}");//2.4
Console.WriteLine($"Valor = {r:0.00}");//2.42
 
DateTime fecha = new DateTime(1999,1,5,15,5,6,325);
Console.WriteLine("a) {0}", fecha);
Console.WriteLine("b) {0:dd}", fecha);
Console.WriteLine("c) {0:dd/MM/yy}", fecha);
Console.WriteLine("d) {0:D}", fecha);
Console.WriteLine($"e) {fecha:dddd d 'del mes de' MMMM 'del año' yyyy}");
Console.WriteLine($"f) {fecha:t}");
Console.WriteLine($"g) {fecha:HH:mm:s fff}");

//Colecciones genericas 
//List<T>. Similar a un vector de elementos de tipo T
//Stack<T>. Pila de elementos de tipo T
//Queue<T>. Cola de elementos de tipo T
List<int> lista = new List<int>(){10,20,30,40};
lista.Add(55);
lista.Remove(30);
lista.RemoveAt(1);
lista.Insert(2,22);
int[] vector = new int[] { 31, 32, 33 };
lista.InsertRange(3,vector);
for(int i=0;i<lista.Count;i++){
    Console.WriteLine(lista[i]);
}

//excepciones
double[]? vector = new double[10];
Procesar(vector, 1, 1);
Procesar(null, 1, 1);

void Procesar(double[]? v, int i, int c)
{
    try{
        c = c + 10;
v[i] = 1000 / c;
Console.WriteLine(v[i]);
    }
    catch(Exception e){
        Console.WriteLine(e.Message);
    }
}

//practica3
Console.CursorVisible = false;
ConsoleKeyInfo k = Console.ReadKey(true);
while (k.Key != ConsoleKey.End)
{
Console.Clear();
Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
k = Console.ReadKey(true);
}*/


double[,] mat = new double[4, 4];
for (int i = 0; i <= 15; i++)
{ mat[i / 4, i % 4] = i;}
//ImprimirMatriz(mat,"0.00");
GetDiagonalPrincipal(mat);

void ImprimirMatriz(double[,] matriz,String x){
    int fila=matriz.GetLength(0);
    int columna=matriz.GetLength(1);
    Console.WriteLine(fila+" "+columna); 
    for(int y=0;y<columna;y++){
        for(int i=0;i<fila;i++){
        Console.Write($"{matriz[i,y].ToString(x)} ");
        
        }
        Console.WriteLine(" ");     
    }
}

double[] GetDiagonalPrincipal(double[,] matriz){
    int fila=matriz.GetLength(0);
    int columna=matriz.GetLength(1);
    double[] diagonal=new double[columna];
    try{
        if(columna==fila){
            
            for(int y=0;y<columna;y++){
                for(int i=0;i<fila;i++){
                    if(i==y){
                        diagonal[y]=matriz[i,y];
                    }  
                } 
            } 
            for(int i=0;i<fila;i++){
           Console.WriteLine(diagonal[i]); 
        } 
        }else throw new ArgumentException();
    }
    catch(ArgumentException e){
        Console.WriteLine("matriz no es cuadrdad");
    }
    return diagonal;
}

//double[] GetDiagonalSecundaria(double[,] matriz)

//falta del 5 en adelante



 