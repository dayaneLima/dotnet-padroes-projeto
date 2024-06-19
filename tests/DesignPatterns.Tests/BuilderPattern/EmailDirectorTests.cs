using DesignPatterns.BuilderPattern;

namespace DesignPatterns.Tests.BuilderPattern;

public class EmailDirectorTests
{
    [Fact]
    public void ConstructSimpleEmail_ReturnValidEmail()
    {
        // Arrange
        var emailBuilder = new EmailBuilder();
        var emailDirector = new EmailDirector(emailBuilder);

        // Act 
        var emailComplete = emailDirector.ConstructSimpleEmail("to", "from", "body", "subject");

        // Assert
        Assert.Equal("to", emailComplete.To);
        Assert.Equal("", emailComplete.ReplyTo);
        Assert.Equal("from", emailComplete.From);
        Assert.Equal("body", emailComplete.Body);
        Assert.Equal("subject", emailComplete.Subject);
    }

    [Fact]
    public void ConstructCompleteEmail_ReturnValidEmail()
    {
        // Arrange
        var emailBuilder = new EmailBuilder();
        var emailDirector = new EmailDirector(emailBuilder);

        // Act 
        var emailComplete = emailDirector.ConstructCompleteEmail("to", "replyTo", "from", "body", "subject");

        // Assert
        Assert.Equal("to", emailComplete.To);
        Assert.Equal("replyTo", emailComplete.ReplyTo);
        Assert.Equal("from", emailComplete.From);
        Assert.Equal("body", emailComplete.Body);
        Assert.Equal("subject", emailComplete.Subject);
    }
}