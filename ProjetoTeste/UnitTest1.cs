using Exercicio4;
using Exercicio5Teste;

namespace ProjetoTeste
{
    public class UnitTest1
    {
        [Fact]
        public void TesteExercicio4()
        {
            var data = DateTime.Now;
            Assert.Equal(202312, MetodoExtensao.FormatoAnoMes(data));
        }

        [Fact]
        public void TesteExercicio5()
        {
            Assert.Equal(34, TesteFibonacci.SequenciaFibonacci(9));
        }
    }
}