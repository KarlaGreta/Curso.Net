namespace Teoria8;

class ComparadorPorLegajo : System.Collections.IComparer
{
    public int Compare(object? x, object? y)
    {
        int result = 1;
        if (x is Empleado && y is Empleado)
        {
            int legajo1 = ((Empleado)x).Legajo;
            int legajo2 = ((Empleado)y).Legajo;
            result = legajo1.CompareTo(legajo2);
        }
        return result;
    }
} 