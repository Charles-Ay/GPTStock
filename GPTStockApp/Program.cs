using StockPageParser;

namespace GPTStockApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            StockPageParse p = new("https://www.zerohedge.com/");
            await p.LoadPage();
        }
    }
}