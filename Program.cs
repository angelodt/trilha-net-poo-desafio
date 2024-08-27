using DesafioPOO.Models;

//Testes criando smartphones
Iphone iphone = new Iphone("1111", "8", "1234abc", 64);
iphone.InfoSmartphone();

Nokia nokia= new Nokia("2222","1110","abc321",1);
nokia.InfoSmartphone();

//Testes efetuando e recebendo ligações
iphone.Ligar();
nokia.ReceberLigacao();

nokia.Ligar();
iphone.ReceberLigacao();

//Testes listando e instalando aplicativos
iphone.ListarAplicativosInstalados();
iphone.InstalarAplicativo("app1");
iphone.InstalarAplicativo("app2".ToLower());
iphone.InstalarAplicativo("");
iphone.ListarAplicativosInstalados();

nokia.ListarAplicativosInstalados();
nokia.InstalarAplicativo("app1".ToUpper());
nokia.InstalarAplicativo("");
nokia.InstalarAplicativo("app2");
nokia.ListarAplicativosInstalados();

//Testes removendo e listando aplicativos
iphone.RemoverAplicativo("app1");
iphone.RemoverAplicativo("app2");
iphone.RemoverAplicativo("app3");
iphone.RemoverAplicativo("");
iphone.ListarAplicativosInstalados();

nokia.RemoverAplicativo("app1");
nokia.RemoverAplicativo("app2");
nokia.RemoverAplicativo("app3");
nokia.RemoverAplicativo("");
nokia.ListarAplicativosInstalados();
