using Programa_Cel_Dio;


Smartphone nokia = new Nokia("047-98809-6470", "k77", "2342-2344", 128);
Console.WriteLine(nokia);

string aplicativo = "whatsApp";

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo(aplicativo);

Console.Write("\nTeste Segundo Modelo\n\n");

Smartphone iphone = new Iphone("047-92209-6110", "16", "2342-2344", 128);
Console.WriteLine(iphone);

string aplicativo2 = "Telegram";

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo(aplicativo2);

