namespace Tonka.Core;
public class Pais
{
    public byte IdPais { get; set; }
    public string Nombre { get; set; }

    public Pais(byte idPais, string nombre)
    {
        IdPais = idPais;
        Nombre = nombre;
    }
}


