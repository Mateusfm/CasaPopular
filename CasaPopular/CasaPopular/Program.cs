using CasaPopular.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CasaPopular
{
    class Program
    {
        static void Main(string[] args)
        {
            var responsavel1 = new Pessoa("João", DateTime.Today.AddYears(-30), 900);
            var pessoa2 = new Pessoa("Enzo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE - 7)), 100);
            var pessoa3 = new Pessoa("Abelardo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE - 1)), 0);
            var pessoa4 = new Pessoa("Rosicléia", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE - 1)), 0);

            var familia1 = new Familia(responsavel1);
            familia1.AddIntegrante(pessoa2);
            familia1.AddIntegrante(pessoa3);
            familia1.AddIntegrante(pessoa4);

            var responsavel2 = new Pessoa("Maria", DateTime.Today.AddYears(-30), 10000);
            var pessoa5 = new Pessoa("Dudu", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE + 7)), 100);
            var pessoa6 = new Pessoa("Luís", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE - 1)), 0);

            var familia2 = new Familia(responsavel2);
            familia2.AddIntegrante(pessoa5);
            familia2.AddIntegrante(pessoa6);

            var familias = new List<Familia>();
            familias.Add(familia2);
            familias.Add(familia1);

            ExibeFamilias(familias);

            var calculadoraPontos = new CalculadoraPontos.Calculadora();
            foreach (var item in familias)
                item.SetPontuacao(calculadoraPontos);

            var famOrdenadas = familias.OrderByDescending(x => x.Pontuacao);
            Console.WriteLine("=============== Famílias ordenadas por pontuação ===============");
            ExibeFamilias(famOrdenadas);
        }

        private static void ExibeFamilias(IEnumerable<Familia> familias)
        {
            foreach (var item in familias)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("------------------------------");
            }
        }
    }
}
