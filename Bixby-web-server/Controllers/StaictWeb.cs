using Bixby_web_server.Helpers;

namespace Bixby_web_server.Controllers;

public static class StaticWeb
{
    public static async Task email_verify(HttpContext arg)
    {
        var text = Startup.GetFileContent(Startup.EmailVerificationIsDone);
        await arg.WriteResponse(text, "text/html").ConfigureAwait(false);
    }

    public static async Task ResetPassword(HttpContext arg)
    {
        var text = Startup.GetFileContent(Startup.PasswordReset);
         await arg.WriteResponse(text, "text/html").ConfigureAwait(false);
    }
}