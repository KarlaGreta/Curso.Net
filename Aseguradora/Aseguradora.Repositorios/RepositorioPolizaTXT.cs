namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;

public class RepositorioPolizaTXT : IRepositorioPoliza
{
    readonly string _nombreArch = "polizas.txt";

    public void AgregarPoliza(Poliza poliza){

            if(BuscarPor.ID_Poliza(ListarPolizas(),poliza.Id)){
                throw new Exception($"Ya existe un titular con DNI = {poliza.Id}");
            }else 
            {
                using var sw = new StreamWriter(_nombreArch, true);
                poliza.actualizaCont();
                sw.WriteLine(poliza.Id);
                sw.WriteLine(poliza.VehiculoId);
                sw.WriteLine(poliza.valor);
                sw.WriteLine(poliza.franquicia);
                sw.WriteLine(poliza.cobertura);
                sw.WriteLine(poliza.Inicio);
                sw.WriteLine(poliza.Fin);
                sw.Close();
            }
    }

    public void ModificarPoliza(Poliza poliza){
        
    }

    public void EliminarPoliza(int id){

    }

    public List<Poliza> ListarPolizas(){
        var resultado = new List<Poliza>();
        using var sr = new StreamReader(_nombreArch);
        while (!sr.EndOfStream)
        {
            var poliza = new Poliza();
            poliza.Id = int.Parse(sr.ReadLine() ?? "");
            poliza.VehiculoId = int.Parse(sr.ReadLine() ?? "");
            poliza.valor = double.Parse(sr.ReadLine() ?? "");
            poliza.franquicia = sr.ReadLine() ?? "";
            poliza.cobertura = sr.ReadLine() ?? "";
            poliza.Inicio = DateOnly.Parse(sr.ReadLine() ?? "");
            poliza.Fin = DateOnly.Parse(sr.ReadLine() ?? "");
            resultado.Add(poliza);
        }
        return resultado;
    }
}