# TestDtiDigital

# Projeto de Orçamento para Petshops

Este é um projeto simples em C# que calcula o orçamento de diferentes petshops com base na quantidade de cães de raça pequena e grande, bem como no dia da semana.

## Funcionalidades

- Calcula o orçamento para três petshops diferentes: Meu Canino Feliz, Vai Rex e ChowChawgas.
- O preço do serviço varia dependendo do dia da semana e do tamanho dos cães.
- Apresenta o petshop com o melhor custo-benefício.

## Como Rodar

1. Certifique-se de ter o [.NET Core SDK](https://dotnet.microsoft.com/download) instalado em seu sistema.
2. Clone este repositório em sua máquina local.
3. Abra um terminal na pasta raiz do projeto.
4. Execute o comando `dotnet run` para compilar e executar o programa.
5. Siga as instruções fornecidas pelo programa para inserir a quantidade de cães e a data desejada.

## Testes Unitários

Os testes unitários foram implementados usando a biblioteca [xUnit.net](https://xunit.net/).

1. Os testes podem ser encontrados na pasta de testes dentro do projeto.
2. Para executar os testes, abra um terminal na pasta raiz do projeto e execute o comando `dotnet test`.

## Detalhes da Implementação

- O programa consiste em três classes principais: `Orcamento`, `DiaSemana` e `Program`.
- A classe `Orcamento` é responsável por calcular o orçamento para os diferentes petshops.
- A classe `DiaSemana` é responsável por obter o dia da semana a partir de uma data inserida pelo usuário.
- O programa principal está na classe `Program`, onde o usuário interage com o sistema inserindo a quantidade de cães e a data desejada.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Licença

Este projeto está licenciado sob a Licença MIT. Consulte o arquivo [LICENSE](LICENSE) para obter mais detalhes.
