namespace Tonka.Core.Persistencia;
public interface IListado<T>
{
    IEnumerable<T> TraerElementos();
}