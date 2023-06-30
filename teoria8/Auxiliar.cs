namespace Teoria8;
class Auxiliar
{
    public void Procesar()
    {
        int[] v = new int[] { 11, 5, 90 };
        Aplicar(v, SumaDos);
        Imprimir(v);
        Aplicar(v, SumaUno);
        Imprimir(v);
    }
    int SumaUno(int n) => n + 1;
    int SumaDos(int n) => n + 2;

    void Aplicar(int[] v, FuncionEntera f)
    {
        for (int i = 0; i < v.Length; i++)
        {
            v[i] = f(v[i]);
        }
    }
    void Imprimir(int[] v)
    {
        foreach (int i in v)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}       