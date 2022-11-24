// Classic email class with classic constructor
namespace EmailBuilder;
public class Email
{
    public string From { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public bool IsHtmlBody { get; set; }
    public string? Cc { get; set; }
    public string? Bcc { get; set; }

    public Email(string from, string to, string subject, string body, bool isHtmlBody = false, string? cc = null, string? bcc = null)
    {
        From = from;
        To = to;
        Subject = subject;
        Body = body;
        IsHtmlBody = isHtmlBody;
        Cc = cc;
        Bcc = bcc;
    }
}