using CasaPopular.Utils;
using System;
using Xunit;

namespace CasaPoppular.Test.Utils
{
    public class DataUtilsGetIdadeTest
    {
        [Fact]
        public void DeveRetornar18AnosAoReceberDataDe18AnosAtras()
        {
            var data = DateTime.Now.AddYears(-18);

            Assert.Equal(18, DataUtils.GetIdade(data));
        }

        [Fact]
        public void DeveRetornar17AnosAoReceberDataDe17AnosAtras()
        {
            var data = DateTime.Now.AddYears(-18);
            data = data.AddDays(-1);

            Assert.Equal(17, DataUtils.GetIdade(data));
        }

        [Fact]
        public void DeveRetornar18AnosAoReceberDataDe18AnosE1DiaAtras()
        {
            var data = DateTime.Now.AddYears(-18);
            data = data.AddDays(1);

            Assert.Equal(18, DataUtils.GetIdade(data));
        }
    }
}
