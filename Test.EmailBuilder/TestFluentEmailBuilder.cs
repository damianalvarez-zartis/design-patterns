using System;
using Xunit;
using EmailBuilder;

namespace Test.EmailBuilder;

public class TestFluentEmailBuilder
{
    [Fact]
    public void Build_ReturnsEmailObject()
    {
        var newEmail = FluentEmailBuilder
                .CreateEmail()
                .From("myaddress@email.com")
                .To("fluent_email@gmail.com")
                .Subject("Title of email")
                .Body("blah blah blah")
                .Cc("someone_in_copy@email.com")
                .Bcc("someone_in_backcopy@email.com")
                .Build();

        Assert.IsType<Email>(newEmail);
    }

    [Fact]
    public void Build_ThrowsError()
    {
        var newEmail = FluentEmailBuilder
                .CreateEmail()
                .From("myaddress@email.com")
                .To("fluent_email@gmail.com")
                .Subject("Title of email")
                .Body("blah blah blah")
                .Cc(string.Empty)
                .Bcc(string.Empty)
                .Build();

        Assert.IsType<Email>(newEmail);
    }
}
