using Super.Core;
using Xunit;
namespace Barca.Persistencia.Test;

public class AltaTecnico
{

{
    public class TestAdo : TestAdo
    {
        [Fact]
        public void AltaTecnico()
        {
            var nuevoTecnico = new CuerpoTecnico(0, "Pep Guardiola", 1);
            Ado.InsertarTecnico(nuevoTecnico);

            Assert.NotEqual(nuevoTecnico.IdTecnico);
        }

    }
}
}