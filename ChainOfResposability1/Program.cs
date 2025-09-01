using ChainOfResposability1;

GerenteProjeto gerenteProjeto = new GerenteProjeto();
SupervisorEquipe supervisorEquipe = new SupervisorEquipe();
SetorRH setorRH = new SetorRH();

gerenteProjeto.ProximoAutorizador(supervisorEquipe);
supervisorEquipe.ProximoAutorizador(setorRH);

gerenteProjeto.AutorizarLicenca("Eniavldo", 5);
gerenteProjeto.AutorizarLicenca("Lana", 14);
gerenteProjeto.AutorizarLicenca("Mila", 18);
gerenteProjeto.AutorizarLicenca("Bernardo", 30);
gerenteProjeto.AutorizarLicenca("Rivia", 50);

Console.ReadKey();