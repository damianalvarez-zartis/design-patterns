// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using EmailBuilder;

var loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

var email = new Email("target@mail.com", "sender@mail.com", "Hello there!", loremIpsum);

Console.WriteLine(JsonConvert.SerializeObject(email));

var newEmail = FluentEmailBuilder
                .CreateEmail()
                .From("myaddress@email.com")
                .To("fluent_email@gmail.com")
                .Subject("Title of email")
                .Body(loremIpsum)
                .Cc("someone_in_copy@email.com")
                .Bcc("someone_in_backcopy@email.com")
                .Build();

Console.WriteLine(JsonConvert.SerializeObject(newEmail));
