using CasaPopular.Entidades;
using CasaPopular.Utils;

namespace CasaPopular.CalculadoraPontos.Criterios
{
    public class NumeroDependentes : ICriterio
    {
        public int GetPontos(Familia familia)
        {
            if (familia.QtdeDependentes.EstaEntre(1, 2))
                return 2;
            else if (familia.QtdeDependentes >= 3)
                return 3;

            return 0;
        }
    }
}
