using CasaPopular.Entidades;
using CasaPopular.Utils;

namespace CasaPopular.CalculadoraPontos.Criterios
{
    public class Renda : ICriterio
    {
        public int GetPontos(Familia familia)
        {
            if (familia.GetRenda().EstaEntre(0, 900))
                return 5;
            else if (familia.GetRenda().EstaEntre(901, 1500))
                return 3;

            return 0;
        }
    }
}
