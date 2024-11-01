using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("-----Nokia-----");
Smartphone nokia = new Nokia("119823312", "Modelo Nokia", "111212", 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();

Console.WriteLine("-----Iphone-----");
Smartphone iphone = new Iphone("12923123", "Modelo Iphone", "22323232", 64);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
iphone.ReceberLigacao();