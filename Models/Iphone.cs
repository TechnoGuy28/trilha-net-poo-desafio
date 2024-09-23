
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        //Utilizção dos contrutores originais no smartphone
         public Iphone(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        { 
        }
        public string  NomeApp { get; set; } //Criando propriedade para receber o App a ser instalado

        public override void InstalarAplicativo(string nomeApp)
        {
            NomeApp = nomeApp; //Atribuindo o App recebido à propriedade "NomeApp"
            Console.WriteLine($"Intalando {NomeApp} Porfavor, aguarde a conclusão");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}