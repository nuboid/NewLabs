using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab_AsyncAwait.Service
{
    internal class NasaBlueMarbleDownloader
    {
        private string URL = "https://eoimages.gsfc.nasa.gov/images/imagerecords/73000/73909/world.topo.bathy.200412.3x21600x10800.jpg";

        public string Download1()
        {
            var webClient = new WebClient();
            var bytes = webClient.DownloadData(new Uri(URL));

            return "Downloaded " + bytes.Length + " bytes";

            //Why do you think using WebClient is obsolete ?
        }

        public async Task<string> Download2()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(URL);
            var bytes = await response.Content.ReadAsByteArrayAsync();

            return "Downloaded " + bytes.Length + " bytes";
        }


        //Exercice 3.
        //Uncomment this method.
        //You will see it does not compile. Read the error message carefully.
        //Follow the proposed potential fix.
        //public string Download3()
        //{
        //    var httpClient = new HttpClient();
        //    var response = await httpClient.GetAsync(URL);
        //    var bytes = await response.Content.ReadAsByteArrayAsync();

        //    return "Downloaded " + bytes.Length + " bytes";
        //}


        //Exercice 4.
        //Now use this method in the form instead of Download2. 
        //Start the download (Download2) again and check the debug window.
        //Also set a breakpoint on the return statement and hover over the response variable and examin the flyover message.
        //Fix the bug.
        public async Task<string> Download4()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(URL);

            Debug.WriteLine("The type of response is : " + response.GetType());

            return "didn't work";
        }
    }
}
