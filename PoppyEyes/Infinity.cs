using System;
using System.Windows.Forms;
using RestSharp;


namespace Infinity
{
    public class Net
    {
        // Checks if infinitygg.net is alive, if it isn't, then it's pointless to proceed
        public static void Health()
        {
            var client = new RestClient("https://api.infinitygg.net/v2/health");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK && !response.Content.Contains("alive"))
            {
                MessageBox.Show("There was an error while communicating with infinity. Verify your internet connection or try using a VPN. Report at https://infinitygg.net/join if the error persists.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        } 
        
    }
}
