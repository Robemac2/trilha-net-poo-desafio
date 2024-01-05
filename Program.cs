using DesafioPOO.Models;

Console.WriteLine("Novo Smartphone Nokia:\n");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Modelo 1", imei: "111111111", memoria: 64, fabricante: "Nokia");
nokia.DetalhesSmartphone();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n-----\n");

Console.WriteLine("Novo Smartphone Iphone:\n");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Modelo 2", imei: "222222222", memoria: 128, fabricante: "Apple");
iphone.DetalhesSmartphone();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");