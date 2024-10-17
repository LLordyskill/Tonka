using Tonka.Core;

namespace Barca.Persistencia.Test;

public class TecnicoDapperTest : TestAdo
{
    [Fact]
    public void AltaTecnico()
    {
        var nuevoTecnico = new CuerpoTecnico(0, "Pep Guardiola", 1);
        Ado.AltaTecnico(nuevoTecnico);

        Assert.NotEqual(0, nuevoTecnico.IdTecnico);
    }
}