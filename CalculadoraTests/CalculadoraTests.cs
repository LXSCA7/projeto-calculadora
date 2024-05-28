namespace CalculadoraTests;
using CalculadoraApi.Controllers;
public class CalculadoraTests
{
    private CalculadoraController _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraController();
    }


    [Fact]
    public void SomaDeDoisNumeros_DeveSomarNum1ENum2_RetornarSucesso()
    {
        // arrange
        int num1 = 5;
        int num2 = 10;
        int resultadoEsperado = num1 + num2;

        // act
        int resultadoEncontrado = _calc.Somar(num1, num2);
        
        // assert
        Assert.Equal(resultadoEsperado, resultadoEncontrado);
    }

    [Fact]
    public void SubtracaoDeDoisNumeros_DeveSubtrairNum1ENum2_RetornarSucesso()
    {
        // arrange
        int num1 = 20;
        int num2 = 10;
        int resultadoEsperado = num1 - num2;

        // act
        int resultadoEncontrado = _calc.Subtrair(num1, num2);
        
        // assert
        Assert.Equal(resultadoEsperado, resultadoEncontrado);
    }

    [Fact]
    public void MultiplicacaoDeDoisNumeros_DeveMultiplicarNum1eNum2_RetornarSucesso()
    {
        // arrange
        int num1 = 2;
        int num2 = 10;
        int resultadoEsperado = num1 * num2;
        
        // act
        int resultadoEncontrado = _calc.Multiplicar(num1, num2);

        // assert
        Assert.Equal(resultadoEsperado, resultadoEncontrado);
    }

    [Fact]
    public void DivisaoDeDoisNumeros_DeveDivirNum1PorNum2_RetornarSucesso()
    {
        int num1 = 25;
        int num2 = 5;
        int resultadoEsperado = 5;

        int resultadoEncontrado = _calc.Dividir(num1, num2);

        Assert.Equal(resultadoEsperado, resultadoEncontrado);
    }

    [Fact]
    public void VerificarSeEhPar_DeveVerificarONum_RetornarFalso()
    {
        int num = 5;
        bool resultadoEncontrado = _calc.EhPar(num);

        Assert.False(resultadoEncontrado);
    }

    [Fact]
    public void VerificarSeEhPar_DeveVerificarONum_RetornarSucesso()
    {
        int num = 4;
        bool resultadoEncontrado = _calc.EhPar(num);

        Assert.True(resultadoEncontrado);
    }

    [Fact]
    public void RaizDeUmNumero_RealizarARaizQuadrada_RetornarSucesso()
    {
        double num = 9;
        double resultadoEsperado = 3;
        double resultadoEncontrado = _calc.Raiz(num);

        Assert.Equal(resultadoEsperado, resultadoEncontrado);
    }

    [Fact]
    public void PotenciaDeNum_RealizarAPotenciaDeNum1PorNum2_RetornarSucesso()
    {
        double num1 = 5;
        double num2 = 2;
        double resultadoEsperado = 25;

        double resultadoEncontrado = _calc.Potencia(num1, num2);

        Assert.Equal(resultadoEsperado, resultadoEncontrado);
    }
}