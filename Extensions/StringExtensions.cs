namespace ModulBank.Extensions
{
    internal static class StringExtensions
    {
        internal static string ToBase64(this string s)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(s);
            return System.Convert.ToBase64String(bytes);
        }
    }
}