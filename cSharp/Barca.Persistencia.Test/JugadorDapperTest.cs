using Tonka.Core;

namespace Barca.Persistencia.Test;

public class JugadorDapperTest : TestAdo
{
    [Theory]
    [InlineData(20, "Lamine", "Yamal")]
    [InlineData(21, "Pau", "Victor")]
    public void TraerJugadorDapperTest(ushort idJugadorDapperTest, string nombre, string apellido)
    {
        var jugador = Ado.ObtenerJugadorDapperTest(idJugadorDapperTest);
        Assert.NotNull(jugador);
        Assert.Equal(nombre, jugador.Nombre);
        Assert.Equal(apellido, jugador.Apellido);
    }

    [Theory]
    [InlineData(9999)]
    public void JugadorDapperTestNoExisten(ushort idJugadorDapperTest)
    {
        var jugador = Ado.ObtenerJugadorDapperTest(idJugadorDapperTest);
        Assert.Null(jugador);
    }

    [Fact]
    public void AltaJugadorDapperTest()
    {
        ushort idJugadorDapperTest = 3;
        byte idPais = 1;
        byte idPosicion = 1;
        string nombre = "Gabriel";
        string apellido = "Fernandez";
        DateTime nacimiento = new DateTime(2007, 3, 1);
        byte numCamiseta = 84;

        var nuevoJugador = new Jugador(
            idJugadorDapperTest,
            idPais,
            idPosicion,
            nombre,
            apellido,
            nacimiento,
            numCamiseta
        );

        Ado.AltaJugador(nuevoJugador);

        var mismoJugador = Ado.ObtenerJugadorDapperTest(idJugadorDapperTest);
        Assert.NotNull(mismoJugador);
        Assert.Equal(nombre, mismoJugador.Nombre);
        Assert.Equal(apellido, mismoJugador.Apellido);
    }
}
