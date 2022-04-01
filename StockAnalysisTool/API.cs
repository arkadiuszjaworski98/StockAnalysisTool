using System.Net;
using System.Text.Json;

namespace StockAnalysisTool
{
    public class API
	{
		public API()
		{
            // replace the "demo" apikey below with your own key from https://www.alphavantage.co/support/#api-key
            string QUERY_URL = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=IBM&interval=5min&apikey=demo";
            Uri queryUri = new Uri(QUERY_URL);

            using (WebClient client = new WebClient())
            {

                dynamic json_data = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(client.DownloadString(queryUri));

                Console.WriteLine("This is the API");
                foreach (var group in json_data)
                    Console.WriteLine("Key: {0} Value: {1}", group.Key, group.Value);
                Console.WriteLine(json_data);

                // -------------------------------------------------------------------------

                // do something with the json_data
            }
        }
	}
}