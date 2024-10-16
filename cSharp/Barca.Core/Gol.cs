namespace Tonka.Core;
public class Gol
{
    public ushort IdGol { get; set; }
    public string Descripcion { get; set; }

    public Gol(ushort idGol, string descripcion)
    {
        IdGol = idGol;
        Descripcion = descripcion;
    }
}

