namespace Teoria5;
using System.Collections.Generic;
/* class Cuenta{
    private int _monto;
    private static int s_total;
    public static void ImprimirResumen()
    => Console.WriteLine($"Total = {Cuenta.s_total}");
    public void Depositar(int monto) {
    _monto += monto;
    Cuenta.s_total += monto;
    }
    public void Imprimir() => Console.WriteLine(_monto);

}

static class FechaActual
{
public static void ImprimirHora() =>
Console.WriteLine($"{DateTime.Now:hh:mm:ss}");
public static void ImprimirFecha() =>
Console.WriteLine($"{DateTime.Today:dd/MM/yyyy}");
}
 
class A

{
const double doblePI = PI * 2;
const string saludoTotal = saludo + " Mundo!";
readonly string saludoDos = "Hola" + 2;
static double tres = 3.0;

readonly double triplePI = PI * tres;
readonly DateTime dia = DateTime.Now ;

const double PI = 3.1415;
const string saludo = "Hola";
}
*/

/* class Cuadrado {
    private double lado;
    public double Lado {get ;set ;}
    public double Area =>_lado*_lado; // solo lectura get
    
} */

class Cuenta{
    private int total;
    private int id;
    static int s_id;

    static int s_depositos;
    static int s_Tdepositos;

    static int s_extracciones;
    static int s_Textracciones;
    static int s_extraccionesDenegadas;

    static int s_total;
    static  List<Cuenta> s_cuentas=new List<Cuenta>() ;

    public Cuenta(){
        s_id++;
        id=s_id; 
        Console.WriteLine($"Se creo la cuenta ID={id}");
        s_cuentas.Add(this);
    }
    
    public Cuenta(int id,int total){

    }
    public void ImprimirCuenta(){
         Console.WriteLine($"ID= {id} tiene {total}");
    }
    public static List<Cuenta> Cuentas{
        get{
            List<Cuenta> s_cuentas2=new List<Cuenta>(s_cuentas);
            return   s_cuentas2;}
    }
    public Cuenta Depositar(int i){
        total+=i;
        s_Tdepositos+=i;
        Console.WriteLine($"Se depositó {i} en la cuenta {id} (Saldo={total})");
        s_depositos++;
        s_total+=i;
        return this;
    }

    public Cuenta Extraer(int i){
        if(total>=i){
            total-=i;
            Console.WriteLine($"Se extrajo {i} en la cuenta {id} (Saldo={total})");
            s_extracciones++;
            s_Textracciones+=i;
            s_total-=i;
        }else{
            Console.WriteLine("Operación denegada - Saldo insuficiente");
            s_extraccionesDenegadas++;
            }
        return this;
    }

    public  static void ImprimirDetalle(){
        Console.WriteLine($"\n{"CUENTAS CREADAS:",-18}{s_id}"); 
        Console.WriteLine($"{"DEPOSITOS:",-18}{s_depositos,-5}- {"Total depositado:",-20}{s_Tdepositos,5}");
        Console.WriteLine($"{"EXTRACCIONES:",-18}{s_extracciones,-5}- {"Total extraido:",-20}{s_Textracciones,5}");
        Console.WriteLine($"{" ",-23}- {"Saldo:",-20}{s_total,5}"); 
        Console.WriteLine($"* Se denegaron {s_extraccionesDenegadas} extracciones por falta e fondos"); 
    }
}