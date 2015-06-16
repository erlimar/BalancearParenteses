using Xunit;

namespace BalanceadorDeParenteses.Test
{
    public class BalanceadorTests
    {
        [Theory]
        [InlineData("((1+1)*2) + (10+2) + (((2-1)-1)*1)")]
        [InlineData("O Fulano (aquele que fez aniversário hoje) perguntou por você.")]
        [InlineData("isso ) *(aqui também (1+2) é válido, mas é um BUG proposital pra ser resolvido em uma refatoração")]
        public void Aceita_Parenteses_Balanceados(string valor)
        {
            Assert.True(Balanceador.Balanceavel(valor));
        }

        [Theory]
        [InlineData("&:)")]
        [InlineData("#:)")]
        public void Nao_Aceita_Parenteses_Balanceados(string valor)
        {
            Assert.False(Balanceador.Balanceavel(valor));
        }
    }
}
