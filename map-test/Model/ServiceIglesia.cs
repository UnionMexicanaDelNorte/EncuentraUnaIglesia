using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace maptest.Model
{
    public class ServiceIglesia
    {
        //http://adventistasumn.org/encuentra/api.php/Inmuebles?filter=cd,cs,laredo
        static string URLService = "http://adventistasumn.org/encuentra/api.php/Inmuebles?filter={0},cs,{1}";
        public ServiceIglesia()
        {
        }
        public async void GetIglesias(string _filtro, string _value)
        {
            HttpClient _Client = new HttpClient();
            var url = string.Format(URLService, _filtro, _value);
            var content = await _Client.GetStringAsync(url);
            var post = JsonConvert.DeserializeObject<Iglesia>(content);
            //_post = new ObservableCollection<Post>(post);

            ////private string ShowRemoteStringFile(string url)
            ////{
            //    WebRequest req = WebRequest.Create(url);
            //WebResponse rsp = await req.GetResponseAsync().Result;
            //StreamReader rdr = new StreamReader(rsp.GetResponseStream());
            //string result = rdr.ReadToEnd();
            //}
        }
    }
}
