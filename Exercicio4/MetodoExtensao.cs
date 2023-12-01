namespace Exercicio4
{
    public static class MetodoExtensao
    {
        public static int FormatoAnoMes(this DateTime data)
        {
            return Convert.ToInt32(data.ToString("yyyyMM"));
        }
    }
}
