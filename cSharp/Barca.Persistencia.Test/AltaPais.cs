using Tonka.Core;
using Xunit;
namespace Barca.Persistencia.Test;

public class AltaPais : TestAdo
{
     [Fact]
        public void AltPais()
    {
            var nuevoPais = new Pais(0, "Argentina");
        Ado.AltaPais(nuevoPais);

            Assert.NotEqual(0,nuevoPais.IdPais);
        }
}
