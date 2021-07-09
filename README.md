# Criando o Projeto

## Criando a solução:
Crie uma nova pasta, e dentro execute os comandos abaixo para criar o projeto:

### Iniciando projeto
dotnet new sln -n teste-unitario-com-nunit

### Criando a biblioteca de classes:
dotnet new classlib -n calculos

### Adicionando o projeto na solução:
dotnet sln teste-unitario-com-nunit.sln add calculos/calculos.csproj

### Criando template do NUnit:
dotnet new nunit -n calculos.tests

### Adicionando o projeto na solução:
dotnet sln teste-unitario-com-nunit.sln add calculos.tests/calculos.tests.csproj

### Adicionando ao projeto a referência da biblioteca de classes, o projeto calculos:
dotnet add calculos.tests/calculos.tests.csproj reference calculos/calculos.csproj

## Execução
dotnet test

* Referência: https://www.treinaweb.com.br/blog/teste-unitarios-no-c-com-o-nunit/