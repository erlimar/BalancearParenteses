using Xunit;

namespace BalanceadorDeParenteses.Test
{
    public class BalanceadorTests
    {
        [Theory]
        [InlineData("((1+1)*2) + (10+2) + (((2-1)-1)*1)")]
        [InlineData("O Fulano (aquele que fez aniversário hoje) perguntou por você.")]
        public void Aceita_Parenteses_Balanceados(string valor)
        {
            Assert.True(Balanceador.Balanceavel(valor));
        }

        [Theory]
        [InlineData("&:)")]
        [InlineData("#:)")]
        [InlineData("isso ) *(aqui agora (1+2) é inválido, foi um BUG proposital resolvido após uma refatoração")]
        public void Nao_Aceita_Parenteses_Balanceados(string valor)
        {
            Assert.False(Balanceador.Balanceavel(valor));
        }
    }
}
