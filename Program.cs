using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
var nokia = new Nokia("123456", "Modelo A", "111222", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Spotify");
nokia.ReceberLigacao();

Console.WriteLine("===========================================================");

Console.WriteLine("Smartphone Iphone: ");
var iphone = new Iphone("987654", "Modelo X", "555666", 128);
iphone.InstalarAplicativo("Twitter");
iphone.Ligar();
iphone.ReceberLigacao();