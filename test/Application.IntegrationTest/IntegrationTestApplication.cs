using System;
using Xunit;
using Application;

namespace Application.IntegrationTest
{
    public class IntegrationTestApplication
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
    }
}
