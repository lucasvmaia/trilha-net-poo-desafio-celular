using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "(11) 12345-6789", modelo: "Nokia Modelo 1", imei: "11111", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\nSmartphone Iphone");
Smartphone iphone = new Iphone(numero: "(15) 98745-028596", modelo: "Iphone Modelo 9", imei: "22222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Word");