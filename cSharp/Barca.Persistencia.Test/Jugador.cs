namespace Barca.Persistencia.Test;


[Theory]
        [InlineData(20, 'Lamine', 'Yamal')]
        [InlineData(21, 'Pau', 'Victor')]
        public void TraerJugador(ushort idJugador, string nombre, string apellido)
        {
            var jugador = Ado.ObtenerJugador(idJugador);
            Assert.NotNull(jugador);
            Assert.Equal(nombre, jugador.Nombre);
            Assert.Equal(apellido, jugador.Apellido);
        }

        [Theory]
        [InlineData(9999)]
        public void JugadorNoExisten(ushort idJugador)
        {
            var jugador = Ado.ObtenerJugador(idJugador);
            Assert.Null(jugador);
        }

        [Fact]
        public void AltaJugador()
        {
            ushort idJugador = 3;
            byte idPais = 1;
            byte idPosicion = 1;
            string nombre = "Gabriel";
            string apellido = "Fernandez";
            DateTime nacimiento = new DateTime(2007, 3, 1);
            byte numCamiseta = 84;

            var nuevoJugador = new Jugador(idJugador, idPais, idPosicion, nombre, apellido, nacimiento, numCamiseta);
            Ado.InsertarJugador(nuevoJugador);

            var mismoJugador = Ado.ObtenerJugador(idJugador);
            Assert.NotNull(mismoJugador);
            Assert.Equal(nombre, mismoJugador.Nombre);
            Assert.Equal(apellido, mismoJugador.Apellido);
        }

internal class Ado
{
    internal static void InsertarJugador(Jugador nuevoJugador)
    {
        throw new NotImplementedException();
    }

    internal static object ObtenerJugador(ushort idJugador)
    {
        throw new NotImplementedException();
    }
}

internal class Jugador
{
    private ushort idJugador;
    private byte idPais;
    private byte idPosicion;
    private string nombre;
    private string apellido;
    private DateTime nacimiento;
    private byte numCamiseta;

    public Jugador(ushort idJugador, byte idPais, byte idPosicion, string nombre, string apellido, DateTime nacimiento, byte numCamiseta)
    {
        this.idJugador = idJugador;
        this.idPais = idPais;
        this.idPosicion = idPosicion;
        this.nombre = nombre;
        this.apellido = apellido;
        this.nacimiento = nacimiento;
        this.numCamiseta = numCamiseta;
    }
}