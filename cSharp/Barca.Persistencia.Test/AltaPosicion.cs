using Super.Core;
using Xunit;
namespace Barca.Persistencia.Test;

public class AltaPosicion
{
        [Fact]
        public void AltaPosicion()
        {
            var nuevaPosicion = new Posicion(0, "Delantero");
            Ado.AltaPosicion(nuevaPosicion);

            Assert.NotEqual(nuevaPosicion.IdPosicion); 
        }
    }
