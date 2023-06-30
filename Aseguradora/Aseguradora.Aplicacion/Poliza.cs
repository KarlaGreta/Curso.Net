namespace   Aseguradora.Aplicacion;

public  class Poliza{

    static int cont;
    public int Id{get;set;}
    public int VehiculoId{get;set;}
    public double valor{get;set;}
    public string? franquicia{get;set;}
    public string? cobertura{get;set;}
    public DateOnly? Inicio{get;set;}
    public DateOnly? Fin{get;set;}

    public void actualizaCont(){
        cont++;
        Id=cont;
    }   
}