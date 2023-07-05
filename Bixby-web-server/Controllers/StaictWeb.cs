using Bixby_web_server.Helpers;
using System.Net;

namespace Bixby_web_server.Controllers;

public static class StaticWeb
{
    public static async Task email_verify(HttpContext arg)
    {
        string text = Startup.GetFileContent(Startup.EmailVerificationIsDone);
        await arg.WriteResponse(text, "text/html", HttpStatusCode.OK).ConfigureAwait(false);    
    }

    public static async Task ResetPassword(HttpContext arg)
    {
        string text = Startup.GetFileContent(Startup.PasswordReset);
        await arg.WriteResponse(text, "text/html", HttpStatusCode.OK).ConfigureAwait(false);
    }
}