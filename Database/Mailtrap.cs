using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Server.HttpSys;

public class Mailtrap
{
    public Mailtrap()
    {
        var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
        {
            Credentials = new NetworkCredential("a16a85dfe711d7", "986c287b929a28"),
            EnableSsl = true
        };
    }

    public void sendMail(string sender, string reciever, string subject, string body)
    {
        var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
        {
            Credentials = new NetworkCredential("a16a85dfe711d7", "986c287b929a28"),
            EnableSsl = true
        };

        client.Send(sender, reciever, subject, body);
    }
}