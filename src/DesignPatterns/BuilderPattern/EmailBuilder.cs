namespace DesignPatterns.BuilderPattern;

public class EmailBuilder: IEmailBuilder
{
    private Email _email;

    public EmailBuilder() => _email = new Email();

    
    public IEmailBuilder BuildTo(string to)
    {
        this._email.To = to;
        return this;
    }
    
    public IEmailBuilder BuildReplyTo(string replyTo)
    {
        this._email.ReplyTo = replyTo;
        return this;
    }
    
    public IEmailBuilder BuildFrom(string from)
    {
        this._email.From = from;
        return this;
    }
    
    public IEmailBuilder BuildSubject(string subject)
    {
        this._email.Subject = subject;
        return this;
    }
    
    public IEmailBuilder BuildBody(string body)
    {
        this._email.Body = body;
        return this;
    }

    public IEmailBuilder Reset()
    {
        _email = new Email();
        return this;
    }
    
    public Email Build() => _email;
}
