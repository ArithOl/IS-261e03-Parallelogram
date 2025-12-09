using System;
using Xunit;
using Application;

namespace Application.UnitTest;

public class UnitTestApplication
{
    [Theory]
    [InlineData(4, 4, 16)]
    [InlineData(5, 3, 16)]
    public void TestPerimetro(double ladoA, double ladoB, double perimetroEsperado)
    {
        // Arrange - Set up
        
        // Act - Perform
        double resultado = Paralelogramo.Perimetro(ladoA, ladoB);
        
        // Assert - Verify
        Assert.Equal(perimetroEsperado, resultado);
    }
    
    [Theory]
    [InlineData(4, 4, 16)]
    [InlineData(5, 5, 25)]
    public void TestArea(double baseParalelogramo, double altura, double areaEsperada)
    {
        // Arrange - Set up
        
        // Act - Perform 
        double resultado = Paralelogramo.Area(baseParalelogramo, altura);
        
        // Assert - Verify
        Assert.Equal(areaEsperada, resultado);
    }
}
