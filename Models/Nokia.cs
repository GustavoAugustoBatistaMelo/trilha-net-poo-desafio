namespace DesafioPOO.Models
{
    // Finalizado
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Finalizado
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalando o Aplicativo {nomeApp} no Nokia ");
        }
    }
}