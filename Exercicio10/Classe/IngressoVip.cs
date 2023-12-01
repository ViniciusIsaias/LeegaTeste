namespace Exercicio10.Classe
{
    public class IngressoVip : Ingresso
    {
        public decimal ValorAdicional { get; set; }

        public override string ToString()
        {
            var valor = ValorAdicional + Valor;
            return valor.ToString("C2");
        }
    }
}
