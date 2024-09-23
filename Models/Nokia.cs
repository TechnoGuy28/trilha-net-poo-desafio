namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
        }

        public string NomeApp { get; set; }
        public override void InstalarAplicativo(string nomeApp)
        {
            NomeApp = nomeApp;
            Console.WriteLine($"Instalando {nomeApp}. Por favor, aguarde");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}