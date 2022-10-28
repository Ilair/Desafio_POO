using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "55997548541", modelo:"Nokia C20", imei:"111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Discord");
Console.WriteLine("\n");

Console.WriteLine("Iphone");

Smartphone iphone = new Iphone(numero: "5599658745", modelo:"Iphone 13 Pró max", imei:"234567891", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");