namespace   Aseguradora.Aplicacion;
public class Tercero:Persona {

    private string? _nombreAseguradora{get;set;}
    private int SiniestroId{get;set;}

    public Tercero(int dni,string? apellido,string? nombre):base(dni,apellido,nombre){
        
    }
   
}