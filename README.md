# Ecommerce Checkout xUnit

Projeto desenvolvido para a atividade de testes unitários com xUnit e .NET 10.

## Métodos implementados

### GerarCodigoRastreio

Gera um código de rastreio utilizando a região e o número do pedido.

**Exemplo:**

```text
SUDESTE-0042
```

### CalcularPontosFidelidade

Calcula os pontos de fidelidade com base no valor da compra.

**Exemplo:**

```text
R$ 150 = 30 pontos
```

### TemDireitoAFreteGratis

Verifica se o cliente possui direito ao frete grátis.

O frete é gratuito quando o valor da compra é maior ou igual a R$ 200 ou quando o cliente é VIP.

## Testes

Foram implementados 4 testes unitários utilizando xUnit:

- Geração do código de rastreio;
- Cálculo dos pontos de fidelidade;
- Frete grátis para cliente VIP;
- Frete grátis para cliente não VIP.

Foram utilizados `Assert.Equal`, `Assert.True` e `Assert.False`.

## Como executar os testes

Na pasta principal do projeto, execute:

```bash
dotnet test
```

**Resultado esperado:**

```text
Total: 4
Falhou: 0
Bem-sucedido: 4
```

Todos os 4 testes devem ser aprovados.

---

## Autora

- Alice Fernandes Barbosa - @alicefbarbosa - 326128348

**Atividade da disciplina de Gestão e Qualidade de Software.**
