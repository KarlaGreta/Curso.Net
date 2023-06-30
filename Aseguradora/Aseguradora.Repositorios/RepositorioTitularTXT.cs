namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;

public class RepositorioTitularTXT : IRepositorioTitular
{
    readonly string _nombreArch = "titulares.txt";

    public void AgregarTitular(Titular titular){
        List<Titular> listarTitulares=ListarTitulares();
            if(BuscarPor.dni_Titular(listarTitulares,titular.DNI)){
                throw new Exception($"Ya existe un titular con DNI = {titular.DNI}");
            }else 
            {
                using var sw = new StreamWriter(_nombreArch, true);
                if(listarTitulares.Count!=0)Titular.ActualizarCont(listarTitulares[listarTitulares.Count-1].Id);
                if(titular.Id<0)titular.actualizaCont();
                sw.WriteLine(titular.Id);
                sw.WriteLine(titular.DNI);
                sw.WriteLine(titular.Apellido);
                sw.WriteLine(titular.Nombre);
                sw.WriteLine(titular.Direccion);
                sw.WriteLine(titular.Telefono);
                sw.WriteLine(titular.Email);
                sw.Close();
            }
    }

    public void ModificarTitular(Titular titular){

        List<Titular>  listatitulares = ListarTitulares();
        using var sw = new StreamWriter(_nombreArch, false);
        sw.Write("");
        sw.Close();
         if ( !(BuscarPor.dni_Titular(listatitulares,titular.DNI))){
                throw new Exception("El dni no existe");
            }else {
                Titular.iniciarCont();
                int pos = BuscarPor.PosBuscar(listatitulares,titular.DNI);
                int id=listatitulares[pos].Id;
                listatitulares[pos]=titular;
                listatitulares[pos].Id=id;
                foreach(Titular t in listatitulares){
                    AgregarTitular(t);
                }
            } 
    }

    public void EliminarTitular(int id){
        List<Titular>  listatitulares = ListarTitulares();
        
        
                int pos=-1;
                for(int i=0;i<listatitulares.Count;i++){
                    if (listatitulares[i].Id==id){
                        using var sw = new StreamWriter(_nombreArch, false);
                        sw.Write("");
                        sw.Close();
                        pos=i;
                        listatitulares.RemoveAt(pos);
                        Titular.iniciarCont();
                        foreach(Titular t in listatitulares){
                            AgregarTitular(t);
                        }
                        break;
                }            
        }    
    }

    public List<Titular> ListarTitulares(){
        var resultado = new List<Titular>();
        using var sr = new StreamReader(_nombreArch);
        while (!sr.EndOfStream)
        {
            var titular = new Titular();
            titular.Id = int.Parse(sr.ReadLine() ?? "");
            titular.DNI = int.Parse(sr.ReadLine() ?? "");
            titular.Apellido = sr.ReadLine() ?? "";
            titular.Nombre = sr.ReadLine() ?? "";
            titular.Direccion = sr.ReadLine() ?? "";
            titular.Telefono = sr.ReadLine() ?? "";
            titular.Email = sr.ReadLine() ?? "";
            resultado.Add(titular);
        }
        return resultado;
    }
}