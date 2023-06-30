namespace Aseguradora.Aplicacion;

public static class BuscarPor{

    public  static bool dni_Titular(List<Titular> lista,int dni){
        bool bol=false;
        if(lista.Count!=0){
            foreach(Titular persona in lista){
                if(dni==persona.DNI){
                    bol=true;
                };
            }         
        }
        return bol;
    }
    public  static bool ID_Poliza(List<Poliza> lista,int id){
        bool bol=false;
        if(lista.Count!=0){
            foreach(Poliza poliza in lista){
                if(id==poliza.Id){
                    bol=true;
                };
            }          
        }
        return bol;
    }

    public  static bool ID_Vehiculo (List<Vehiculo> lista,int id){
        bool bol=false;
        if(lista.Count!=0){
            foreach(Vehiculo vehiculo in lista){
                if(id==vehiculo.Id){
                    bol=true;
                };
            }          
        }
        return bol;
    }

    public  static int PosBuscar(List<Titular> lista,int dni){
        int aux=-1;
        if(lista.Count!=0){
            for(int i=0;i<lista.Count;i++){
                if(dni==lista[i].DNI){
                    aux=i;
                }
            }       
        }
        return aux;
    }
        
}
        

