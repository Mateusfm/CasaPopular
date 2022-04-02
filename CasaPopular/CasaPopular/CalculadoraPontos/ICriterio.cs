using CasaPopular.Entidades;

namespace CasaPopular.CalculadoraPontos
{
    public interface ICriterio
    {
        int GetPontos(Familia familia);
    }
}
