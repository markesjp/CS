SELECT 
    SUM(Pagamento.Valor) AS ValorTotalRecebidoMesAtual
FROM 
    dbo.Pagamento
WHERE 
    YEAR(Pagamento.DataPagamento) = YEAR(GETDATE()) AND
    MONTH(Pagamento.DataPagamento) = MONTH(GETDATE());

