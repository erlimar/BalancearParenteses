using System.Linq;

namespace BalanceadorDeParenteses
{
    public class Balanceador
    {
        const char PARENTESES_ABRE = '(';
        const char PARENTESES_FECHA = ')';

        public static bool Balanceavel(string valor)
        {
            return Balanceavel(valor, 0, 0) == 0;
        }

        public static int Balanceavel(string valor, int posicao, int emAberto)
        {
            if (valor.Length < posicao + 1)
                return emAberto;

            var item = valor.ElementAt(posicao);

            if (item == PARENTESES_ABRE)
                emAberto++;
            
            else if (item == PARENTESES_FECHA)
                emAberto--;

            emAberto = Balanceavel(valor, ++posicao, emAberto);

            return emAberto;
        }
    }
}
