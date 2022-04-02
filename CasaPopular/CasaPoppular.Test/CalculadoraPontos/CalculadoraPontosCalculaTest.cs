using CasaPopular.CalculadoraPontos;
using CasaPopular.Entidades;
using System;
using Xunit;

namespace CasaPoppular.Test.CalculadoraPontos
{
    public class CalculadoraPontosCalculaTest
    {
        [Fact]
        public void AoReceberFamiliaComRenda_1501_SemDependentes_DeveRetornar_0_Pontos()
        {
            var rendaResp = 1501;
            var rendaPessoa2 = 0;
            var rendaPessoa3 = 0;
            var responsavel = new Pessoa("João", DateTime.Today.AddYears(-30), rendaResp);
            var pessoa2 = new Pessoa("Enzo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE + 7)), rendaPessoa2);
            var pessoa3 = new Pessoa("Abelardo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE + 1)), rendaPessoa3);

            var familia = new Familia(responsavel);
            familia.AddIntegrante(pessoa2);
            familia.AddIntegrante(pessoa3);

            Assert.Equal(0, new Calculadora().Calcula(familia));
        }

        [Fact]
        public void AoReceberFamiliaComRendaAte_900_E_SemDependentes_DeveRetornar_5_Pontos()
        {
            var rendaResp = 900;
            var rendaPessoa2 = 0;
            var rendaPessoa3 = 0;
            var responsavel = new Pessoa("João", DateTime.Today.AddYears(-30), rendaResp);
            var pessoa2 = new Pessoa("Enzo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE + 7)), rendaPessoa2);
            var pessoa3 = new Pessoa("Abelardo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE + 1)), rendaPessoa3);

            var familia = new Familia(responsavel);
            familia.AddIntegrante(pessoa2);
            familia.AddIntegrante(pessoa3);

            Assert.Equal(5, new Calculadora().Calcula(familia));
        }

        [Fact]
        public void AoReceberFamiliaComRendaEntre_901_e_1500_SemDependentes_DeveRetornar_3_Pontos()
        {
            var rendaResp = 900;
            var rendaPessoa2 = 1;
            var rendaPessoa3 = 0;
            var responsavel = new Pessoa("João", DateTime.Today.AddYears(-30), rendaResp);
            var pessoa2 = new Pessoa("Enzo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE + 7)), rendaPessoa2);
            var pessoa3 = new Pessoa("Abelardo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE + 1)), rendaPessoa3);

            var familia = new Familia(responsavel);
            familia.AddIntegrante(pessoa2);
            familia.AddIntegrante(pessoa3);

            Assert.Equal(3, new Calculadora().Calcula(familia));
        }

        [Fact]
        public void AoReceberFamiliaComRendaAte_900_Com_3_OuMaisDependentes_DeveRetornar_8_Pontos()
        {
            var rendaResp = 900;
            var rendaPessoa2 = 0;
            var rendaPessoa3 = 0;
            var rendaPessoa4 = 0;
            var responsavel = new Pessoa("João", DateTime.Today.AddYears(-30), rendaResp);
            var pessoa2 = new Pessoa("Enzo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE - 7)), rendaPessoa2);
            var pessoa3 = new Pessoa("Abelardo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE - 1)), rendaPessoa3);
            var pessoa4 = new Pessoa("Rosicléia", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE - 1)), rendaPessoa4);

            var familia = new Familia(responsavel);
            familia.AddIntegrante(pessoa2);
            familia.AddIntegrante(pessoa3);
            familia.AddIntegrante(pessoa4);

            Assert.Equal(8, new Calculadora().Calcula(familia));
        }

        [Fact]
        public void AoReceberFamiliaComRendaAte_900_ComAte_2_Dependentes_DeveRetornar_7_Pontos()
        {
            var rendaResp = 900;
            var rendaPessoa2 = 0;
            var rendaPessoa3 = 0;
            var responsavel = new Pessoa("João", DateTime.Today.AddYears(-30), rendaResp);
            var pessoa2 = new Pessoa("Enzo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE - 7)), rendaPessoa2);
            var pessoa3 = new Pessoa("Abelardo", DateTime.Today.AddYears(-(Pessoa.IDADE_CONSIDERADO_DEPENDENTE - 1)), rendaPessoa3);
            
            var familia = new Familia(responsavel);
            familia.AddIntegrante(pessoa2);
            familia.AddIntegrante(pessoa3);

            Assert.Equal(7, new Calculadora().Calcula(familia));
        }
    }
}
