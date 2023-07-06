using Bixby_web_server.Helpers;

namespace Bixby_web_server.Controllers;

public static class StaticWeb
{
    public static async Task email_verify(HttpContext arg)
    {
        var text = RedisCache.Get("email_verify");
        if (text == null)
        {
            text = Startup.GetFileContent(Startup.EmailVerificationIsDone);
            RedisCache.Set("email_verify", text);
        }

        await arg.WriteResponse(text, "text/html").ConfigureAwait(false);
    }

    public static async Task ResetPassword(HttpContext arg)
    {
        var text = RedisCache.Get("ResetPassword");
        if (text == null)
        {
            text = Startup.GetFileContent(Startup.PasswordReset);
            RedisCache.Set("ResetPassword", text);
        }

        await arg.WriteResponse(text, "text/html").ConfigureAwait(false);
    }
}