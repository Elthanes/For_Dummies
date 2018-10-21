using System;
using Newtonsoft.Json;
using Bla.Logic;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Net;
using System.Web.UI.WebControls;

namespace Bla.ctrl
{

    class HttpHelper
    {
        /// <summary>
        /// Attributes
        /// </summary>
        public static HttpHelper Instance = null;

        /// <summary>
        /// Singleton pattern for creating signle instance of HttpHelper
        /// </summary>
        /// <returns></returns>
        public static HttpHelper GetInstance()
        {
            if (HttpHelper.Instance == null)
            {
                Instance = new HttpHelper();
            }
            return Instance;
        }

        public static async Task<List<WeeklyDocumentation>> GetWeeklyDocumentations(int patient,string token)
        {
            String res;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token);
            string url = "https://ocy8h1fwlg.execute-api.eu-central-1.amazonaws.com/Ohne_auth/getpatientdocu/";
            var response = await client.GetAsync(url);
            res = response.Content.ReadAsStringAsync().Result;
            //AWSResponse resp = JsonConvert.DeserializeObject<AWSResponse>(res);
            List<WeeklyDocumentation> Alldocus = JsonConvert.DeserializeObject<List<WeeklyDocumentation>>(res);
            return Alldocus;
        }

        public static void SendNewsfeed(NewsFeedEntry news, string token)
        {
            string res;
            string Jap = JsonConvert.SerializeObject(news);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token);
                String url = "https://ocy8h1fwlg.execute-api.eu-central-1.amazonaws.com/Ohne_auth/addnewsfeedentry";
                var content = new StringContent(Jap, System.Text.Encoding.UTF8, "text/plain");
                using (var response = client.PostAsync(url, content).Result)
                {
                    res = response.Content.ReadAsStringAsync().Result;
                }
            }
            return;
        }

        /// <summary>
    }
}
