namespace Almacen.Repositorios;
using Almacen.Aplicacion;
public class RepositorioProductoTXT : IRepositorioProducto  
{
    static int s_id;
    readonly string _nombreArch = "productos.txt";
    public void AgregarProducto(Producto producto)
    {
            int ult=0;
            var sr2 = new StreamReader(_nombreArch);
            while (!sr2.EndOfStream)
            {   
                ult = int.Parse(sr2.ReadLine() ?? "");
                sr2.ReadLine();}
            s_id=++ult;
            producto.Id=s_id; 
            sr2.Close();

        using var sw = new StreamWriter(_nombreArch, true);
        sw.WriteLine(producto.Id);
        sw.WriteLine(producto.Nombre);
        sw.Close();
    }
    public List<Producto> ListarProductos()
    {
        var resultado = new List<Producto>();
        using var sr = new StreamReader(_nombreArch);
        while (!sr.EndOfStream)
        {
            var producto = new Producto();
            producto.Id = int.Parse(sr.ReadLine() ?? "");
            producto.Nombre = sr.ReadLine() ?? "";
            resultado.Add(producto);
        }
        return resultado;
    }
}