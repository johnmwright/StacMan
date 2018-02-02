#if !net4_0
namespace StackExchange.StacMan
{
    internal static class HttpUtility
    {
        public static string UrlEncode(string value) => System.Uri.EscapeUriString(value);
    }
}
#endif