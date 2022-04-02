using CasaPopular.Entidades;
using System;
using Xunit;

namespace CasaPoppular.Test.Entidades
{
    public class FamiliaAddIntegrante
    {
        [Fact]
        public void AoAddDoisIntegrantesDependentesDeveRetornar2NaQtdeDependentes()
        {
            var pessoa1 = new Pessoa("João", DateTime.Today.AddYears(-30), 3000);
            var pessoa2 = new Pessoa("Enzo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE -7)), 0);
            var pessoa3 = new Pessoa("Abelardo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE - 1)), 0);

            var familia = new Familia(pessoa1);
            familia.AddIntegrante(pessoa2);
            familia.AddIntegrante(pessoa3);

            Assert.Equal(2, familia.QtdeDependentes);
        }

        [Fact]
        public void AoAddDoisIntegrantes_NAO_DependentesDeveRetornar_0_NaQtdeDependentes()
        {
            var pessoa1 = new Pessoa("João", DateTime.Today.AddYears(-30), 3000);
            var pessoa2 = new Pessoa("Enzo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE + 1)), 0);
            var pessoa3 = new Pessoa("Abelardo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE + 2)), 0);

            var familia = new Familia(pessoa1);
            familia.AddIntegrante(pessoa2);
            familia.AddIntegrante(pessoa3);

            Assert.Equal(0, familia.QtdeDependentes);
        }
    }
}
