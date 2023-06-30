namespace Automotores;
public class Persona{
    String _nombre;
    int _edad;
    int _dni;
    //public Persona(String nombre){}
    public Persona(String nombre,int edad,int dni){
        _nombre=nombre;
        _edad=edad;
        _dni=dni;
    }
    public String imprimir(){
        return $" {_nombre,-15} {_edad,-10} {_dni,-10}";
    }
    public int getEdad(){return _edad;}
    public bool EsMayorQue(Persona p){
        bool aux=false;
        if(_edad > p.getEdad()){
            aux=true;
        }
        return aux;
    }
    
}