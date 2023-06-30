namespace   Aseguradora.Aplicacion;

public abstract class Persona{

    private static int cont;
    public int Id{get;set;}
    public int DNI{get;set;}
    public string? Apellido{get;set;}
    public string? Nombre{get;set;}
    public string? Telefono{get;set;}


    public Persona(int dni,string? apellido,string? nombre){
        DNI=dni;
        Apellido=apellido;
        Nombre=nombre;
        Id=-(cont+1);
    }
    public void actualizaCont(){
        cont++;
        Id=cont;
    }
    public static void iniciarCont(){
        cont=0;
    }
    public static void ActualizarCont(int aux){cont=aux;}
    public Persona(){}

    public override string ToString(){
        return $" {Id}: {DNI} {Apellido}, {Nombre}";
    }
    
}