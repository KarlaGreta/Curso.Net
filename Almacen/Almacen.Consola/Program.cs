using Almacen.Aplicacion;
using Almacen.Repositorios;

//configuro las dependencias
IRepositorioProducto repo = new RepositorioProductoTXT();

//creo los casos de uso
var agregarProducto = new AgregarProductoUseCase(repo);
var listarProducto = new ListarProductosUseCase(repo);

//ejecuto los casos de uso
agregarProducto.Ejecutar(new Producto() { Nombre="Yerba"});
agregarProducto.Ejecutar(new Producto() { Nombre="Azúcar"});
var lista = listarProducto.Ejecutar();

foreach(Producto p in lista)
{
    Console.WriteLine(p);
}