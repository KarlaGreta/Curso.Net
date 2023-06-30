using Teoria5;
/* Cuenta c1 = new Cuenta();
Cuenta c2 = new Cuenta();
c1.Depositar(100);
c2.Depositar(200);
c1.Depositar(300);
Cuenta.ImprimirResumen();
c1.Imprimir();
c2.Imprimir(); */
/* 
FechaActual.ImprimirFecha();
FechaActual.ImprimirHora(); */



/* Familia f=new Familia();
f.Padre=new Persona("juan",50);
f[1] = new Persona("María", 40);
f[2] = new Persona("José", 15);
for (int i =0;i <3;i++)
{
    f[i]?.Imprimir();
}
 */

/*  Cuenta c1 = new Cuenta();
c1.Depositar(100).Depositar(50).Extraer(120).Extraer(50);
Cuenta c2 = new Cuenta();
c2.Depositar(200).Depositar(800);
new Cuenta().Depositar(20).Extraer(20);
c2.Extraer(1000).Extraer(1);
Console.WriteLine("\nDETALLE");
Cuenta.ImprimirDetalle();
 */

 new Cuenta();
new Cuenta();
List<Cuenta> cuentas = Cuenta.Cuentas;
// se recuperó la lista de cuentas creadas
cuentas[0].Depositar(50);
// se depositó 50 en la primera cuenta de la lista devuelta
cuentas.RemoveAt(0);
Console.WriteLine(cuentas.Count);
// se borró un elemento de la lista devuelta
// pero la clase Cuenta sigue manteniendo todos
// los datos "La cuenta id: 1 tiene 50 de saldo"
cuentas = Cuenta.Cuentas;
Console.WriteLine(cuentas.Count);
// se recupera nuevamente la lista de cuentas
cuentas[0].Extraer(30);
//se extrajo 30 de la cuenta id: 1 que tenía 50 de saldo

Console.WriteLine("\nDETALLE de cada cuenta");
foreach(Cuenta x in Cuenta.Cuentas){
    x.ImprimirCuenta();
    
}
  

  // falta de la 4 en adelante