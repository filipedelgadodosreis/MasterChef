namespace WebMVC.Infrastructure
{
    public static class Api
    {
        public static class Receita
        {
            public static string GetLatestCookies(string baseUri)
            {
                return $"{baseUri}receita";
            }
        }
    }
}
