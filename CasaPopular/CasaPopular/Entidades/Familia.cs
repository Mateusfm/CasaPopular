using CasaPopular.CalculadoraPontos;
using System.Collections.Generic;
using System.Linq;

namespace CasaPopular.Entidades
{
    public class Familia
    {
        public Familia(Pessoa responsavel)
        {
            Responsavel = responsavel;
            _demaisIntegrantes = new List<Pessoa>();
        }

        public Pessoa Responsavel { get; set; }
        private IList<Pessoa> _demaisIntegrantes;
        public int QtdeDependentes { get; private set; }
        public int Pontuacao { get; private set; }

        public void AddIntegrante(Pessoa novoIntegrante)
        {
            if (novoIntegrante.EhDependente())
                QtdeDependentes += 1;

            _demaisIntegrantes.Add(novoIntegrante);
        }

        public void SetPontuacao(ICalculadora calculadora)
        {
            Pontuacao = calculadora.Calcula(this);
        }

        public decimal GetRenda()
        {
            return Responsavel.Renda + _demaisIntegrantes.Sum(x => x.Renda);
        }

        public override string ToString()
        {
            return $@"Família do(a): {Responsavel.Nome}
Renda total: {string.Format("{0:C}", GetRenda())}
Dependentes: {QtdeDependentes}
Pontuação: {Pontuacao}";
        }
    }
}
