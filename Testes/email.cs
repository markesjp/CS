using System;
using System.Net;
using System.Net.Mail;

public class Recibo
{
    public string NomeCliente { get; set; }
    public string EnderecoCliente { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }

    public void GerarReciboEEnviarPorEmail(string emailPagador, string emailRecebedor)
    {
        Console.WriteLine("************ RECIBO ************");
        Console.WriteLine("Nome do Cliente: " + NomeCliente);
        Console.WriteLine("Endereço: " + EnderecoCliente);
        Console.WriteLine("Valor: " + Valor.ToString("C")); // Formata o valor como moeda
        Console.WriteLine("Data: " + Data.ToShortDateString()); // Formata a data
        Console.WriteLine("********************************");

        EnviarEmail(emailPagador, "Recibo", "Segue em anexo o recibo emitido.", "Recibo.pdf");
        EnviarEmail(emailRecebedor, "Recibo", "Segue em anexo o recibo emitido.", "Recibo.pdf");
    }

    private void EnviarEmail(string destinatario, string assunto, string corpo, string anexo)
    {
        try
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.seuhost.com")) // Insira o host do seu servidor SMTP
            {
                smtpClient.Port = 587; // Porta padrão para e-mails SMTP
                smtpClient.Credentials = new NetworkCredential("seuemail@seudominio.com", "suasenha"); // Insira seu email e senha
                smtpClient.EnableSsl = true; // Se o seu servidor requer SSL
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("seuemail@seudominio.com"); // Insira o endereço do remetente
                mail.To.Add(destinatario);
                mail.Subject = assunto;
                mail.Body = corpo;
                mail.Attachments.Add(new Attachment(anexo));
                smtpClient.Send(mail);
                Console.WriteLine("E-mail enviado com sucesso para: " + destinatario);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao enviar e-mail: " + ex.Message);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância de Recibo
        Recibo recibo = new Recibo();
        recibo.NomeCliente = "Fulano de Tal";
        recibo.EnderecoCliente = "Rua das Flores, 123";
        recibo.Valor = 100.50m;
        recibo.Data = DateTime.Now;

        // E-mail do pagador e do recebedor
        string emailPagador = "pagador@example.com";
        string emailRecebedor = "recebedor@example.com";

        // Gerando o recibo e enviando por e-mail
        recibo.GerarReciboEEnviarPorEmail(emailPagador, emailRecebedor);
    }
}
