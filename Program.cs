using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "11 9999-888", modelo: "Modelo Tijolão", imei: "2223444142", memoria: 124);
nokia.Ligar();
nokia.InstalarAplicativo("TikTok");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "16 8888-999", modelo: "11 Pro Max", imei: "991922923022022", memoria: 240);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();