using System;

namespace CasaPopular.Utils
{
    public class DataUtils
    {
        public static int GetIdade(DateTime data)
        {
            int idade = DateTime.Today.Year - data.Year;

            if (DateTime.Today.Month < data.Month || (DateTime.Today.Month == data.Month && data.Day < DateTime.Today.Day))
                idade -= 1;

            return idade;
        }
    }
}
