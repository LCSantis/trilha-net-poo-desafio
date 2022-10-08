using DesafioPOO.Models;

Iphone i = new Iphone("135", "1111", "010101010101", 64);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Telegram");

Nokia n = new Nokia("246", "2222", "24242424242424", 128);
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Whatsapp");
// TODO: Realizar os testes com as classes Nokia e Iphone