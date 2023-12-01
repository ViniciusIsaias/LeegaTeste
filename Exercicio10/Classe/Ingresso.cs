namespace Exercicio10.Classe
{
    public class Ingresso
    {
        public decimal Valor { get; set; }

        public override string ToString()
        {
            return Valor.ToString("C2");
        }
    }
}
