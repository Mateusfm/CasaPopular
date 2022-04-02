using CasaPopular.Utils;
using System;

namespace CasaPopular.Entidades
{
    public class Pessoa
    {
        public const int IDADE_CONSIDERADO_DEPENDENTE = 18;

        public Pessoa(string nome, DateTime dataNascimento, decimal renda)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Renda = renda;
        }

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Renda { get; set; }

        public bool EhDependente()
        {
            return DataUtils.GetIdade(DataNascimento) <= IDADE_CONSIDERADO_DEPENDENTE;
        }
    }
}
