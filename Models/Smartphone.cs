namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string IMEI { get; set; }
        protected string Modelo { get; set; }
        protected int Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama = FINALIZADO !!!
        //Construtor da classe
        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero; //Passa o parametro "numero" para a propriedade "Numero"
            IMEI = imei; //Passa o parametro "imei" para a propriedade "IMEI"
            Modelo = modelo; //Passa o parametro "modelo" para a propriedade "Modelo"
            Memoria = memoria; //Passa o parametro "memoria" para a propriedade "Memoria"

            // TODO: Passar os parâmetros do construtor para as propriedades = FINALIZADO !!!
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}