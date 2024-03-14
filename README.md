# Teste BRGAAP
teste realizado para BRGAAP
#
Este teste contém API Web criada usando C# com .net utilizando princípios de arquitetura limpa

Código dividido em 5 camadas sendo elas:

- Domain: responsável pelas entidades e regras de negócio e interfaces
- Infra.Data: responsavel pela conexao com banco, contextos e repositorios
- Application: responsável pelos serviços e mapeamentos
- Infra.Ioc: configuração das injeções de dependências
- API: responsável execução da solução e pela comunicação externa e controllers

# Instruções

- Necessário ter uma base dados chamada "brgaap" no banco
- Rodar comando "update-database" na "Infra.Data" para executar a migration e criar as tabelas (necessário apenas uma vez)
- Projeto .API deve ser utilizado na inicialização 
