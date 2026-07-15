# 🧮 Calculadora Desktop (VB.NET)

Uma calculadora de interface gráfica clássica desenvolvida em **Visual Basic .NET** para a matéria de Desenvolvimento de Sistemas do meu curso técnico. O projeto implementa as quatro operações matemáticas básicas utilizando um fluxo lógico baseado em variáveis de controle para estruturar os números inseridos antes de calcular o resultado final.

## 🛠️ Tecnologias e Recursos Utilizados

* **Linguagem de Programação:** VB.NET (Visual Basic .NET)
* **IDE Recomendada:** Visual Studio

## 💡 Conceitos de Programação Aplicados

Este projeto foi excelente para consolidar conceitos essenciais:

### 1. Programação Orientada a Eventos (Event-Driven)
* Uso do mecanismo de manipulação de ações (`Handles`) para interceptar cliques nos botões numéricos e nos operadores aritméticos, disparando alterações imediatas na interface de usuário.

### 2. Controle de Estado (State Management)
* **Variáveis Globais de Classe:** Para persistir os números digitados.
* **Flags Booleanas:** Controle lógico do fluxo através da para determinar qual número está sendo preenchido no momento, além de flags dedicadas (`Soma`, `Subtracao`, `Multiplicacao`, `Divisao`) para guardar a operação escolhida.

### 3. Conversão de Tipos e Operações Aritméticas
* **Tratamento Dinâmico de Strings:** O texto dos botões clicados é concatenado dinamicamente para formar os números maiores.
* **Função `Val()`:** Utilização da função de conversão nativa para transformar com segurança as strings numéricas em valores calculáveis no momento do cálculo do resultado.

### 4. Limpeza de Memória e Reset
* Reinicialização sistemática de todas as variáveis lógicas após clicar no botão de igual ou limpar a tela prevenindo bugs de operações anteriores acumuladas.

## 🚀 Como Executar o Projeto

### Pré-requisitos
* Ter o **Visual Studio** instalado (com suporte ao desenvolvimento desktop .NET/Windows Forms).

### Passo a Passo

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/isapinheir/calculadora-vbnet
   
2. **Abra o projeto:**
   * Navegue até a pasta do projeto clonado.
   * Dê um duplo clique no arquivo de solução (.sln) ou no arquivo de projeto (.vbproj) para abri-lo diretamente no Visual Studio.

3. **Execute a aplicação:**
     * Com o projeto aberto no Visual Studio, pressione a tecla F5 ou clique no botão Iniciar (Start) na barra de ferramentas superior.
     * A interface da calculadora será compilada e aberta pronta para uso!
