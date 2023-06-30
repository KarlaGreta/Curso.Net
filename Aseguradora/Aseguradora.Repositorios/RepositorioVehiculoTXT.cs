namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;

public class RepositorioVehiculoTXT : IRepositorioVehiculo
{
    readonly string _nombreArch = "vehiculo.txt";

    public void AgregarVehiculo(Vehiculo vehiculo){

            if(BuscarPor.ID_Vehiculo(ListarVehiculos(),vehiculo.Id)){
                throw new Exception($"Ya existe un titular con DNI = {vehiculo.Id}");
            }else 
            {
                using var sw = new StreamWriter(_nombreArch, true);
                vehiculo.actualizaCont();
                sw.WriteLine(vehiculo.Id);
                sw.WriteLine(vehiculo.Dominio);
                sw.WriteLine(vehiculo.Marca);
                sw.WriteLine(vehiculo.Anio);
                sw.WriteLine(vehiculo.TitularId);
                sw.Close();
            }
    }

    public void ModificarVehiculo(Vehiculo vehiculo){
        
    }

    public void EliminarVehiculo(int id){

    }

    public List<Vehiculo> ListarVehiculos(){
        var resultado = new List<Vehiculo>();
        using var sr = new StreamReader(_nombreArch);
        while (!sr.EndOfStream)
        {
            var vehiculo = new Vehiculo();
            vehiculo.Id = int.Parse(sr.ReadLine() ?? "");
            vehiculo.Dominio =  sr.ReadLine() ?? "";
            vehiculo.Marca =  sr.ReadLine() ?? "";
            vehiculo.Anio = int.Parse(sr.ReadLine() ?? "");
            vehiculo.TitularId =int.Parse(sr.ReadLine() ?? "");
            resultado.Add(vehiculo);
        }
        return resultado;
    }
}