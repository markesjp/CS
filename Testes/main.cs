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
