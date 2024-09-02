# Desafio Sistema de Gerenciamento de Tarefas

**Primeiro passo:** baixa o projeto na máquina e executa a linha de comando abaixo:<br>
**git clone https://github.com/alexsoliveira/DesafioB3.git**

**Segundo Passo:** quando finalizar de baixar o projeto, executa a linha de comando abaixo:<br>
**cd .\DesafioB3**

**Terceiro passo:** dentro da pasta do projeto **"/DesafioB3"** <br>
executar o comando abaixo:<br>
**docker compose up -d --build**

**Quarto passo:** executa a url abaixo, no browser:<br>
**[http://localhost:5000/swagger/index.html](http://localhost:4200/calculo)** <br>
**Obs.: A primeira vez pode demorar um pouco para subir a aplicação**

**Quinto passo:** para testar a api execura a url abaixo, no browse:<br>
**[http://localhost:5000/swagger/index.html](http://localhost:5000/swagger/index.html)** clica na api **/api/v1/cdb** e executa  json abaixo:<br>
``{{
  "valorMonetario": 100,
  "mes": 2
}``

**Sexto passo:** rodar os testes de unidade, integração e end to end, executa o comando abaixo:<br>
**cd .\back-end\tests\Desafio.B3.UnitTests** <br>
**dotnet test** <br>

**Sétimo passo:** rodar os testes de unidade do angular, executa o comando abaixo:<br>
**cd ..\..\..\front-end\desafio.b3.client** <br>
**ng test --code-coverage** <br>
**Obs.: o comando acima só funciona no promtp bash**





