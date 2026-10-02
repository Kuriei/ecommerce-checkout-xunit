# Ecommerce Checkout xUnit

Projeto desenvolvido para a disciplina de Gestão e Qualidade de Software.

##Aluno
- Cauã Parreiras Vieira
- RA: 32516918

## Tecnologias

- C#
- .NET 10
- xUnit

## Métodos implementados

### GerarCodigoRastreio

Recebe a região e o número do pedido.

Exemplo:

`sudeste` + `42`

Resultado:

`SUDESTE-0042`

### CalcularPontosFidelidade

A cada R$ 10 em compras, o cliente recebe 2 pontos.

Exemplo:

R$ 150 = 30 pontos.

### TemDireitoAFreteGratis

O frete é gratuito quando:

- O valor da compra é maior ou igual a R$ 200; ou
- O cliente é VIP.

## Testes

Foram criados testes unitários utilizando xUnit para verificar:

- Código de rastreio;
- Pontos de fidelidade;
- Frete grátis para cliente VIP;
- Frete pago para cliente não-VIP abaixo de R$ 200.

## Executar os testes

Utilize:

```bash
dotnet test
