using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("1199999999", "Nokia Tijolão", "123456789", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Smartphone iphone = new Iphone("1198888888", "iPhone 14 Pro", "987654321", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.ReadLine();