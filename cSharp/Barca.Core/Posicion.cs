namespace Tonka.Core;
public class Posicion
{
    public byte IdPosicion { get; set; }
    public string PosicionNombre { get; set; }

    public Posicion(byte idPosicion, string posicionNombre)
    {
        IdPosicion = idPosicion;
        PosicionNombre = posicionNombre;
    }
}

