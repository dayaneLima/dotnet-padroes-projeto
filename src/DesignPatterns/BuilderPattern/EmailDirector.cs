namespace DesignPatterns.BuilderPattern;

public class EmailDirector
{
    private readonly IEmailBuilder _emailBuilder;

    public EmailDirector(IEmailBuilder emailBuilder) => _emailBuilder = emailBuilder;

    public Email ConstructSimpleEmail(string to, string from, string body, string subject)
    {
        return _emailBuilder.Reset()
                            .BuildTo(to)
                            .BuildFrom(from)
                            .BuildBody(body)
                            .BuildSubject(subject)
                            .Build();
    } 

    public Email ConstructCompleteEmail(string to, string replyTo, string from, string body, string subject)
    {
        return _emailBuilder.Reset()
                            .BuildTo(to)
                            .BuildReplyTo(replyTo)
                            .BuildFrom(from)
                            .BuildBody(body)
                            .BuildSubject(subject)
                            .Build();
    }
}