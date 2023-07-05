using Bixby_web_server.Helpers;
using System.Net;

namespace Bixby_web_server.Controllers;

public static class StaticWeb
{
    public static async Task email_verify(HttpContext arg)
    {
        string text = RedisCache.Get("email_verify");
        if(text == null)
        {
            text = Startup.GetFileContent(Startup.EmailVerificationIsDone);
            RedisCache.Set("email_verify", text);
        }
        await arg.WriteResponse(text, "text/html", HttpStatusCode.OK).ConfigureAwait(false);    
    }

    public static async Task ResetPassword(HttpContext arg)
    {
        string text = RedisCache.Get("ResetPassword");
        if (text == null)
        {
            text = Startup.GetFileContent(Startup.PasswordReset);
            RedisCache.Set("ResetPassword", text);
        }
        await arg.WriteResponse(text, "text/html", HttpStatusCode.OK).ConfigureAwait(false);
    }
}