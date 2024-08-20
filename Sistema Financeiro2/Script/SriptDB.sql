-- Tabela Cliente
CREATE TABLE [dbo].[Cliente] (
    [ID]             INT           IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (100) NULL,
    [CPF]            VARCHAR (14)  NOT NULL, 
    [Genero]         VARCHAR (10)  NULL,
    [Endereco]       VARCHAR (255) NULL,
    [Telefone]       VARCHAR (20)  NULL,
    [DataNascimento] DATE          NULL,
    [DataCadastro]   DATE          NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([CPF] ASC)
);

-- Tabela Descricao
CREATE TABLE [dbo].[Descricao] (
    [ID]         INT  IDENTITY (1, 1) NOT NULL,
    [Descricao]  TEXT NULL,
    [ID_Cliente] INT  NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([ID_Cliente]) REFERENCES [dbo].[Cliente] ([ID]) ON DELETE CASCADE
);

-- Tabela Funcionario
CREATE TABLE [dbo].[Funcionario] (
    [ID]                     INT           IDENTITY (1, 1) NOT NULL,
    [CPF]                    VARCHAR (14)  NOT NULL,
    [Nome]                   VARCHAR (100) NULL,
    [Genero]                 VARCHAR (10)  NULL,
    [Endereco]               VARCHAR (255) NULL,
    [Telefone]               VARCHAR (20)  NULL,
    [DataNascimento]         DATE          NULL,
    [NumeroCarteiraTrabalho] VARCHAR (20)  NULL,
    [DataCadastro]           DATE          NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([CPF] ASC)
);

-- Tabela Servico
CREATE TABLE [dbo].[Servico] (
    [ID]        INT             IDENTITY (1, 1) NOT NULL,
    [Descricao] VARCHAR (255)   NULL,
    [Valor]     DECIMAL (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

-- Tabela OrdemDeServico
CREATE TABLE [dbo].[OrdemDeServico] (
    [ID]              INT           IDENTITY (1, 1) NOT NULL,
    [ID_Cliente]      INT           NOT NULL,
    [DataCriacao]     DATE          NOT NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([ID_Cliente]) REFERENCES [dbo].[Cliente] ([ID]) ON DELETE CASCADE
);

-- Ajustar Tabela ClienteServicoEscolhido
CREATE TABLE [dbo].[ClienteServicoEscolhido] (
    [ID]                INT  IDENTITY (1, 1) NOT NULL,
    [ID_Cliente]        INT  NOT NULL,
    [ID_Servico]        INT  NOT NULL,
    [ID_OrdemDeServico] INT  NOT NULL,
    [Quantidade]        INT  NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([ID_Cliente]) REFERENCES [dbo].[Cliente] ([ID]) ON DELETE CASCADE,
    FOREIGN KEY ([ID_Servico]) REFERENCES [dbo].[Servico] ([ID]) ON DELETE CASCADE,
    FOREIGN KEY ([ID_OrdemDeServico]) REFERENCES [dbo].[OrdemDeServico] ([ID]) ON DELETE NO ACTION
);

-- Tabela Orcamento
CREATE TABLE [dbo].[Orcamento] (
    [ID]                 INT           IDENTITY (1, 1) NOT NULL,
    [ID_Cliente]         INT           NOT NULL,
    [ID_OrdemDeServico]  INT           NOT NULL,
    [DataContratacao]    DATE          NOT NULL,
    [FormaPagamento]     VARCHAR(50)   NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([ID_Cliente]) REFERENCES [dbo].[Cliente] ([ID]) ON DELETE NO ACTION,
    FOREIGN KEY ([ID_OrdemDeServico]) REFERENCES [dbo].[OrdemDeServico] ([ID]) ON DELETE CASCADE
);

-- Tabela Debito
CREATE TABLE [dbo].[Debito] (
    [ID]             INT             IDENTITY (1, 1) NOT NULL,
    [ID_Orcamento]   INT             NOT NULL,
    [ValorParcela]   DECIMAL (10, 2) NOT NULL,
    [DataVencimento] DATE            NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([ID_Orcamento]) REFERENCES [dbo].[Orcamento] ([ID])
);

-- Tabela Pagamento
CREATE TABLE [dbo].[Pagamento] (
    [ID]             INT             IDENTITY (1, 1) NOT NULL,
    [ID_Cliente]     INT             NOT NULL,
    [Valor]          DECIMAL (10, 2) NOT NULL,
    [DataPagamento]  DATE            NOT NULL DEFAULT GETDATE(),
    [ID_Funcionario] INT             NOT NULL,
    [ID_Debito]      INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([ID_Cliente]) REFERENCES [dbo].[Cliente] ([ID]) ON DELETE NO ACTION,
    FOREIGN KEY ([ID_Funcionario]) REFERENCES [dbo].[Funcionario] ([ID]) ON DELETE NO ACTION,
    FOREIGN KEY ([ID_Debito]) REFERENCES [dbo].[Debito] ([ID]) ON DELETE CASCADE
);



-- Inserção de dados
-- Dados para a tabela Cliente
INSERT INTO [dbo].[Cliente] (Nome, CPF, Genero, Endereco, Telefone, DataNascimento)
VALUES 
('João Silva', '123.456.789-00', 'Masculino', 'Rua A, 123', '11987654321', '1980-01-01'),
('Maria Souza', '987.654.321-00', 'Feminino', 'Avenida B, 456', '11987654322', '1985-02-02'),
('João Silva', '111.111.111-11', 'Masculino', 'Rua A, 123', '11999999999', '1980-01-01'),
('Maria Oliveira', '222.222.222-22', 'Feminino', 'Rua B, 456', '21988888888', '1990-02-02'),
('Carlos Santos', '333.333.333-33', 'Masculino', 'Rua C, 789', '31977777777', '2000-03-03'),
('Ana Costa', '444.444.444-44', 'Feminino', 'Rua D, 101', '41966666666', '1975-04-04');

-- Dados para a tabela Descricao
INSERT INTO [dbo].[Descricao] (Descricao, ID_Cliente)
VALUES
('Cliente VIP', 1),
('Cliente Regular', 2),
('Cliente Novo', 3),
('Cliente Inativo', 4);

-- Dados para a tabela Funcionario
INSERT INTO [dbo].[Funcionario] (CPF, Nome, Genero, Endereco, Telefone, DataNascimento, NumeroCarteiraTrabalho)
VALUES 
('111.222.333-44', 'Carlos Lima', 'Masculino', 'Rua C, 789', '11987654323', '1990-03-03', 'CT123456'),
('555.666.777-88', 'Ana Pereira', 'Feminino', 'Avenida D, 101', '11987654324', '1995-04-04', 'CT654321'),
('555.555.555-55', 'Pedro Lima', 'Masculino', 'Rua E, 202', '51955555555', '1985-05-05', '1234567890'),
('666.666.666-66', 'Laura Melo', 'Feminino', 'Rua F, 303', '61944444444', '1995-06-06', '0987654321'),
('777.777.777-77', 'Ricardo Almeida', 'Masculino', 'Rua G, 404', '71933333333', '1970-07-07', '1122334455'),
('888.888.888-88', 'Julia Pereira', 'Feminino', 'Rua H, 505', '81922222222', '2005-08-08', '5566778899');

-- Dados para a tabela Servico
INSERT INTO [dbo].[Servico] (Descricao, Valor)
VALUES 
('Consultoria', 200.00),
('Desenvolvimento de Software', 1500.00),
('Consultoria Financeira', 500.00),
('Assessoria de Investimentos', 1000.00),
('Planejamento Tributário', 750.00),
('Gestão Patrimonial', 1250.00);

-- Dados para a tabela OrdemDeServico
INSERT INTO [dbo].[OrdemDeServico] (ID_Cliente, DataCriacao)
VALUES
(1, GETDATE()),
(2, GETDATE()),
(3, GETDATE()),
(4, GETDATE()),
(5, GETDATE()),
(6, GETDATE());

-- Mais 20 casos para a tabela ClienteServicoEscolhido
INSERT INTO [dbo].[ClienteServicoEscolhido] (ID_Cliente, ID_Servico, ID_OrdemDeServico, Quantidade)
VALUES 
(1, 2, 1, 2),
(1, 3, 1, 1),
(2, 1, 2, 3),
(2, 3, 2, 1),
(3, 1, 3, 2),
(3, 2, 3, 1),
(4, 1, 4, 1),
(4, 3, 4, 2),
(5, 1, 5, 3),
(5, 3, 5, 1),
(6, 1, 6, 1),
(6, 2, 6, 2),
(1, 4, 1, 1),
(2, 4, 2, 1),
(3, 4, 3, 1),
(4, 4, 4, 1),
(5, 4, 5, 1),
(6, 4, 6, 1),
(1, 5, 1, 1),
(2, 5, 2, 1),
(3, 5, 3, 1),
(4, 5, 4, 1),
(5, 5, 5, 1),
(6, 5, 6, 1),
(1, 6, 1, 1),
(2, 6, 2, 1),
(3, 6, 3, 1),
(4, 6, 4, 1),
(5, 6, 5, 1),
(6, 6, 6, 1);


-- Dados para a tabela Orcamento
INSERT INTO [dbo].[Orcamento] (ID_Cliente, ID_OrdemDeServico, DataContratacao, FormaPagamento)
VALUES 
(1, 1, '2023-01-01', 'À vista'),
(2, 2, '2023-02-01', 'Parcelado'),
(3, 3, '2023-03-01', 'Transferência Bancária'),
(4, 4, '2023-04-01', 'Dinheiro'),
(5, 5, '2023-05-01', 'Cartão de Crédito'),
(6, 6, '2023-06-01', 'Boleto Bancário');

-- Dados para a tabela Debito
INSERT INTO [dbo].[Debito] (ID_Orcamento, ValorParcela, DataVencimento)
VALUES 
(1, 200.00, '2023-02-01'),
(2, 500.00, '2023-03-01'),
(2, 500.00, '2023-04-01'),
(2, 500.00, '2023-05-01'),
(3, 2250.00, '2023-04-01'),
(4, 1250.00, '2023-05-01'),
(5, 1000.00, '2023-06-01');

-- Dados para a tabela Pagamento
INSERT INTO [dbo].[Pagamento] (ID_Cliente, Valor, DataPagamento, ID_Funcionario, ID_Debito)
VALUES
(1, 200.00, '2023-01-01', 1, 1),
(2, 1500.00, '2023-02-01', 2, 2),
(3, 2250.00, '2023-03-01', 3, 5),
(4, 1250.00, '2023-04-01', 4, 6);

--Valor Total das Parcelas Atrasadas
SELECT 
    SUM(ValorParcela) AS ValorTotalParcelasAtrasadas
FROM 
    [dbo].[Debito]
WHERE 
    DataVencimento < GETDATE() AND
    ID NOT IN (SELECT ID_Debito FROM [dbo].[Pagamento]);


--Parcelas com Data de Vencimento, Valor, Nome e CPF do Cliente
SELECT 
    d.DataVencimento,
    d.ValorParcela,
    c.Nome,
    c.CPF
FROM 
    [dbo].[Debito] d
JOIN 
    [dbo].[Orcamento] o ON d.ID_Orcamento = o.ID
JOIN 
    [dbo].[Cliente] c ON o.ID_Cliente = c.ID;

--Parcelas Atrasadas com Data de Vencimento, Valor, Nome e CPF do Cliente
SELECT 
    d.DataVencimento,
    d.ValorParcela,
    c.Nome,
    c.CPF
FROM 
    [dbo].[Debito] d
JOIN 
    [dbo].[Orcamento] o ON d.ID_Orcamento = o.ID
JOIN 
    [dbo].[Cliente] c ON o.ID_Cliente = c.ID
WHERE 
    d.DataVencimento < GETDATE()
    AND NOT EXISTS (
        SELECT 1
        FROM [dbo].[Pagamento] p
        WHERE p.ID_Debito = d.ID
    );

--Valor Total das Parcelas no Mês Atual
SELECT 
    SUM(d.ValorParcela) AS ValorTotalParcelasMesAtual
FROM 
    [dbo].[Debito] d
WHERE 
    MONTH(d.DataVencimento) = MONTH(GETDATE()) 
    AND YEAR(d.DataVencimento) = YEAR(GETDATE());

-- Servicos contratados pelo cliente 1
SELECT 
    cs.ID_Cliente,
    s.Descricao AS Servico,
    s.Valor AS ValorServico,
    cs.Quantidade,
    os.ID AS NumeroOrdemServico
FROM 
    [dbo].[ClienteServicoEscolhido] cs
JOIN 
    [dbo].[Servico] s ON cs.ID_Servico = s.ID
JOIN 
    [dbo].[OrdemDeServico] os ON cs.ID_OrdemDeServico = os.ID
WHERE 
    cs.ID_Cliente = 1;

--Indadimplentes
SELECT
    c.ID,
    c.Nome,
    c.CPF,
    SUM(d.ValorParcela) AS ValorDebito,
    'Inadimplente' AS Status
FROM 
    [dbo].[Cliente] c
JOIN 
    [dbo].[Orcamento] o ON c.ID = o.ID_Cliente
JOIN 
    [dbo].[Debito] d ON o.ID = d.ID_Orcamento
WHERE 
    d.DataVencimento < GETDATE()
    AND d.ID NOT IN (SELECT ID_Debito FROM [dbo].[Pagamento])
GROUP BY
    c.ID, c.Nome, c.CPF;


-- Desativar todas as restrições de chave estrangeira
DECLARE @TableName NVARCHAR(128)
DECLARE @ForeignKeyName NVARCHAR(128)

DECLARE table_cursor CURSOR FOR
SELECT 
    t.name AS TableName,
    fk.name AS ForeignKeyName
FROM 
    sys.foreign_keys fk
INNER JOIN 
    sys.tables t ON fk.parent_object_id = t.object_id

OPEN table_cursor
FETCH NEXT FROM table_cursor INTO @TableName, @ForeignKeyName

WHILE @@FETCH_STATUS = 0
BEGIN
    EXEC sp_executesql N'ALTER TABLE ' + QUOTENAME(@TableName) + ' NOCHECK CONSTRAINT ' + QUOTENAME(@ForeignKeyName)
    FETCH NEXT FROM table_cursor INTO @TableName, @ForeignKeyName
END

CLOSE table_cursor
DEALLOCATE table_cursor

-- Excluir os dados de todas as tabelas
EXEC sp_MSForEachTable 'DELETE FROM ?'

-- Restabelecer todas as restrições de chave estrangeira
DECLARE fk_cursor CURSOR FOR
SELECT 
    t.name AS TableName,
    fk.name AS ForeignKeyName
FROM 
    sys.foreign_keys fk
INNER JOIN 
    sys.tables t ON fk.parent_object_id = t.object_id

OPEN fk_cursor
FETCH NEXT FROM fk_cursor INTO @TableName, @ForeignKeyName

WHILE @@FETCH_STATUS = 0
BEGIN
    EXEC sp_executesql N'ALTER TABLE ' + QUOTENAME(@TableName) + ' WITH CHECK CHECK CONSTRAINT ' + QUOTENAME(@ForeignKeyName)
    FETCH NEXT FROM fk_cursor INTO @TableName, @ForeignKeyName
END

CLOSE fk_cursor
DEALLOCATE fk_cursor

--Apagar todos os dados
USE [C:\USERS\JHON_\DOCUMENTS\DATABASE.MDF]; 

BEGIN TRANSACTION;

DECLARE @sql NVARCHAR(MAX) = N'';

-- Gerar o comando DELETE para cada tabela no banco de dados
SELECT @sql += N'DELETE FROM ' + QUOTENAME(s.name) + N'.' + QUOTENAME(t.name) + N';' + CHAR(13)
FROM sys.tables t
INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
WHERE t.type = 'U'; -- Apenas tabelas de usuário, exclui tabelas do sistema

-- Executar o comando DELETE
EXEC sp_executesql @sql;

-- Resetar identidades (caso necessário)
EXEC sp_MSforeachtable 'DBCC CHECKIDENT(''?'', RESEED, 0)';

-- Mensagem de conclusão
PRINT 'Todos os dados do banco de dados foram resetados com sucesso.';

-- Comitar a transação
COMMIT TRANSACTION;

---------------------------------------------------------------------------------------------------------------------------------------------
-- Apagar Todas as tabelas
USE [C:\USERS\JHON_\DOCUMENTS\DATABASE.MDF];

-- Desativar todas as restrições de chave estrangeira
DECLARE @sql_disable_constraints NVARCHAR(MAX) = N'';

SELECT @sql_disable_constraints += N'ALTER TABLE ' + QUOTENAME(s.name) + N'.' + QUOTENAME(t.name) + N' NOCHECK CONSTRAINT ALL;' + CHAR(13)
FROM sys.tables t
INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
WHERE t.type = 'U'; -- Apenas tabelas de usuário, exclui tabelas do sistema

EXEC sp_executesql @sql_disable_constraints;

-- Deletar todas as tabelas de usuário
DECLARE @sql_drop_tables NVARCHAR(MAX) = N'';

SELECT @sql_drop_tables += N'DROP TABLE ' + QUOTENAME(s.name) + N'.' + QUOTENAME(t.name) + N';' + CHAR(13)
FROM sys.tables t
INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
WHERE t.type = 'U'; -- Apenas tabelas de usuário, exclui tabelas do sistema

EXEC sp_executesql @sql_drop_tables;

-- Restabelecer todas as restrições de chave estrangeira
DECLARE @sql_enable_constraints NVARCHAR(MAX) = N'';

SELECT @sql_enable_constraints += N'ALTER TABLE ' + QUOTENAME(s.name) + N'.' + QUOTENAME(t.name) + N' WITH CHECK CHECK CONSTRAINT ALL;' + CHAR(13)
FROM sys.tables t
INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
WHERE t.type = 'U'; -- Apenas tabelas de usuário, exclui tabelas do sistema

EXEC sp_executesql @sql_enable_constraints;

-- Mensagem de conclusão
PRINT 'Todas as tabelas do banco de dados foram deletadas com sucesso.';

