using System.Reflection;

namespace MyTestProject;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Input_1_2_Should_Be_3()
    {
        var num1 = 1;
        var num2 = 2;
        var expected = 3;
        Assert.AreEqual(expected, num1 + num2);
    }

    [TestMethod]
    public void Input_StringEmpty_Should_Be_OK()
    {
        // Arrange
        var input = string.Empty;
        var kata = new Kata();
        // Act
        var removedResult = kata.Remove_char(input);
        // Assert
        Assert.AreEqual("ok", removedResult);
    }

    [TestMethod]
    public void Input_a_Should_Be_OK()
    {
        // Arrange
        var input = "a";
        var kata = new Kata();
        // Act
        var removedResult = kata.Remove_char(input);
        // Assert
        Assert.AreEqual("ok", removedResult);
    }

    [TestMethod]
    public void Input_ab_Should_Be_StringEmpty()
    {
        // Arrange
        var input = "ab";
        var kata = new Kata();
        // Act
        var removedResult = kata.Remove_char(input);
        // Assert
        Assert.AreEqual(string.Empty, removedResult);
    }

    [TestMethod]
    public void Input_BOWEN_Should_Be_OWE()
    {
        // Arrange
        var input = "BOWEN";
        var kata = new Kata();
        // Act
        var removedResult = kata.Remove_char(input);
        // Assert
        Assert.AreEqual("OWE", removedResult);
    }
}

public class Kata
{
    public string Remove_char(string s)
    {
        return s.Length > 1 ? s.Substring(1, s.Length - 2) : "ok";
    }
}
