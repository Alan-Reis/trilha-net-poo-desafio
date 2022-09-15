using DesafioPOO.Models;

Console.WriteLine("Celular Nokia");
Nokia nokia = new Nokia("12345678", "A51", "11111111", 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Celular Iphone");
Iphone iphone = new Iphone("87654321", "Iphone5", "22222222", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");