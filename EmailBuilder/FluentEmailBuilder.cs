namespace EmailBuilder;
public class FluentEmailBuilder :
    IFromSelectionStage,
    IToSelectionStage,
    ISubjectSelectionStage,
    IBodySelectionStage,
    ICcSelectionStage,
    IBccSelectionStage,
    IBuildEmailStage
{
    private string _from = string.Empty;
    private string _to = string.Empty;
    private string _subject = string.Empty;
    private string _body = string.Empty;
    private string _cc = string.Empty;
    private string _bcc = string.Empty;
    private bool _isHtmlBody = false;

    private FluentEmailBuilder() {}

    public static IFromSelectionStage CreateEmail()
    {
        return new FluentEmailBuilder();
    }

    IToSelectionStage IFromSelectionStage.From(string from)
    {
        _from = from;
        return this;
    }

    ISubjectSelectionStage IToSelectionStage.To(string to)
    {
        _to = to;
        return this;
    }
    
    IBodySelectionStage ISubjectSelectionStage.Subject(string subject)
    {
        _subject = subject;
        return this;
    }

    ICcSelectionStage IBodySelectionStage.Body(string body)
    {
        _body = body;
        return this;    }

    IBccSelectionStage ICcSelectionStage.Cc(string cc)
    {
        _cc = cc;
        return this;
    }

    IBuildEmailStage IBccSelectionStage.Bcc(string bcc)
    {
        _bcc = bcc;
        return this;
    }

    Email IBuildEmailStage.Build()
    {
        var email = new Email(_from, _to, _subject, _body, _isHtmlBody, _cc, _bcc);
        return email;
    }
}
