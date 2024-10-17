using System.Data;
using Dapper;
using Tonka.Core;

namespace Barca.Persistencia;

public class BarcaDapper : IAdo
{
    private readonly IDbConnection _conexion;

    public BarcaDapper(IDbConnection conexion) => _conexion = conexion;

    private static readonly string _queryJugador = 
        @"SELECT * FROM Jugador WHERE IdJugador = @IdJugador";

    public Jugador? ObtenerJugador(uint idJugador)
        => _conexion.QueryFirstOrDefault<Jugador>(_queryJugador, new { IdJugador = idJugador });

    private static readonly string _queryAltaJugador = 
        @"INSERT INTO Jugador (IdJugador, IdPais, IdPosicion, Nombre, Apellido, Nacimiento, NumCamiseta) 
          VALUES (@IdJugador, @IdPais, @IdPosicion, @Nombre, @Apellido, @Nacimiento, @NumCamiseta)";

    public void AltaJugador(Jugador jugador)
        => _conexion.Execute(_queryAltaJugador, new
        {
            IdJugador = jugador.IdJugador,
            IdPais = jugador.IdPais,
            IdPosicion = jugador.IdPosicion,
            Nombre = jugador.Nombre,
            Apellido = jugador.Apellido,
            Nacimiento = jugador.Nacimiento,
            NumCamiseta = jugador.NumCamiseta,
        });

    private static readonly string _queryPaises = "SELECT IdPais, Nombre FROM Pais";

    public List<Pais> ObtenerPaises()
        => _conexion.Query<Pais>(_queryPaises).ToList();

    private static readonly string _queryAltaPais = 
        @"INSERT INTO Pais (IdPais, Nombre) VALUES (@IdPais, @Nombre)";

    public void AltaPais(Pais pais)
        => _conexion.Execute(_queryAltaPais, new
        {
            IdPais = pais.IdPais,
            Nombre = pais.Nombre,
        });

    private static readonly string _queryAltaPosicion = 
        @"INSERT INTO Posiciones (IdPosicion, PosicionNombre) VALUES (@IdPosicion, @PosicionNombre)";

    public void AltaPosicion(Posicion nuevaPosicion)
        => _conexion.Execute(_queryAltaPosicion, new
        {
            IdPosicion = nuevaPosicion.IdPosicion,
            PosicionNombre = nuevaPosicion.PosicionNombre,
        });

    public List<Posicion> ObtenerPosiciones()
        => _conexion.Query<Posicion>("SELECT * FROM Posiciones").ToList();

    public Jugador? ObtenerJugadorDapperTest(ushort idJugador)
        => _conexion.QuerySingleOrDefault<Jugador>(
            "SELECT * FROM Jugador WHERE IdJugador = @IdJugador", new { IdJugador = idJugador }
        );

    public List<Pais> ObtenerPais() => throw new NotImplementedException();
    public void AltaTecnico(CuerpoTecnico tecnico) => throw new NotImplementedException();

}