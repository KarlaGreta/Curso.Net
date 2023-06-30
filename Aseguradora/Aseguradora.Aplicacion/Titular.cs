namespace   Aseguradora.Aplicacion;
public class Titular:Persona {

    public string? Email{get;set;}
    public string? Direccion{get;set;}
    public Titular(){}
     public Titular(int dni,string? apellido,string? nombre):base(dni,apellido,nombre){
        
    } 

    public override string ToString(){
        return $" {base.ToString()} {Email} {Direccion}";
    } 
}