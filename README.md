# FIAP Pets

## Descrição

FIAP Pets é uma plataforma para gerenciamento de pets, em que irão conter informações básicas do animal e seu respectivo dono.

## Tecnologias Usadas

- C#
- ASP.NET Core
- Bootstrap

## Como rodar o projeto

*É recomendando a utilização da IDE Rider*
1. Instalar o Rider (caso não possua)
2. Abra o terminal de seu computador
3. Mova para a pasta em que deseja colocar o repositório clonado
   ```
   // Exemplo
   >> cd Desktop
   ```
4. Clone o repositório
   ```
   >> git clone https://github.com/laviniapark/CP2-ABD-FIAP-PETS.git
   ```
5. Abra o Rider (ou a IDE desejada) e selecione a pasta em que está o repositório
6. Para rodar o projeto, basta clicar no botão de play (⏯️)
Assim, o próprio programa irá abrir uma aba mostrando a página web do projeto.

## Funcionalidades

### Cadastro de Pets

- Descrição: O usuário pode cadastrar um novo pet.
- Requisitos:
  - Nome
  - Tipo (cachorro, gato...)
  - Raça
  - Data de Nascimento
  - Sexo
  - Peso
  - Se é vacinado
  - Nome do dono
  - Contato do dono

### Editar Pets

- Descrição: Possibilita editar as informações de um pet ja cadastrado no clique de um botão.
- Fluxo:
  - Após clicar no botão, ele irá abrir a mesma aba de cadastro porém com as informações anteriores
  - Altere as informações desejadas, e depois clique no botão "Editar"
  - Assim que aparecer a mensagem de confirmação, basta clicar no botão "Listar Pets"

### Remover Pets

- Descrição: No mesmo local do botão Editar, também temos o de remover para apagar algum pet.
- Fluxo:
  - Após clicar no botão, irá aparecer um pop-up de confirmação
  - Basta clicar em Sim caso deseje apagar
  - Uma mensagem de confirmação da ação de remover irá aparecer

### Exibição da Política de Privacidade

- Descrição: Como um bom site web deve ser, o usuário pode ler a política de privacidade do site
- Fluxo:
  - O usuário pode clicar na opção Política na barra de cima, que ele será redirecionado para uma tela com o texto
  - O usuário pode também clicar no link Policy que está localizado no fim da página, e ele será redirecionado para o mesmo lugar
