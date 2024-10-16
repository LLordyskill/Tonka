using Super.Core;
using Xunit;
namespace Barca.Persistencia.Test;

public class AltaPais
{
     [Fact]
        public void AltaPais()
        {
            var nuevoPais = new Pais(0, "Argentina");
            Ado.AltaPais(nuevoPais);

            Assert.NotEqual(nuevoPais.IdPais);
        }
}
