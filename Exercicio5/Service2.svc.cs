using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Exercicio5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService2
    {
        public int SequenciaFibonacci(int sequencia)
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
