using FluentAssertions;
using KiddyCode.Compiler;

namespace KiddyCode.Compiler.Tests;

public class ProgramTests
{
    [Fact]
    public void Main_WhenNoArguments_ShouldReturnExitCode1()
    {
        // Act
        var result = Program.Main(Array.Empty<string>());

        // Assert
        result.Should().Be(1);
    }

    [Fact]
    public void Main_WhenGivenSourceFile_ShouldReturnExitCode0()
    {
        // Arrange
        var args = new[] { "test.kiddy" };

        // Act
        var result = Program.Main(args);

        // Assert
        result.Should().Be(0);
    }
}
