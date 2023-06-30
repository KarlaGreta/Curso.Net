namespace Teoria6;

class Auto: Automotor
{
    public TipoAuto Tipo;
    public override double PrecioDeVenta { get; }
    public Auto(string marca, int modelo, TipoAuto tipo) : base(marca, modelo)
    {
        this.Tipo = tipo;
    }
    
    public override string ToString()
        {
            return base.ToString() + $"\nTipo: {Tipo}";
        }
}