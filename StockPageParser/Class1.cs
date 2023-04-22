using System.Net;

namespace StockPageParser
{
    public class StockPageParse
    {
        public readonly string URL;
        public string? page { get; private set; }

        public StockPageParse(string url) => URL = url;

        public async Task LoadPage()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Other");
                var response = await client.GetAsync(URL);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                page = content;
            }
        }

        public override string ToString()
        {
            return page == null ? "Page not loaded" : page;
        }
    }
}