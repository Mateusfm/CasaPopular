using CasaPopular.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CasaPoppular.Test.Entidades
{
    public class FamiliaGetRenda
    {
        [Fact]
        public void AoReceberIntegrantesSemRenda_DeveRetornarRendaDoResponsavel()
        {
            var responsavel = new Pessoa("João", DateTime.Today.AddYears(-30), 3000);
            var pessoa2 = new Pessoa("Enzo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE - 7)), 0);
            var pessoa3 = new Pessoa("Abelardo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE - 1)), 0);

            var familia = new Familia(responsavel);
            familia.AddIntegrante(pessoa2);
            familia.AddIntegrante(pessoa3);

            Assert.Equal(responsavel.Renda, familia.GetRenda());
        }

        [Fact]
        public void AoReceberIntegrantesComRenda_DeveRetornarRendaDeTodosSomada()
        {
            var rendaResp = 3000;
            var rendaPessoa2 = 1001;
            var rendaPessoa3 = 1002;
            var responsavel = new Pessoa("João", DateTime.Today.AddYears(-30), rendaResp);
            var pessoa2 = new Pessoa("Enzo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE + 7)), rendaPessoa2);
            var pessoa3 = new Pessoa("Abelardo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE + 1)), rendaPessoa3);

            var familia = new Familia(responsavel);
            familia.AddIntegrante(pessoa2);
            familia.AddIntegrante(pessoa3);

            Assert.Equal(rendaResp + rendaPessoa2 + rendaPessoa3, familia.GetRenda());
        }
    }
}
