/* int a = 17;
int b = 23;
swap<int>(ref a,ref b);
Console.WriteLine($"a  ={a} y b={b}");
string a1 = "hola";
string b1 = "como andas";
swap<string>(ref a1,ref b1);
Console.WriteLine($"a  ={a1} y b={b1}");

void swap<t>(ref t a,ref t b ){
    t aux;
    aux=a;
    a=b;
    b=aux;
} 
---------------------------------

int i = Maximo<int>(100,55);
Console.WriteLine(i);
string st =Maximo<string>("hola","mundo");
Console.WriteLine(st);
Console.WriteLine(Maximo('a','b'));

IComparable Maximo(IComparable a,IComparable b){
    if(a.CompareTo(b)>0)return a;
    return b;
} 

 t Maximo<t>(t a,t b) where t : IComparable{
    if(a.CompareTo(b)>0)return a;
    return b;
} 
-------------------------------------------------------
interface IRetornador<t>{
    t Retornar(t valor);
}

class Simple : IRetornador<int>,IRetornador<string>{
    public int Retornar(int valor){
        return valor;
    }

    public string Retornar(string valor){
        return valor;
    }
}
----- no se puede solo 2 interfaces genericas----------
class ClaseGen<t1,t2>:IRetornador<t2>,IRetornador<t1>{
    public t2 Retornar(t2 valor){
        return valor;
    }

    public t1 Retornar(t1 valor){
        return valor;
    }

}

using Teoria9;

Funcion<int,string> lambda1 = n  => $"n={n}";
Funcion<string,int> lambda2 = st  => st.Length;
Funcion<int[],double> f =Promedio;

Console.WriteLine(lambda1(12));
Console.WriteLine(lambda2("hola mundo"));
Console.WriteLine(f(new int[]{1,2,3,4,5}));

double Promedio(int[] vector){
    int sum=0;
    foreach(int i in vector) sum+=i;
    return sum/vector.Length;
}
---------   ejercicio1 ----------------
var lista = new List<object> { "hola", 7, 'A' };
string st = Get<string>(lista, 0);
int i = Get<int>(lista, 1);
char c = Get<char>(lista, 2);
Console.WriteLine($"{st} {i} {c}");

t1 Get<t1>(List<object> lista,int i){
    return (t1)lista[i];
}
-----------ejercicio2---------------
int[] vector1 = new int[] { 1, 2, 3 };
bool[] vector2 = new bool[] { true, true, true };
string[] vector3= new string[] { "uno", "dos", "tres" };
Set<int>(vector1, 110, 2);
Set<bool>(vector2, false, 1);
Set<string>(vector3, "Hola Mundo!", 0);
Imprimir(vector1);
Imprimir(vector2);
Imprimir(vector3);

void Set<t1>(t1[] vector,t1 dato,int pos){
    vector[pos]=dato;
}

void Imprimir<t1>(t1[] vector){
    foreach( object x in vector) 
    Console.WriteLine(x);
}-------------------ejercicio3---------
string[] vector1 = CrearArreglo<string>("uno", "dos");
foreach (string st in vector1) Console.Write(st + " - ");
Console.WriteLine();
double[] vector2 = CrearArreglo<double>(1, 2.3, 4.1, 6.7);
foreach (double valor in vector2) Console.Write(valor + " - ");
Console.WriteLine();
var stb = new System.Text.StringBuilder();
var a = GetNuevoObjetoDelMismoTipo(stb);
var b = GetNuevoObjetoDelMismoTipo(17);
Console.WriteLine(a.GetType());
Console.WriteLine(b.GetType());

t1[] CrearArreglo<t1>(params t1[] list){
    t1[] vector=new t1[list.Count()];
    for(int i=0;i<list.Count();i++)
        vector[i]=list[i];
    return vector;
}

t1 GetNuevoObjetoDelMismoTipo<t1>( t1 parametro){
    t1 b=parametro;
    return b;
}*/

