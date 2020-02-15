using betodds;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Web;

class Program
{
   
    public static void Main(string[] args)
    {
        try
        {
            
            Console.WriteLine(JsonConvert.DeserializeObject(oddsapiioAPI.makeAPICall()));


        }
        catch (WebException e)
        {
            Console.WriteLine(e.Message);
        }
    }

}

