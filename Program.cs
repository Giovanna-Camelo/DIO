using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456", modelo:"Nokia G60", imei:"2222222222222", memoria:128);


nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");


Console.WriteLine("Smartphone iphone: ");
Smartphone iphone = new Iphone(numero:"789102", modelo:"iphone 15", imei:"333333333333", memoria:512);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");