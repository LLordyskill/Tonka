using System.Data;
using Dapper;
using Tonka.Core;

namespace Barca.Persistencia;

public class BarcaDapper : IAdo
{
    private readonly IDbConnection _conexion;

    public BarcaDapper(IDbConnection conexion) => this._conexion = conexion;


    private static readonly string _queryJugador
        = @"SELECT  *
            FROM    Jugador
            WHERE   idJugador = @unidJugador";

    public Jugador? JugadorPorID(uint idJugador)
        => _conexion.QueryFirstOrDefault<Jugador>(_queryJugador, new { unidJugador = idJugador});

    private static readonly string _queryAltaJugador
        = @"INSERT INTO Jugador VALUES (@IdJugador, @IdPais ,@IdPosicion ,@Nombre ,@Apellido ,@Nacimiento ,@NumCamiseta)";
    public void AltaJugador(Jugador jugador )
        => _conexion.Execute(
                _queryAltaJugador,
                new
                {
                     IdJugador = jugador.IdJugador,
                     IdPais = jugador.IdPais,
                     IdPosicion = jugador.IdPosicion,
                     Nombre = jugador.Nombre,
                     Apellido = jugador.Apellido,
                     Nacimiento = jugador.Nacimiento,
                     NumCamiseta = jugador.NumCamiseta,
                }
            );
    private static readonly string _queryPaises
    = "SELECT idPais , nombre FROM Pais";

public List<Pais> ObtenerPaises()
    => _conexion.Query<Pais>(_queryPaises).ToList();

 private static readonly string _queryAltaPais
        = @"INSERT INTO Cajero VALUES (@IdPais ,@Nombre)";
    public void AltaPais(Pais pais)
        => _conexion.Execute(
                _queryAltaPais,
                new
                {
                     IdPais = pais.IdPais,
                     Nombre = pais.Nombre,
                }
            );

    public Jugador? ObtenerJugador(uint id)
    {
        throw new NotImplementedException();
    }

    public List<Pais> ObtenerPais()
    {
        throw new NotImplementedException();
    }
}
