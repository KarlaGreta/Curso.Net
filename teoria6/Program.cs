using Teoria6;

/* Auto a = new Auto("Ford", 2000, TipoAuto.Deportivo);
Colectivo c = new Colectivo("Mercedes", 2010, 20);
a.Imprimir();
c.Imprimir(); */

/* Auto a = new Auto("Fiat", 2017, TipoAuto.Familiar);
Console.WriteLine(a); */


/* A[] vector = new A[] { new A(3), new B(5), new C(15), new D(41) };
foreach (A a in vector)
{
a.Imprimir();
} */


A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
Console.WriteLine(vector[1].GetType());
Console.WriteLine(typeof(A));
 foreach (A a in vector)
{
    if (a.GetType()==typeof(B))  a.Imprimir();
} 

//falta de 3 en adelante