
# Sistema Financeiro

## Descrição

O **Sistema Financeiro** é um projeto desenvolvido em C# que simula um sistema de gestão financeira. Ele inclui funcionalidades para gerenciar clientes, funcionários, serviços, e pagamentos. O sistema também se conecta a uma base de dados local para armazenar e recuperar informações.

## Funcionalidades

- **Gerenciamento de Clientes:** Cadastro, edição e exclusão de informações de clientes.
- **Gerenciamento de Funcionários:** Cadastro, edição e exclusão de informações de funcionários.
- **Serviços:** Controle dos serviços financeiros oferecidos, incluindo detalhes e preços.
- **Pagamentos:** Processamento e registro de pagamentos realizados pelos clientes.
- **Menu Principal:** Interface gráfica para navegação entre as diferentes funcionalidades do sistema.

## Estrutura do Projeto

- **Sistema Financeiro.sln:** Arquivo de solução para abrir o projeto no Visual Studio.
- **App.config:** Arquivo de configuração da aplicação.
- **Program.cs:** Ponto de entrada da aplicação.
- **DatabaseHelper.cs:** Classe para interagir com o banco de dados.
- **SQLQuery1.sql:** Exemplo de consulta SQL utilizada no projeto.
- **DataBase.mdf e DataBase_log.ldf:** Arquivos do banco de dados local.
- **Classes (Cliente.cs, Funcionario.cs, Pagamento.cs, Servicos.cs, etc.):** Definem as entidades e funcionalidades do sistema.

## Configuração e Execução

1. **Clone o Repositório:**
   ```bash
   git clone https://github.com/markesjp/SistemaFinanceiro.git
   ```
2. **Abra a Solução no Visual Studio:**
   - Navegue até o diretório do projeto e abra o arquivo `Sistema Financeiro.sln` no Visual Studio.

3. **Restaurar Pacotes NuGet:**
   - No Visual Studio, restaure os pacotes NuGet necessários.

4. **Executar a Aplicação:**
   - Compile e execute a aplicação diretamente pelo Visual Studio.

## Banco de Dados

O sistema utiliza um banco de dados local (arquivos `.mdf` e `.ldf`) para armazenar informações. Certifique-se de que o SQL Server LocalDB está instalado e configurado em sua máquina.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
