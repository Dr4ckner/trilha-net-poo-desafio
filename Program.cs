using DesafioPOO.Models;

// TESTES REALIZADOS

Nokia nokia = new Nokia("13515152109", "Modelo 1", "11111111", 128);
Iphone iphone = new Iphone("11395102914", "Modelo 2", "22222222", 256);

Console.WriteLine("NOKIA");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
nokia.MeuNumero();
nokia.Armazenamento();
Console.WriteLine("");
Console.WriteLine("IPHONE");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.MeuNumero();
iphone.Armazenamento();