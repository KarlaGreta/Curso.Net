using Aseguradora.Aplicacion;
using Aseguradora.Repositorios;

//creamos los casos de uso inyectando dependencias
IRepositorioTitular repoTitular = new RepositorioTitularTXT();
AgregarTitularUseCase 
 = new AgregarTitularUseCase(repoTitular);
ListarTitularUseCase listarTitulares = new ListarTitularUseCase(repoTitular);
ModificarTitularUseCase modificarTitular = new ModificarTitularUseCase(repoTitular);
EliminarTitularUseCase eliminarTitular = new EliminarTitularUseCase(repoTitular);
//Instanciamos un titular
Titular titular = new Titular(33123456, "García", "Juan")
{
Direccion = "13 nro. 546",
Telefono = "221-456456",
Email = "joseGarciagmail.com"
};
Console.WriteLine($"Id del titular recién instanciado: {titular.Id}");
//agregamos el titular utilizando un método local
PersistirTitular(titular);
//el id que corresponde al titular es establecido por el repositorio
Console.WriteLine($"Id del titular una vez persistido: {titular.Id}");
//agregamos unos titulares más
PersistirTitular(new Titular(20654987, "Rodriguez", "Ana"));
PersistirTitular(new Titular(31456444, "Alconada", "Fermín"));
PersistirTitular(new Titular(12345654, "Perez", "Cecilia"));
//listamos los titulares utilizando un método local
ListarTitulares();
//no debe ser posible agregar un titular con igual DNI que uno existente
Console.WriteLine("Intentando agregar un titular con DNI 20654987");
titular = new Titular(20654987, "Alvarez", "Alvaro");
PersistirTitular(titular); //este titular no pudo persistirse

//Entonces vamos a modificar el titular existente
Console.WriteLine("Modificando el titular con DNI 20654987");
modificarTitular.Ejecutar(titular);

ListarTitulares();
//Eliminando un titular
Console.WriteLine("Eliminando al titular con id 1");
eliminarTitular.Ejecutar(1);
ListarTitulares(); 

//métodos locales
void PersistirTitular(Titular t)
{
    try
        {
        agregarTitular.Ejecutar(t);
        }
        catch (Exception e)
        {
        Console.WriteLine(e.Message);
        }
}
void ListarTitulares()
{
Console.WriteLine("Listando todos los titulares de vehículos");
List<Titular> lista = listarTitulares.Ejecutar();
foreach (Titular t in lista)
{
Console.WriteLine(t);
}
}