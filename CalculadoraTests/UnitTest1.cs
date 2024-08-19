using Calculadora.Class;

namespace CalculadoraTests;

public class UnitTest1
{
    private readonly CalculadoraImp _calculadora;

    public UnitTest1()
    {
        _calculadora = new CalculadoraImp();
    }
    [Theory]
    [InlineData(4, 8, 12)]
    [InlineData(8, 4, 12)]
    [InlineData(8, 8, 16)]
    [InlineData(4, 4, 8)]
    [InlineData(8, 0, 8)]
    [InlineData(0, 8, 8)]
    [InlineData(0, 0, 0)]
    public void TestarSomas(int value_1, int value_2, int expected)
    {
        int result = _calculadora.Somar(value_1, value_2);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(8, 4, 4)]
    [InlineData(8, 8, 0)]
    [InlineData(9, 1, 8)]
    [InlineData(4, 10, -6)]
    [InlineData(2, 3, -1)]
    [InlineData(6, 5, 1)]
    [InlineData(0, 0, 0)]
    public void TestarSubtracoes(int value_1, int value_2, int expected)
    {
        int result = _calculadora.Subtrair(value_1, value_2);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(8, 4, 32)]
    [InlineData(8, 8, 64)]
    [InlineData(9, 1, 9)]
    [InlineData(4, 10, 40)]
    [InlineData(2, 3, 6)]
    [InlineData(6, 5, 30)]
    [InlineData(0, 0, 0)]
    public void TestarMultiplicacoes(int value_1, int value_2, int expected)
    {
        int result = _calculadora.Multiplicar(value_1, value_2);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(8, 4, 2)]
    [InlineData(8, 8, 1)]
    [InlineData(9, 1, 9)]
    [InlineData(90, 10, 9)]
    [InlineData(120, 6, 20)]
    [InlineData(18, 9, 2)]
    public void TestarDivisoes(int value_1, int value_2, int expected)  
    {
        int result = _calculadora.dividir(value_1, value_2);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestarHistorico()
    {
        _calculadora.Somar(9, 8);
        _calculadora.Somar(2, 8);
        _calculadora.Somar(5, 7);
        _calculadora.Somar(3, 4);
        Assert.NotEmpty(_calculadora.Historico());
        Assert.Equal(3, _calculadora.Historico().Count);
    }
}