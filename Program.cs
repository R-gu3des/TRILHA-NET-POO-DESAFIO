using DesafioPOO.Models;

// Instaciando objetos em ambas as classes
Nokia nokia = new Nokia("123456789", "Nokia Nseries", "1912312189465465", 128);
Iphone iphone = new Iphone("1234556123", "IPhone 15 Pro Max", "191231218000000", 512);

// Utilizando Métodos da classe Nokia
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine(nokia.ToString());

Console.WriteLine("------------------------");

// Utilizando Métodos da classe Iphone
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Apple Music");
Console.WriteLine(iphone.ToString());