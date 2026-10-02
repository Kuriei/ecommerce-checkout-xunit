using EcommerceCheckout.App;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    [Fact]
    public void GerarCodigoRastreio_DeveRetornarCodigoFormatado()
    {
        var service = new PedidoService();

        var resultado = service.GerarCodigoRastreio("sudeste", 42);

        Assert.Equal("SUDESTE-0042", resultado);
    }

    [Fact]
    public void CalcularPontosFidelidade_DeveRetornar30Para150Reais()
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
    public void TemDireitoAFreteGratis_DeveRetornarFalseParaNaoVIPAbaixoDe200()
    {
        var service = new PedidoService();

        var resultado = service.TemDireitoAFreteGratis(150, false);

        Assert.False(resultado);
    }
}
