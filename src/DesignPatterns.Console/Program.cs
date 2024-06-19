using DesignPatterns.BuilderPattern;

var emailBuilder = new EmailBuilder();
var emailDirector = new EmailDirector(emailBuilder);

var emailComplete = emailDirector.ConstructCompleteEmail("to", "replyTo", "from", "body", "subject");
System.Console.WriteLine($"To: {emailComplete.To} | ReplyTo: {emailComplete.ReplyTo} | From: {emailComplete.From} | Body: {emailComplete.Body} | Subject: {emailComplete.Subject}");


var emailSimple = emailDirector.ConstructSimpleEmail("to", "from", "body", "subject");
System.Console.WriteLine($"To: {emailSimple.To} | ReplyTo: {emailSimple.ReplyTo} | From: {emailSimple.From} | Body: {emailSimple.Body} | Subject: {emailSimple.Subject}");
