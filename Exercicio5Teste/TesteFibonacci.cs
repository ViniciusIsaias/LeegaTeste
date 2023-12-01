namespace Exercicio5Teste
{
    public class TesteFibonacci
    {
        public static int SequenciaFibonacci(int sequencia)
        {
            try
            {
                int numeroAnterior = 0;
                int numeroAtual = 1;
                int fibonacci = 0;

                if (sequencia == 0)
                {
                    return fibonacci;
                }
                else if (sequencia == 1)
                {
                    fibonacci = 1;
                    return fibonacci;
                }
                else if (sequencia == 2)
                {
                    fibonacci = 1;
                    return fibonacci;
                }

                for (int i = 2; i <= sequencia; i++)
                {
                    fibonacci = numeroAnterior + numeroAtual;
                    numeroAnterior = numeroAtual;
                    numeroAtual = fibonacci;
                }

                return fibonacci;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}