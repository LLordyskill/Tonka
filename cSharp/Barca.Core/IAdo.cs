namespace Tonka.Core;

public interface IAdo
{
    void AltaJugador(Jugador jugador);
    Jugador? ObtenerJugador(uint id);
    void AltaPais(Pais pais);
    List<Pais> ObtenerPais();
    void AltaTecnico(CuerpoTecnico tecnico);
    void AltaPosicion(Posicion nuevaPosicion);
    Jugador? ObtenerJugadorDapperTest(ushort idJugadorDapperTest);
    
}