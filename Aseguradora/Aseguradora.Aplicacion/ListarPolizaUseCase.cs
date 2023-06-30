namespace   Aseguradora.Aplicacion;

public class ListarPolizaUseCase 
{
    private readonly IRepositorioPoliza _repo;

    public ListarPolizaUseCase(IRepositorioPoliza repo)
    {
        _repo = repo;
    }

    public List<Poliza> Ejecutar()
    {
        return _repo.ListarPolizas();
    }
}



