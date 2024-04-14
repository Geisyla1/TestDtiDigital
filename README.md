# Teste_Pratico
Teste Pratico para vaga na empresa DTI digital

Foi desenvolvido nesse projeto uma resolução prática para um canil em Belo Horizonte que com os dados informados pelo usuário 
  retornaria o nome do Petshop mais em conta na região.
# Problema

Senhor Eduardo é proprietário de um canil em Belo Horizonte, ele trabalha com diversas raças, pequenas e grandes. Eduardo gosta que seus cães estejam sempre arrumados, felizes e cheirosos.

No bairro do canil, para realizar o banho nos animais, existem três petshops: Meu Canino Feliz, Vai Rex e ChowChawgas. Cada um deles cobra preços diferentes para banho em cães pequenos e grandes e o preço pode variar de acordo com o dia da semana.

- **Meu Canino Feliz**: Está distante 2km do canil. Em dias de semana, o banho para cães pequenos custa R$ 20,00 e o banho em cães grandes custa R$ 40,00. Durante os finais de semana, o preço dos banhos é aumentado em 20%.

- **Vai Rex**: Está localizado na mesma avenida do canil, a 1,7km. O preço do banho para dias úteis em cães pequenos é R$ 15,00 e em cães grandes é R$ 50,00. Durante os finais de semana, o preço para cães pequenos é R$ 20,00 e para os grandes é R$ 55,00.

- **ChowChawgas**: Fica a 800m do canil. O preço do banho é o mesmo em todos os dias da semana. Para cães pequenos custa R$ 30,00 e para cães grandes, R$ 45,00.

Apesar de se importar muito com seus cãezinhos, Eduardo quer gastar o mínimo possível. Desenvolva uma solução para encontrar o melhor petshop para levar os cães. O melhor petshop será o que oferecer menores preços. Em caso de empate, o melhor é o mais próximo do canil.

**Entrada:**

<data> <quantidade de cães pequenos> <quantidade de cães grandes>

Exemplo: 03/08/2018 3 5

**Saída:**

Nome do melhor petshop e preço total dos banhos.

---

## Como Rodar

1. Certifique-se de ter o [.NET Core SDK](https://dotnet.microsoft.com/download) instalado em seu sistema.
2. Clone este repositório em sua máquina local.
3. Abra um terminal na pasta raiz do projeto.
4. Execute o comando `dotnet run` para compilar e executar o programa.
5. Siga as instruções fornecidas pelo programa para inserir a quantidade de cães e a data desejada.

## Detalhes da Implementação

- O programa consiste em três classes principais: `Orcamento`, `DiaSemana` e `Program`.
- A classe `Orcamento` é responsável por calcular o orçamento para os diferentes petshops.
- A classe `DiaSemana` é responsável por obter o dia da semana a partir de uma data inserida pelo usuário.
- O programa principal está na classe `Program`, onde o usuário interage com o sistema inserindo a quantidade de cães e a data desejada.

# Código 
## Funcionamento

1. **Obtenção do Dia da Semana:**
   - O programa solicita ao usuário que digite uma data no formato `dd/mm/yyyy`.
   - Em seguida, ele verifica se a data é válida e retorna o dia da semana correspondente.

2. **Entrada de Dados:**
   - O usuário informa a quantidade de cães de raças pequenas e grandes.

3. **Cálculo dos Orçamentos:**
   - Com base no dia da semana e nas quantidades informadas, o programa calcula três possíveis orçamentos em diferentes petshops:
     - Meu Canino Feliz
     - Vai Rex
     - ChowChawgas

4. **Comparação e Resultado:**
   - O programa compara os valores dos orçamentos e exibe qual petshop oferece o serviço mais barato.

## Classes Principais

- `Program`: Classe principal que controla a execução do programa, obtém o dia da semana, coleta as informações do usuário e chama o método de comparação de orçamentos.
  
- `DiaSemana`: Classe responsável por obter o dia da semana a partir de uma data informada pelo usuário.

- `Orcamento`: Classe que realiza os cálculos dos orçamentos para cada petshop e compara os valores para determinar o mais barato.
 
## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou enviar um pull request.

---
