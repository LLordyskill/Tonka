using Tonka.Core;
namespace Barca.Persistencia.Test;

public class AltaPosicion : TestAdo
{
    [Fact]
    public void AltaPos()
    {
        var nuevaPosicion = new Posicion(0, "Delantero");
        Ado.AltaPosicion(nuevaPosicion);

        Assert.NotEqual(0, nuevaPosicion.IdPosicion);
    }
}
