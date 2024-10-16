using Barca.Core;
using Barca.Dapper;
namespace Barca.Persistencia.Test;

public interface TestAdo
{
    
{
    public class TestAdo
    {
        protected readonly IAdo Ado;
        
       
        private const string _cadena = "Server=localhost;Database=5to_Barcelonatonka;";

        public TestAdo() 
            => Ado = new AdoDapper(_cadena);

        public TestAdo(string cadena) 
            => Ado = new AdoDapper(cadena);
    }
}

}
