using System.Collections;
class EnumeradorEstaciones : IEnumerator
{
    private string actual = "Inicio";

    public void Reset() => actual = "Inicio";

    public object Current =>
    (actual == "Inicio" || actual == "Fin") ? throw new InvalidOperationException() : actual;

    public bool MoveNext(){
        switch (actual)
        {
            case "Inicio": actual = "Verano"; break;
            case "Verano": actual = "Otoño"; break;
            case "Otoño": actual = "Invierno"; break;
            case "Invierno": actual = "Primavera"; break;
            case "Primavera": actual = "Fin"; break;
        }
        return (actual != "Fin");
    }
}