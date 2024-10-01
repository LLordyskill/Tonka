namespace Tonka.Core;
public class CuerpoTecnico
{
    public byte IdTecnico { get; set; }
    public string Tecnico { get; set; }
    public ushort IdJugador { get; set; }

    public CuerpoTecnico(byte idTecnico, string tecnico, ushort idJugador)
    {
        IdTecnico = idTecnico;
        Tecnico = tecnico;
        IdJugador = idJugador;
    }
}
