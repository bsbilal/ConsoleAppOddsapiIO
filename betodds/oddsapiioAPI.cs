using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web;

namespace betodds
{
    public static class oddsapiioAPI
    {
        private static string API_KEY = "YOUR-API-KEY";

        public static string makeAPICall()
        {
    
        var URL = new UriBuilder("https://app.oddsapi.io/api/v1/odds");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["sport"] = "soccer";
            queryString["country"] = "england";
            queryString["league"] = "soccer-england-premier-league";


            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("apikey", API_KEY);
            return client.DownloadString(URL.ToString());

        }
    }
}
