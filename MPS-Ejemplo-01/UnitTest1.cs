namespace Testing;

public class Tests
{

    private Calculator calc;

    [SetUp]
    // método de configuración
    // para hacer las instanciaciones que voy a usar en el resto del código
    public void Setup()
    {
        calc = new Calculator();
    }

    [TestCase(2, 4, 6)]
    [TestCase(4, 8, 12)]
    [TestCase(8, 16, 24)]
    public void TwoNumbersAdd_WithTestCases(int num1, int num2, int expectedResult)
    {
        int result = calc.Add(num1, num2);
        Assert.That(result, Is.EqualTo(expectedResult), $"El resultado de la suma no fue el esperado, {result} no es igual a {expectedResult}");
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }


    // [Test]
    // public void Test2()
    // {
    //     Assert.Fail("Test no pasó la prueba");
    // }

    [Test]
    public void TwoNumbersCorrectSubstract()
    {
        int resultado = calc.Substract(8, 4);
        Assert.That(resultado, Is.EqualTo(4), "Resta no dio el resultado esperado");
    }

    [Test]
    public void TwoNumbersCorrectMultiply()
    {
        int resultado = calc.Multiply(2, 4);
        Assert.That(resultado, Is.EqualTo(8), "Multiplicación no dio el resultado esperado");
    }

    [Test]
    public void NumbesIsEven()
    {
        bool resultado = calc.IsEven(2);
        Assert.That(resultado, Is.EqualTo(true), "El número no es par");
    }

    [Test]
    public void DivisionThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => calc.Divide(16, 0)); //Callback

    }

    [Test]
    public void TwoNumbersCorrectDivide()
    {
        int resultado = calc.Divide(10, 2);
        Assert.That(resultado, Is.EqualTo(5), "División no dio el resultado esperado");
    }
}