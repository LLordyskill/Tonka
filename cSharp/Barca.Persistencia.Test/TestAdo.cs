using System.Data;
using Tonka.Core;
using MySqlConnector;

namespace Barca.Persistencia.Test;
public class TestAdo
{
    protected readonly IAdo Ado;
    IDbConnection _conexion;
    private const string _cadena = "Server=localhost;Database=5to_Barcelonatonka;user=5to_agbd;Password=Trigg3rs!";
    public TestAdo() : this(_cadena) { }

    public TestAdo(string cadena)
    {
        _conexion = new MySqlConnection(_cadena);
        Ado = new BarcaDapper(_conexion);
    }
}
