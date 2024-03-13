using System.Reflection;

namespace MyTestProject;

[TestClass]
public class UnitTest2
{
    [TestMethod]
    public void Input_StringEmpty_Should_Be_StringEmpty()
    {
        // Arrange
        var input = string.Empty;
        var kata = new Kata();
        // Act
        var fakeResult = kata.FakeBin(input);
        // Assert
        Assert.AreEqual(string.Empty, fakeResult);
    }


    [TestMethod]
    public void Input_0_Should_Be_0()
    {
        // Arrange
        var input = "0";
        var kata = new Kata();
        // Act
        var fakeResult = kata.FakeBin(input);
        // Assert
        Assert.AreEqual("0", fakeResult);
    }

    [TestMethod]
    public void Input_5_Should_Be_1()
    {
        // Arrange
        var input = "5";
        var kata = new Kata();
        // Act
        var fakeResult = kata.FakeBin(input);
        // Assert
        Assert.AreEqual("1", fakeResult);
    }

    [TestMethod]
    public void Input_01_Should_Be_00()
    {
        // Arrange
        var input = "01";
        var kata = new Kata();
        // Act
        var fakeResult = kata.FakeBin(input);
        // Assert
        Assert.AreEqual("00", fakeResult);
    }

    [TestMethod]
    public void Input_1234567890_Should_Be_0000111110()
    {
        // Arrange
        var input = "1234567890";
        var kata = new Kata();
        // Act
        var fakeResult = kata.FakeBin(input);
        // Assert
        Assert.AreEqual("0000111110", fakeResult);
    }

    [TestMethod]
    public void Input_0615_Should_Be_0101()
    {
        // Arrange
        var input = "0615";
        var kata = new Kata();
        // Act
        var fakeResult = kata.FakeBin(input);
        // Assert
        Assert.AreEqual("0101", fakeResult);
    }
}

