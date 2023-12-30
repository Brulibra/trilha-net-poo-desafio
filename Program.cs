using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "123444444444444", modelo: "Nokia Lumia", imei: "060106", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("IPhone");
Smartphone iphone = new Iphone(numero: "12", modelo: "Iphone 11", imei: "6", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine("\n");
