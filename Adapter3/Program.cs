using Adapter3;

//📌 Cenário real 📌
//Imagine que você tem um sistema interno que precisa enviar notificações de usuários.
//O seu sistema espera uma interface INotificacao com o método Enviar(string msg).
//Mas a biblioteca de terceiros só tem a classe EmailService com o método SendEmail(string assunto, string conteudo).
//Como integrar sem modificar a biblioteca externa? Usamos o Adapter.

// Criamos o serviço externo
var emailService = new EmailService();

// Adaptamos para nossa interface
INotificacao notificacao = new EmailAdapter(emailService);

// Sistema funciona sem depender de EmailService diretamente
var sistema = new Sistema(notificacao);
sistema.Processar();