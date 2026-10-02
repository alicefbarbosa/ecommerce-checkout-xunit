using EcommerceCheckout.App;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    [Fact]
    public void GerarCodigoRastreio_DeveGerarCodigoCorreto()
    {
        var service = new PedidoService();

        var resultado = service.GerarCodigoRastreio("sudeste", 42);

        Assert.Equal("SUDESTE-0042", resultado);
    }

    [Fact]
    public void CalcularPontosFidelidade_DeveCalcularCorretamente()
    {
        var service = new PedidoService();

        var resultado = service.CalcularPontosFidelidade(150);

        Assert.Equal(30, resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_DeveRetornarTrueParaClienteVIP()
    {
        var service = new PedidoService();

        var resultado = service.TemDireitoAFreteGratis(150, true);

        Assert.True(resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_DeveRetornarFalseParaNaoVIP()
    {
        var service = new PedidoService();

        var resultado = service.TemDireitoAFreteGratis(150, false);

        Assert.False(resultado);
    }
}