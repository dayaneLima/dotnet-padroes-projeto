namespace DesignPatterns.BuilderPattern;

public interface IEmailBuilder
{
    IEmailBuilder BuildTo(string to);
    IEmailBuilder BuildReplyTo(string replyTo);
    IEmailBuilder BuildFrom(string from);
    IEmailBuilder BuildSubject(string subject);
    IEmailBuilder BuildBody(string body);

    IEmailBuilder Reset();
    Email Build();
}
