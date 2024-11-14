using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone -- DONE!
Iphone iphone = new Iphone("2199999999", "iPhone 15 Pro Max", "4747437437", 128);
Console.WriteLine("Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Nokia nokia = new Nokia("21911112222", "Nokia C12", "7433843743", 64);
Console.WriteLine(Environment.NewLine + "Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");


