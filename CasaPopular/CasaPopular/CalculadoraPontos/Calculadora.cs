using CasaPopular.CalculadoraPontos.Criterios;
using CasaPopular.Entidades;
using System.Collections.Generic;

namespace CasaPopular.CalculadoraPontos
{
    public class Calculadora : ICalculadora
    {
        IList<ICriterio> criterios;

        public Calculadora()
        {
            criterios = new List<ICriterio>();
            criterios.Add(new Renda());
            criterios.Add(new NumeroDependentes());
        }

        public int Calcula(Familia familia)
        {
            var pontos = 0;
            foreach (var criterio in criterios)            
                pontos += criterio.GetPontos(familia);
            
            return pontos;
        }
    }
}
