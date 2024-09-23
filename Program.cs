using DesafioPOO.Models;

Iphone a1 = new Iphone("12345644", "22222222", "123123123", 123); //Atribuições através do construtor

a1.Ligar();
a1.ReceberLigacao();
a1.InstalarAplicativo("whatsApp"); //Atribuição do valor do App

Nokia n1 = new Nokia("7978978987", "333333330", "123123123", 123);

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Telegram"); 
// TODO: Realizar os testes com as classes Nokia e Iphone